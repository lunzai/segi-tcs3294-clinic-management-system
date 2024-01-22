/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Validators;

namespace cms.Models
{
    public class DoctorForm : BaseForm
    {
        public Doctor Model { get; set; } = new Doctor();
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DoctorForm(Doctor model)
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
            DoctorValidator validator = new DoctorValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
