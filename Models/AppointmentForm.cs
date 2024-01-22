/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Validators;
using System;

namespace cms.Models
{
    public class AppointmentForm : BaseForm
    {
        public bool HasConflictingPending { get; set; } = false;
        public bool HasConflictingConfirmed { get; set; } = false;
        public Appointment Model { get; set; } = new Appointment();
        public DateTime Date { get; set; }
        public Timeslot Timeslot { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public AppointmentForm(Appointment model, User CurrentUser)
        {
            Model = model;
            Model.StaffId = (int)CurrentUser.Id;
        }
        public void LoadModel()
        {
            Date = new DateTime(Date.Year, Date.Month, Date.Day);
            Model.Start = Date.AddSeconds(Timeslot.StartTimeSecond);
            Model.StartSecond = Timeslot.StartTimeSecond;
            Model.End = Date.AddSeconds(Timeslot.EndTimeSecond);
            Model.EndSecond = Timeslot.EndTimeSecond;
            Model.DoctorId = DoctorId;
            Model.PatientId = PatientId;
        }
        public bool Save()
        {
            if (!Validate())
            {
                return false;
            }
            LoadModel();
            return Model.Save();
        }
        public override bool Validate()
        {
            AppointmentValidator validator = new AppointmentValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
