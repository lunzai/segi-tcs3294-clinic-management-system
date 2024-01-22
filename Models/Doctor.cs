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
    public class Doctor : BaseModel
    {
        public const string STATUS_ACTIVE = "Active";
        public const string STATUS_DELETED = "Deleted";

        private string _tableName = "Doctors";
        [Index(1)]
        public string Name { get; set; }
        [Name("Contact Number")]
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Status { get; set; } = STATUS_ACTIVE;
        [Name("Created At")]
        public DateTime? CreatedAt { get; set; } = null;
        [Name("Updated At")]
        public DateTime? UpdatedAt { get; set; } = null;
        [Ignore]
        public DateTime? DeletedAt { get; set; } = null;
        [Ignore]
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        public bool Save()
        {
            try
            {
                if (IsNewRecord)
                { // insert
                    string sql = $@"
                        INSERT INTO {_tableName} 
                        (
                            Name, ContactNumber, Email, Address, Status, CreatedAt, UpdatedAt
                        )
                        VALUES (
                            @Name, @ContactNumber, @Email, @Address, @Status, @Now, @Now
                        )
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        Name, ContactNumber, Email, Address, Status, DateTime.Now
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
                        SET Name = @Name, ContactNumber = @ContactNumber, Email = @Email, 
                        Address = @Address, Status = @Status, UpdatedAt = @Now
                        WHERE Id = @Id                    
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        Id, Name, ContactNumber, Email, Address, Status, DateTime.Now,
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
        public List<Doctor> FindAll()
        {
            List<Doctor> models = new List<Doctor>();
            DateTime now = DateTime.Now;
            string sql = $@"
                SELECT * FROM {_tableName} d
                LEFT JOIN Appointments a ON a.DoctorId = d.Id AND a.Status != @StatusDeleted
                LEFT JOIN Patients p on a.PatientId = p.Id
                WHERE d.Status = @StatusActive 
                ORDER BY d.Id DESC, a.ID DESC
            ";
            models = GetDb()
                .Query<Doctor, Appointment, Patient, Doctor>(sql, (doctor, appointment, patient) =>
                {
                    if (appointment != null)
                    {
                        if (patient != null)
                        {
                            appointment.Patient = patient;
                        }
                        doctor.Appointments.Add(appointment);
                    }
                    return doctor;
                },
                param: new { 
                    StatusActive = STATUS_ACTIVE,
                    StatusDeleted = STATUS_DELETED,
                },
                splitOn: "Id,Id,Id")
                .ToList();
            return models
                .GroupBy(model => model.Id)
                .Select(items => {
                    var grouped = items.First();
                    grouped.Appointments = items
                        .Where(item => item.Appointments.Count > 0)
                        .Select(item => item.Appointments.Single()).ToList();
                    return grouped;
                })
                .ToList();
        }

    }
}
