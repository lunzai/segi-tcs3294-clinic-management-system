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
    public class StaffForm : BaseForm
    {
        public User Model { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmploymentType { get; set; }
        public StaffForm(User model) { 
            Model = model;
        }
        public bool Save()
        {
            if (!Validate())
            {
                return false;
            }
            Model.Username = Username;
            Model.Name = Name;
            Model.Email = Email;
            Model.ContactNumber = ContactNumber;
            Model.Address = Address;
            Model.DateOfBirth = DateOfBirth;
            Model.EmploymentType = EmploymentType;
            Model.Status = Status;
            if (Model.Save())
            {
                if (Password != string.Empty && PasswordRepeat != string.Empty)
                {
                    Model.UpdatePassword(Password);
                }
                return true;
            }
            return false;
        }
        public override bool Validate()
        {
            StaffValidator validator = new StaffValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
