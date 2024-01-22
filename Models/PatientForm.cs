/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Validators;

namespace cms.Models
{
    public class PatientForm : BaseForm
    {
        public Patient Model { get; set; } = new Patient();
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public PatientForm(Patient model)
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
            Model.Email = Email;
            Model.ContactNumber = ContactNumber;
            Model.Address = Address;
            return Model.Save();
        }
        public override bool Validate()
        {
            PatientValidator validator = new PatientValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
