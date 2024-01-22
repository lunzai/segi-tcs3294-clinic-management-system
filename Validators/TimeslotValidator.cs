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
    public class TimeslotValidator : AbstractValidator<Timeslot>
    {
        public TimeslotValidator()
        {
            RuleFor(m => m.StartTime)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();
            RuleFor(m => m.EndTime)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();
            RuleFor(m => m.StartTimeSecond)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(m => m.EndTimeSecond)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .GreaterThanOrEqualTo(m => m.StartTimeSecond);
        }
    }
}
