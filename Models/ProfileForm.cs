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
    public class ProfileForm : BaseForm
    {
        //public ValidationResult ValidationResults { get; set; }
        //public bool HasValidationError { get => !ValidationResults.IsValid; }
        public User User { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmploymentType { get; set; }
        public ProfileForm(User user) { 
            this.User = user; 
        }
        public bool Save()
        {
            if (User == null || !Validate())
            {
                return false;
            }
            User.Username = Username;
            User.Name = Name;
            User.Email = Email;
            User.ContactNumber = ContactNumber;
            User.Address = Address;
            User.DateOfBirth = new DateTime(DateOfBirth.Year, DateOfBirth.Month, DateOfBirth.Day, 0, 0, 0);
            User.EmploymentType = EmploymentType;
            return User.Save();
        }
        public override bool Validate()
        {
            ProfileValidator validator = new ProfileValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
