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
    public class ChangePasswordValidator : AbstractValidator<ChangePasswordForm>
    {
        public ChangePasswordValidator()
        {
            RuleFor(m => m.CurrentPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(3, 100)
                .Must(ValidateCurrentPassword).WithMessage("{PropertyName} do not match.");
            RuleFor(m => m.NewPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(6, 100);
            RuleFor(m => m.NewPasswordRepeat)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(6, 100)
                .Equal(m => m.NewPassword).WithMessage("{ComparisonProperty} do not match.");
        }
        protected bool ValidateCurrentPassword(ChangePasswordForm form, string value)
        {
            return Hash.Verify(value, form.User.PasswordHash);
        }
    }
}
