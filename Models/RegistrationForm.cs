/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Validators;
using System;

namespace cms.Models
{
    public class RegistrationForm : BaseForm
    {
        public User Model { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Status { get; set; } = User.STATUS_INACTIVE;
        public DateTime DateOfBirth { get; set; }
        public string EmploymentType { get; set; }
        public bool Register()
        {
            if (!Validate())
            {
                return false;
            }
            Model = new User();
            Model.Username = Username;
            Model.Name = Name;
            Model.Email = Email;
            Model.ContactNumber = ContactNumber;
            Model.Address = Address;
            Model.DateOfBirth = DateOfBirth;
            Model.EmploymentType = EmploymentType;
            Model.Type = User.TYPE_STAFF;
            Model.Status = User.STATUS_INACTIVE;
            Model.SetPassword(Password);
            return Model.Save();
        }
        public override bool Validate()
        {
            RegistrationValidator validator = new RegistrationValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
