/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using cms.Models;
using System;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class ProfileView : Form
    {
        private readonly MainWindowView _parentView;
        private User _user;
        private User _userReset;
        public ProfileView(MainWindowView parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            _user = _parentView.CurrentUser;
            _userReset = _parentView.CurrentUser;
            PDIDateOfBirth.MaxDate = DateTime.Now.AddYears(-16);
            PDIDateOfBirth.MinDate = DateTime.Now.AddYears(-99);
            PDIEmploymentStatus.Items.Add(User.EMPLOYMENT_PARTTIME);
            PDIEmploymentStatus.Items.Add(User.EMPLOYMENT_FULLTIME);
            if (_user.IsAdmin)
            {
                PDIEmploymentStatus.Visible = false;
                PDLEmploymentStatus.Visible = false;
            } else
            {
                PDLEmploymentStatus.Enabled = false;
            }
            LoadProfileForm(_user);
        }
        private void DisableChangePasswordForm()
        {
            CPICurrentPassword.Enabled = false;
            CPINewPassword.Enabled = false;
            CPINewPasswordRepeat.Enabled = false;
        }
        private void EnableChangePasswordForm()
        {
            CPICurrentPassword.Enabled = true;
            CPINewPassword.Enabled = true;
            CPINewPasswordRepeat.Enabled = true;
        }
        private void ResetChangePasswordForm()
        {
            CPICurrentPassword.Text = string.Empty;
            CPINewPassword.Text = string.Empty;
            CPINewPasswordRepeat.Text = string.Empty;
        }
        private void ChangePassword()
        {
            DisableChangePasswordForm();
            ChangePasswordForm form = new ChangePasswordForm(_parentView.CurrentUser);
            form.CurrentPassword = CPICurrentPassword.Text;
            form.NewPassword = CPINewPassword.Text;
            form.NewPasswordRepeat = CPINewPasswordRepeat.Text;
            if (!form.Save())
            {
                if (form.HasValidationError)
                {
                    Helper.ShowValidationErrorDialog(form.ValidationResults);
                } else
                {
                    Helper.ShowGenericErrorDialog();
                }
            }
            else
            {
                ResetChangePasswordForm();
                MessageBox.Show(
                    "Password changed successfully.",
                    "Password Changed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            EnableChangePasswordForm();
        }
        private void CPBUpdate_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
        private void CPBReset_Click(object sender, EventArgs e)
        {
            ResetChangePasswordForm();
        }
        private void ChangePasswordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangePassword();
            }
        }
        private void EnableProfileForm()
        {
            PDIAddress.Enabled = true;
            PDIContactNumber.Enabled = true;
            PDIDateOfBirth.Enabled = true;
            PDIEmail.Enabled = true;
            PDIEmploymentStatus.Enabled = true;
            PDIName.Enabled = true;
        }
        private void DisableProfileForm()
        {
            PDIAddress.Enabled = false;
            PDIContactNumber.Enabled = false;
            PDIDateOfBirth.Enabled = false;
            PDIEmail.Enabled = false;
            PDIEmploymentStatus.Enabled = false;
            PDIName.Enabled = false;
        }
        private void LoadProfileForm(User model)
        {
            PDIUsername.Text = model.Username;
            PDIAddress.Text = model.Address;
            PDIContactNumber.Text = model.ContactNumber;
            PDIDateOfBirth.Text = model.DateOfBirth.ToString();
            PDIEmail.Text = model.Email;
            PDIEmploymentStatus.Text = model.EmploymentType;
            PDIName.Text = model.Name;
        }
        private void UpdateProfile()
        {
            DisableProfileForm();
            ProfileForm form = new ProfileForm(_parentView.CurrentUser);
            form.Username = PDIUsername.Text;
            form.Address = PDIAddress.Text;
            form.ContactNumber = PDIContactNumber.Text;
            form.DateOfBirth = PDIDateOfBirth.Value;
            form.Email = PDIEmail.Text;
            form.EmploymentType = PDIEmploymentStatus.Text;
            form.Name = PDIName.Text;
            if (!form.Save())
            {
                if (form.HasValidationError)
                {
                    Helper.ShowValidationErrorDialog(form.ValidationResults);
                }
                else
                {
                    Helper.ShowGenericErrorDialog();
                }
            }
            else
            {
                MessageBox.Show(
                    "Profile updated successfully.",
                    "Profile Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            EnableProfileForm();
        }
        private void ProfileInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateProfile();
            }
        }
        private void PDBUpdate_Click(object sender, EventArgs e)
        {
            UpdateProfile();
        }
        private void PDBReset_Click(object sender, EventArgs e)
        {
            LoadProfileForm(_userReset);
            _user = _userReset;
        }
        private void PDIDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(PDIDateOfBirth.Value);
            Console.WriteLine(PDIDateOfBirth.Text);
        }
    }
}
