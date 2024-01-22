/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Validators;

namespace cms.Models
{
    public class MedicationForm : BaseForm
    {
        public Medication Model { get; set; } = new Medication();
        public string Name { get; set; }
        public string Category { get; set; }
        public double UnitPrice { get; set; }
        public double SellingPrice { get; set; }
        public string Status { get; set; } = Medication.STATUS_ACTIVE;        
        public MedicationForm(Medication model)
        {
            Model = model;
        }
        public bool Save()
        {
            if (!Validate())
            {
                return false;
            }
            Model.Name = Name;
            Model.Category = Category;
            Model.UnitPrice = UnitPrice;
            Model.SellingPrice = SellingPrice;
            Model.Status = Status;
            return Model.Save();
        }
        public override bool Validate()
        {
            MedicationValidator validator = new MedicationValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
