/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using CsvHelper.Configuration.Attributes;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cms.Models
{
    public class Medication : BaseModel
    {
        public const string STATUS_ACTIVE = "Active";
        public const string STATUS_DELETED = "Deleted";

        private string _tableName = "Medications";
        [Index(1)]
        public string Name { get; set; }
        public string Category { get; set; }
        [Name("Total Qty")]
        public int TotalQty { get; set; }
        [Name("Stock Qty")]
        public int StockQty { get; set; }
        [Name("Sold Qty")]
        public int SoldQty { get; set; }
        [Name("Unit Price")]
        public double UnitPrice { get; set; }
        [Name("Selling Price")]
        public double SellingPrice { get; set; }
        public string Status { get; set; } = STATUS_ACTIVE;
        [Name("Created At")]
        public DateTime? CreatedAt { get; set; } = null;
        [Name("Updated At")]
        public DateTime? UpdatedAt { get; set; } = null;
        [Ignore]
        public DateTime? DeletedAt { get; set; } = null;
        [Ignore]
        public List<Order> Orders { get; set; } = new List<Order>();
        [Ignore]
        public List<string> Categories = new List<string>
        {
            "Analgesics", "Antacids", "Antianxiety Drugs", "Antiarrhythmics",
            "Antibacterials", "Antibiotics", "Anticoagulants and Thrombolytics",
            "Anticonvulsants", "Antidepressants", "Antidiarrheals", "Antiemetics",
            "Antifungals", "Antihistamines", "Antihypertensives", "Anti-Inflammatories",
            "Antineoplastics", "Antipsychotics", "Antipyretics", "Antivirals",
            "Barbiturates", "Beta-Blockers", "Bronchodilators", "Cold Cures",
            "Corticosteroids", "Cough Suppressants", "Cytotoxics", "Decongestants",
            "Diuretics", "Expectorant", "Hormones", "Hypoglycemics (Oral)",
            "Immunosuppressives", "Laxatives", "Muscle Relaxants", "Sedatives",
            "Sex Hormones (Female)", "Sex Hormones (Male)", "Sleeping Drugs",
            "Tranquilizer", "Vitamins",
        };
        [Ignore]
        public string DisplayName { get => this.ToString(); }
        public override string ToString()
        {
            return $"{Name}\n{Category}\nQty: {StockQty}";
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
                            Name, Category, TotalQty, StockQty, SoldQty, 
                            UnitPrice, SellingPrice, Status, CreatedAt, UpdatedAt
                        )
                        VALUES (
                            @Name, @Category, @TotalQty, @StockQty, @SoldQty,
                            @UnitPrice, @SellingPrice, @Status, @Now, @Now
                        )
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        Name, Category, TotalQty, StockQty, SoldQty, UnitPrice, SellingPrice, Status, DateTime.Now
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
                        SET Name = @Name, Category = @Category, TotalQty = @TotalQty, StockQty = @StockQty, SoldQty = @SoldQty,
                            UnitPrice = @UnitPrice, SellingPrice = @SellingPrice, Status = @Status, UpdatedAt = @Now
                        WHERE Id = @Id                    
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        Id, Name, Category, TotalQty, StockQty, SoldQty, UnitPrice, SellingPrice, Status, DateTime.Now,
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
        public bool RecalculateStock()
        {
            try
            {
                string sql = $@"SELECT TotalQty, SoldQty, TotalQty - SoldQty AS StockQty
                FROM
                (
                    SELECT
                        COALESCE((SELECT SUM(Qty) FROM Orders WHERE MedicationId = @Id AND Status = @StatusReceived), 0) as TotalQty,
	                    COALESCE((SELECT SUM(Qty) FROM AppointmentMedications WHERE MedicationId = @Id AND Status = @StatusCompleted), 0) as SoldQty
                )";
                var stock = GetDb().QuerySingle(sql, new
                {
                    Id,
                    StatusReceived = Order.STATUS_RECEIVED,
                    StatusCompleted = AppointmentMedication.STATUS_COMPLETED,
                });
                TotalQty = (int)stock.TotalQty;
                SoldQty = (int)stock.SoldQty;
                StockQty = (int)stock.StockQty;
                if (TotalQty < 0) { 
                    TotalQty = 0; 
                }
                if (SoldQty < 0) { 
                    SoldQty = 0; 
                }
                if (StockQty < 0)
                {
                    StockQty = 0;
                }
                return Save();
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
                return GetDb().Execute(
                    $@"UPDATE {_tableName} SET Status = @Status, DeletedAt = @Now, UpdatedAt = @Now WHERE Id = @Id",
                    new { Id, Status = STATUS_DELETED, DateTime.Now }
                ) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Medication> FindAll()
        {
            List<Medication> models = new List<Medication>();
            string sql = $@"
                SELECT * FROM {_tableName} m
                LEFT JOIN Orders o ON o.MedicationId = m.Id AND o.Status != @StatusDeleted
                WHERE m.Status = @Status
                ORDER BY m.Id DESC, o.Id DESC
            ";
            models = GetDb()
                .Query<Medication, Order, Medication>(sql, (medication, orders) =>
                {
                    if (orders != null)
                    {
                        medication.Orders.Add(orders);
                    }
                    return medication;
                },
                param: new { 
                    Status = STATUS_ACTIVE,
                    StatusDeleted = STATUS_DELETED,
                },
                splitOn: "Id,Id")
                .ToList();
            return models
                .GroupBy(model => model.Id)
                .Select(items => {
                    var grouped = items.First();
                    grouped.Orders = items
                        .Where(item => item.Orders.Count > 0)
                        .Select(item => item.Orders.Single())
                        .ToList();
                    return grouped;
                })
                .ToList();
        }
    }

}
