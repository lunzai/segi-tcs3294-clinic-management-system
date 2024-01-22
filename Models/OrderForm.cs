/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Validators;

namespace cms.Models
{
    public class OrderForm : BaseForm
    {
        public Order Model { get; set; } = new Order();
        public string SupplierName { get; set; }
        public int MedicationId { get; set; }
        public int Qty { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; } = Order.STATUS_PENDING;
        public OrderForm(Order model)
        {
            Model = model;
        }
        public bool Save()
        {
            if (!Validate())
            {
                return false;
            }
            Model.SupplierName = SupplierName;
            Model.MedicationId = MedicationId;
            Model.Qty = Qty;
            Model.UnitPrice = UnitPrice;
            Model.TotalPrice = TotalPrice;
            Model.Status = Status;
            return Model.Save();
        }
        public override bool Validate()
        {
            OrderValidator validator = new OrderValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
