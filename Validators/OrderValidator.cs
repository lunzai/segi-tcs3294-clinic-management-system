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
    public class OrderValidator : AbstractValidator<OrderForm>
    {
        public OrderValidator()
        {
            RuleFor(m => m.SupplierName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(3, 100);
            RuleFor(m => m.MedicationId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Must(ValidateMedicationExist);
            RuleFor(m => m.Qty)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(m => m.UnitPrice)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(m => m.TotalPrice)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
        }
        protected bool ValidateMedicationExist(OrderForm form, int id)
        {
            return true;
        }
    }
}
