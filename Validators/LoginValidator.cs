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
    public class LoginValidator : AbstractValidator<LoginForm>
    {
        public LoginValidator()
        {
            RuleFor(m => m.Username)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(3, 50)
                .Must(Helper.IsLetterOrDigit).WithMessage("{PropertyName} must be alphanumeric.");
            RuleFor(m => m.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(6, 100);
        }
    }
}
