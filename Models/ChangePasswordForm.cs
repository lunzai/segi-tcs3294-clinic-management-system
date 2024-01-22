/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Validators;

namespace cms.Models
{
    public class ChangePasswordForm : BaseForm
    {
        public User User { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordRepeat { get; set; }
        public ChangePasswordForm(User user)
        {
            User = user;
        }
        public bool Save()
        {
            if (Validate() == false)
            {
                return false;
            }
            return User.UpdatePassword(NewPassword);
        }
        public override bool Validate()
        {
            ChangePasswordValidator validator = new ChangePasswordValidator();
            ValidationResults = validator.Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
