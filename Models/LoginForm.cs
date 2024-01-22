/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using cms.Validators;
using System;

namespace cms.Models
{
    public class LoginForm : BaseForm
    {
        private string _username;
        public User User { get; set; }
        public string Username
        {
            get { return _username; }
            set { _username = value.ToLower().Trim(); }
        }
        public string Password { get; set; }
        public bool Login()
        {
            if (Validate() == false)
            {
                return false;
            }
            try
            {
                User = new User();
                User = User.FindByUsername(Username);
                return User.IsActive && Hash.Verify(Password, User.PasswordHash);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool Validate()
        {
            LoginValidator validator = new LoginValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }

    }
}
