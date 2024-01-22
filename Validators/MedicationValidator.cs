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
    public class MedicationValidator : AbstractValidator<MedicationForm>
    {
        public MedicationValidator()
        {
            RuleFor(m => m.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(3, 100);
            RuleFor(m => m.Category)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(3, 100);
            RuleFor(m => m.UnitPrice)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(m => m.SellingPrice)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
        }
    }
}
