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
    public class AppointmentMedication : BaseModel
    {
        public const string STATUS_PENDING = "Pending";
        public const string STATUS_COMPLETED = "Completed";

        private string _tableName = "AppointmentMedications";
        [Index(1)]
        [Name("Prescription ID")]
        public override int? Id { get; set; } = null;
        [Ignore]
        public int AppointmentId { get; set; }
        [Ignore]
        public int MedicationId { get; set; }
        [Index(3)]
        [Name("Selling Price")]
        public double SellingPrice { get; set; } = 0;
        public int Qty { get; set; } = 0;
        [Name("Total Price")]
        public double TotalPrice { get => SellingPrice * Qty; }
        [Ignore]
        public string Status { get; set; } = STATUS_PENDING;
        [Name("Prescription Added At")]
        public DateTime? CreatedAt { get; set; } = null;
        [Ignore]
        public Appointment Appointment { get; set; }
        [Ignore]
        public Medication Medication { get; set; }
        [Index(2)]
        [Name("Medication")]
        public string MedicationName { get => Medication?.Name ?? "-"; }
        [Ignore]
        public string DoctorName { get => Appointment?.Doctor?.Name; }
        [Ignore]
        public string PatientName { get => Appointment?.Patient?.Name; }
        [Ignore]
        public string AppointmentDate { get => Appointment?.Date; }

        public bool Save(Appointment appointment, Medication medication, int qty)
        {
            Qty = qty;
            SellingPrice = medication.SellingPrice;
            try
            {
                string sql = $@"
                    INSERT INTO {_tableName} 
                    (
                        AppointmentId, MedicationId, SellingPrice, Qty, TotalPrice, Status, CreatedAt
                    )
                    VALUES (
                        @AppointmentId, @MedicationId, @SellingPrice, @Qty, @TotalPrice, @Status, @Now
                    )
                ";
                int affectedRows = GetDb().Execute(sql, new
                {
                    AppointmentId = appointment.Id,
                    MedicationId = medication.Id,
                    SellingPrice,
                    Qty,
                    TotalPrice,
                    Status,
                    DateTime.Now
                });
                if (affectedRows > 0)
                {
                    int id = GetDb().ExecuteScalar<int>("SELECT last_insert_rowid()");
                    Id = id;
                    return true;
                };
                return false;
            }
            catch (Exception)
            {
                return false;
            }            
        }
        public bool Complete()
        {
            try
            {
                int result = GetDb().Execute(
                    $@"UPDATE {_tableName} SET Status = @Status WHERE Id = @Id",
                    new { Id, Status = STATUS_COMPLETED }
                );
                if (result > 0)
                {
                    Medication.RecalculateStock();
                    return true;
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
                    $@"DELETE FROM {_tableName} WHERE Id = @Id",
                    new { Id }
                );
                if (result > 0)
                {
                    Medication.RecalculateStock();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<AppointmentMedication> FindAllByPatientId(int id)
        {
            List<AppointmentMedication> models = new List<AppointmentMedication>();
            string sql = $@"
                SELECT * FROM {_tableName} am 
                LEFT JOIN Appointments a 
                    ON a.Id = am.AppointmentId 
                LEFT JOIN Doctors d ON d.Id = a.DoctorId
                LEFT JOIN Patients p ON p.Id = a.PatientId
                LEFT JOIN Medications m ON m.Id = am.MedicationId 
                WHERE a.PatientId = @Id 
                AND am.Status = @Status
            ";
            models = GetDb()
                .Query<
                    AppointmentMedication,
                    Appointment,
                    Doctor,
                    Patient,
                    Medication,
                    AppointmentMedication
                >(sql, (prescription, appointment, doctor, patient, medication) =>
                {
                    prescription.Medication = medication;
                    prescription.Appointment = appointment;
                    prescription.Appointment.Doctor = doctor;
                    prescription.Appointment.Patient = patient;
                    return prescription;
                },
                param: new { Status = Appointment.STATUS_COMPLETED, Id = id },
                splitOn: "Id,Id,Id,Id,Id")
                .ToList();
            return models;
        }
        public List<AppointmentMedication> FindAllByMedicationId(int id)
        {
            List<AppointmentMedication> models = new List<AppointmentMedication>();
            string sql = $@"
                SELECT * FROM {_tableName} am 
                LEFT JOIN Appointments a 
                    ON a.Id = am.AppointmentId 
                LEFT JOIN Doctors d ON d.Id = a.DoctorId
                LEFT JOIN Patients p ON p.Id = a.PatientId
                LEFT JOIN Medications m ON m.Id = am.MedicationId 
                WHERE am.MedicationId = @Id 
                AND am.Status = @Status
            ";
            models = GetDb()
                .Query<
                    AppointmentMedication,
                    Appointment,
                    Doctor,
                    Patient,
                    Medication,
                    AppointmentMedication
                >(sql, (prescription, appointment, doctor, patient, medication) =>
                {
                    prescription.Medication = medication;
                    prescription.Appointment = appointment;
                    prescription.Appointment.Doctor = doctor;
                    prescription.Appointment.Patient = patient;
                    return prescription;
                },
                param: new { Status = Appointment.STATUS_COMPLETED, Id = id },
                splitOn: "Id,Id,Id,Id,Id")
                .ToList();
            return models;
        }
    }
}
