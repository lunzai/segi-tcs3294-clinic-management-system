/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using CsvHelper.Configuration.Attributes;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cms.Models
{
    public class Order : BaseModel
    {
        public const string STATUS_PENDING = "Pending";
        public const string STATUS_RECEIVED = "Received";
        public const string STATUS_DELETED = "Deleted";

        private string _tableName = "Orders";
        [Index(1)]
        [Name("Supplier Name")]
        public string SupplierName { get; set; }
        [Ignore]
        public int MedicationId { get; set; }
        public int Qty { get; set; }
        [Name("Unit Price")]
        public double UnitPrice { get; set; }
        [Name("Total Price")]
        public double TotalPrice { get; set; }
        public string Status { get; set; } = STATUS_PENDING;
        [Name("Created At")]
        public DateTime? CreatedAt { get; set; } = null;
        [Name("Received At")]
        public DateTime? ReceivedAt { get; set; } = null;
        [Ignore]
        public DateTime? DeletedAt { get; set; } = null;
        [Ignore]
        public Medication Medication { get; set; }
        [Name("Is Received")]
        [BooleanTrueValues("Yes")]
        [BooleanFalseValues("No")]
        public bool IsReceived { get => ReceivedAt != null; }
        [Name("Is Pending")]
        [BooleanTrueValues("Yes")]
        [BooleanFalseValues("No")]
        public bool IsPending { get => Status == STATUS_PENDING; }
        [Ignore]
        public string DisplayName { get => this.ToString(); }
        [Index(2)]
        [Name("Medication")]
        public string MedicationName { get => Medication.Name; }
        public override string ToString()
        {
            return $"{SupplierName}\n{Medication.Name}\nQty: {Qty} ({Helper.AsCurrency(TotalPrice)})\nStatus: {Status}";
        }
        public bool Save()
        {
            try
            {
                if (IsNewRecord)
                { // insert
                    string sql = $@"
                        INSERT INTO {_tableName} 
                        (
                            SupplierName, MedicationId, Qty, UnitPrice, TotalPrice, Status, CreatedAt, UpdatedAt
                        )
                        VALUES (
                            @SupplierName, @MedicationId, @Qty, @UnitPrice, @TotalPrice, @Status, @Now, @Now
                        )
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        SupplierName, MedicationId, Qty, UnitPrice, TotalPrice, Status, DateTime.Now
                    });
                    if (affectedRows > 0)
                    {
                        int id = GetDb().ExecuteScalar<int>("SELECT last_insert_rowid()");
                        Id = id;
                        return true;
                    };
                }
                else
                { // update
                    string sql = $@"
                        UPDATE {_tableName} 
                        SET SupplierName = @SupplierName, MedicationId = @MedicationId, 
                            Qty = @Qty, UnitPrice = @UnitPrice, TotalPrice = @TotalPrice,
                            Status = @Status, UpdatedAt = @Now
                        WHERE Id = @Id                    
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        Id, SupplierName, MedicationId, Qty, UnitPrice, TotalPrice, Status, DateTime.Now,
                    });
                    if (affectedRows > 0)
                    {
                        return true;
                    };
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Receive()
        {
            try
            {
                int result = GetDb().Execute(
                    $@"UPDATE {_tableName} SET Status = @Status, ReceivedAt = @Now, UpdatedAt = @Now WHERE Id = @Id",
                    new { Id, Status = STATUS_RECEIVED, DateTime.Now }
                );
                if (result > 0)
                {
                    return Medication.RecalculateStock();
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete()
        {
            try
            {
                int result = GetDb().Execute(
                    $@"UPDATE {_tableName} SET Status = @Status, DeletedAt = @Now, UpdatedAt = @Now WHERE Id = @Id",
                    new { Id, Status = STATUS_DELETED, DateTime.Now }
                );
                if (result > 0)
                {
                    return IsReceived ? Medication.RecalculateStock() : true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Order> FindAll()
        {
            List<Order> models = new List<Order>();
            string sql = $@"
                SELECT * FROM {_tableName} o
                LEFT JOIN Medications m ON o.MedicationId = m.Id
                WHERE o.Status != @Status
            ";
            models = GetDb()
                .Query<Order, Medication, Order>(sql, (order, medication) =>
                {
                    order.Medication = medication;
                    return order;
                },
                param: new { Status = STATUS_DELETED },
                splitOn: "Id,Id")
                
                .ToList();
            return models;
        }
        public List<Order> FindByMedicationId(int medicationId)
        {
            List<Order> models = new List<Order>();
            string sql = $@"
                SELECT * FROM {_tableName} o
                LEFT JOIN Medications m ON o.MedicationId = m.Id
                WHERE o.MedicationId = @MedicationId
            ";
            models = GetDb()
                .Query<Order, Medication, Order>(sql, (order, medication) =>
                {
                    order.Medication = medication;
                    return order;
                },
                param: new { 
                    MedicationId = medicationId,
                },
                splitOn: "Id,Id")
                .ToList();
            return models;
        }
    }

}
