/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Models;
using FluentValidation;

namespace cms.Validators
{
    public class AppointmentValidator : AbstractValidator<AppointmentForm>
    {
        public AppointmentValidator()
        {
            RuleFor(m => m.Date)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();
            RuleFor(m => m.Timeslot)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();
            RuleFor(m => m.DoctorId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();
            RuleFor(m => m.PatientId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();
        }
    }
}
