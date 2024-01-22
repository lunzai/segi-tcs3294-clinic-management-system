/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using cms.Models;
using FluentValidation;

namespace cms.Validators
{
    public class PatientValidator : AbstractValidator<PatientForm>
    {
        public PatientValidator()
        {
            RuleFor(m => m.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(3, 50)
                .Must(Helper.IsValidName).WithMessage("{PropertyName} contains invalid character(s).");
            RuleFor(m => m.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .MaximumLength(50)
                .Matches(Helper.EMAIL_REGEX)
                    .WithMessage("{PropertyName} is not a valid email address.");
            RuleFor(m => m.ContactNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(6, 20)
                .Matches(@"^\+?[0-9-]{6,20}$")
                    .WithMessage("{PropertyName} contains invalid character(s).");
            RuleFor(m => m.Address)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(3, 200);
        }
    }
}
