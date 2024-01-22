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
    public class Appointment : BaseModel
    {
        public const string STATUS_CONFIRMED = "Confirmed";
        public const string STATUS_COMPLETED = "Completed";
        public const string STATUS_DELETED = "Deleted";
        public const string STATUS_PENDING = "Pending";

        private string _tableName = "Appointments";
        
        [Ignore]
        public DateTime Start { get; set; }
        [Ignore]
        public int StartSecond { get; set; } = 0;
        [Ignore]
        public DateTime End { get; set; }
        [Ignore]
        public int EndSecond { get; set; } = 0;
        [Ignore]
        public int DoctorId { get; set; }
        [Ignore]
        public int PatientId { get; set; }
        [Ignore]
        public int StaffId { get; set; }
        [Index(8)]
        [Name("Consult Note")]
        public string ConsultNote { get; set; } = string.Empty;
        [Index(9)]
        public string Status { get; set; } = STATUS_PENDING;
        [Index(13)]
        [Name("Confirmed At")]
        public DateTime? ConfirmedAt { get; set; } = null;
        [Index(14)]
        [Name("Completed At")]
        public DateTime? CompletedAt { get; set; } = null;
        [Index(15)]
        [Name("Created At")]
        public DateTime? CreatedAt { get; set; } = null;
        [Index(16)]
        [Name("Updated At")]
        public DateTime? UpdatedAt { get; set; } = null;
        [Ignore]
        [Name("Deleted At")]
        public DateTime? DeletedAt { get; set; } = null;
        [Ignore]
        public Doctor Doctor { get; set; } = null;
        [Ignore]
        public Patient Patient { get; set; } = null;
        [Ignore]
        public User Staff { get; set; } = null;
        [Index(10)]
        [Name("Is Pending")]
        [BooleanTrueValues("Yes")]
        [BooleanFalseValues("No")]
        public bool IsPending { get => Status == STATUS_PENDING; }
        [Index(11)]
        [Name("Is Confirmed")]
        [BooleanTrueValues("Yes")]
        [BooleanFalseValues("No")]
        public bool IsConfirmed { get => ConfirmedAt != null; }
        [Index(12)]
        [Name("Is Completed")]
        [BooleanTrueValues("Yes")]
        [BooleanFalseValues("No")]
        public bool IsCompleted { get => CompletedAt != null; }        
        [Ignore]
        public List<AppointmentMedication> AppointmentMedications { get; set; } = new List<AppointmentMedication>();
        [Ignore]
        public List<Medication> Medications { get; set; } = new List<Medication>();
        [Ignore]
        public string DisplayName { get => ToString(); }
        [Index(1)]
        [Name("Date")]
        public string Date { get => Start.ToString("dd/MM/yyyy"); }
        [Index(2)]
        [Name("Timeslot")]
        public string Timeslot { get => $"{StartTime} - {EndTime}"; }
        [Index(3)]
        [Name("Start Time")]
        public string StartTime { get => Start.ToString("HH:mm tt"); }
        [Index(4)]
        [Name("End Time")]
        public string EndTime { get => End.ToString("HH:mm tt"); }       
        [Index(5)]
        [Name("Doctor")]
        public string DoctorName { get => Doctor == null ? "-" : Doctor.Name; }
        [Index(6)]
        [Name("Patient")]
        public string PatientName { get => Patient == null ? "-" : Patient.Name; }
        [Index(7)]
        [Name("Staff")]
        public string StaffName { get => Staff == null ? "-" : Staff.Name; }
        [Ignore]
        public List<Timeslot> Timeslots = new List<Timeslot>() {
            new Timeslot(8, 0, 3600),
            new Timeslot(9, 0, 3600),
            new Timeslot(10, 0, 3600),
            new Timeslot(11, 0, 3600),
            new Timeslot(12, 0, 3600),
            new Timeslot(13, 0, 3600),
            new Timeslot(14, 0, 3600),
            new Timeslot(15, 0, 3600),
            new Timeslot(16, 0, 3600),
            new Timeslot(17, 0, 3600),
        };
        public override string ToString()
        {
            string consultNote = ConsultNote == string.Empty ? "Empty" : "Filled";
            string summary = $"{Start.ToString("yyyy-MM-dd")} - {Start.ToString("HH:mm")} to {End.ToString("HH:mm")}\n";
            summary += $"Doctor: {Doctor.Name}\nPatient: {Patient.Name}\nStatus: {Status}\n";
            summary += $"Consult Note: {consultNote}\nPrescription: {AppointmentMedications.Count}";
            return summary;
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
                            Start, End, StartSecond, EndSecond, DoctorId, PatientId,
                            StaffId, Status, CreatedAt, UpdatedAt
                        )
                        VALUES (
                            @Start, @End, @StartSecond, @EndSecond, @DoctorId, @PatientId,
                            @StaffId, @Status, @Now, @Now
                        )
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        Start, End, StartSecond, EndSecond, DoctorId, PatientId,
                        StaffId, Status, DateTime.Now
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
                        SET Start = @Start, End = @End, StartSecond = @StartSecond, 
                        EndSecond = @EndSecond, DoctorId = @DoctorId, PatientId = @PatientId,
                        StaffId = @StaffId, UpdatedAt = @Now
                        WHERE Id = @Id                    
                    ";
                    int affectedRows = GetDb().Execute(sql, new
                    {
                        Id, Start, End, StartSecond, EndSecond, DoctorId, PatientId, 
                        StaffId, DateTime.Now
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
        public bool UpdateConsultNote(string note)
        {
            if (!IsConfirmed || IsCompleted)
            {
                return false;
            }
            try
            {
                ConsultNote = note.Trim();
                return GetDb().Execute(
                    $@"UPDATE {_tableName} SET ConsultNote = @ConsultNote, UpdatedAt = @Now WHERE Id = @Id",
                    new { Id, ConsultNote, DateTime.Now }
                ) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Confirm()
        {
            if (!IsPending)
            {
                return false;
            }
            try
            {
                return GetDb().Execute(
                    $@"UPDATE {_tableName} SET Status = @Status, ConfirmedAt = @Now, UpdatedAt = @Now WHERE Id = @Id",
                    new { Id, Status = STATUS_CONFIRMED, DateTime.Now }
                ) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Complete()
        {
            if (!IsConfirmed || IsCompleted)
            {
                return false;
            }
            try
            {
                int result = GetDb().Execute(
                    $@"UPDATE {_tableName} SET Status = @Status, CompletedAt = @Now, UpdatedAt = @Now WHERE Id = @Id",
                    new { Id, Status = STATUS_COMPLETED, DateTime.Now }
                );
                if (result > 0)
                {
                    foreach (AppointmentMedication item in AppointmentMedications)
                    {
                        item.Complete();
                    }
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
            if (IsCompleted)
            {
                return false;
            }
            try
            {
                int result = GetDb().Execute(
                    $@"UPDATE {_tableName} SET Status = @Status, DeletedAt = @Now, UpdatedAt = @Now WHERE Id = @Id",
                    new { Id, Status = STATUS_DELETED, DateTime.Now }
                );
                if (result > 0)
                {
                    foreach (AppointmentMedication item in AppointmentMedications)
                    {
                        item.Delete();
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Appointment FindPendingAvailability(Appointment model)
        {
            string sql = $@"
                SELECT Id FROM {_tableName} 
                WHERE DoctorId = @DoctorId
                AND Start = @Start
                AND End = @End
                AND Status = @Status
                AND Id IS NOT @Id
                LIMIT 1
            ";
            return GetDb().QueryFirst<Appointment>(sql, new
            {
                model.DoctorId,
                model.Start,
                model.End,
                Status = STATUS_PENDING,
                Id = model.IsNewRecord ? null : model.Id,
            });
        }
        public Appointment FindConfirmedAvailability(Appointment model)
        {
            string sql = $@"
                SELECT Id FROM {_tableName} 
                WHERE DoctorId = @DoctorId 
                AND Start = @Start
                AND End = @End
                AND Status = @Status
                AND Id IS NOT @Id
                LIMIT 1
            ";
            return GetDb().QueryFirst<Appointment>(sql, new
            {
                model.DoctorId,
                model.Start,
                model.End,
                Status = STATUS_CONFIRMED,
                Id = model.IsNewRecord ? null : model.Id,
            });
        }
        public List<Appointment> FindAll()
        {
            List<Appointment> models = new List<Appointment>();
            string sql = $@"
                SELECT * FROM {_tableName} a
                LEFT JOIN Doctors d ON d.Id = a.DoctorId 
                LEFT JOIN Patients p ON p.Id = a.PatientId
                LEFT JOIN Users u ON u.Id = a.StaffId
                LEFT JOIN AppointmentMedications am 
                    ON am.AppointmentId = a.Id 
                    AND am.Status != @Status
                LEFT JOIN Medications m ON am.MedicationId = m.Id 
                WHERE a.Status != @Status                 
            ";
            models = GetDb()
                .Query<
                    Appointment, 
                    Doctor, 
                    Patient, 
                    User, 
                    AppointmentMedication, 
                    Medication, 
                    Appointment
                >(sql, (appointment, doctor, patient, staff, appointmentMedication, medication) =>
                {
                    appointment.Doctor = doctor;
                    appointment.Patient = patient;
                    appointment.Staff = staff;
                    if (appointmentMedication != null)
                    {
                        appointmentMedication.Medication = medication;
                        appointmentMedication.Appointment = appointment;
                        appointment.AppointmentMedications.Add(appointmentMedication);
                    }
                    if (medication != null)
                    {
                        appointment.Medications.Add(medication);
                    }                    
                    return appointment;
                },
                param: new { Status = STATUS_DELETED },
                splitOn: "Id,Id,Id,Id,Id,Id")
                .ToList();
            return models
                .GroupBy(model => model.Id)
                .Select(items => {
                    var grouped = items.First();
                    grouped.AppointmentMedications = items
                        .Where(item => item.AppointmentMedications.Count > 0)
                        .Select(item => item.AppointmentMedications.Single())
                        .ToList();
                    grouped.Medications = items
                        .Where(item => item.Medications.Count > 0)
                        .Select(item => item.Medications.Single()).ToList();
                    return grouped;
                })
                .ToList();
        }
    }


}
