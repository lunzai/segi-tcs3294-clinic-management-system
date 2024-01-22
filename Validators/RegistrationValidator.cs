/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using cms.Models;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace cms.Validators
{
    public class RegistrationValidator : AbstractValidator<RegistrationForm>
    {
        public RegistrationValidator()
        {
            var employmentType = new List<string> { User.EMPLOYMENT_PARTTIME, User.EMPLOYMENT_FULLTIME };
            var status = new List<string> { User.STATUS_ACTIVE, User.STATUS_INACTIVE };
            RuleFor(m => m.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(3, 50)
                .Must(Helper.IsValidName)
                    .WithMessage("{PropertyName} contains invalid character(s).");
            RuleFor(m => m.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(6, 100);
            RuleFor(m => m.PasswordRepeat)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(6, 100)
                .Equal(m => m.Password)
                    .WithMessage("{ComparisonProperty} do not match.");
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
            RuleFor(m => m.Username)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(3, 50)
                .Must(Helper.IsLetterOrDigit)
                    .WithMessage("{PropertyName} contains invalid character(s).")
                .Must(ValidateUniqueUsername)
                    .WithMessage("{PropertyName} has already been taken.");
            RuleFor(m => m.DateOfBirth)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now.AddYears(-16))
                    .WithMessage("Age must be minimum of 16 years.")
                .GreaterThanOrEqualTo(DateTime.Now.AddYears(-99))
                    .WithMessage("Age must be maximum of 99 years.");
            RuleFor(m => m.EmploymentType)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Must(value => employmentType.Contains(value))
                    .WithMessage("{PropertyName} is invalid.");
            RuleFor(m => m.Status)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Must(value => status.Contains(value))
                    .WithMessage("{PropertyName} is invalid.");
        }
        protected bool ValidateUniqueUsername(string value)
        {
            try
            {
                User user = new User();
                user.FindByUsername(value);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
