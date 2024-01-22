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
    public partial class RegistrationView : Form
    {
        private AuthenticationWindowView _parentView;
        public RegistrationView(AuthenticationWindowView parentForm)
        {
            InitializeComponent();
            _parentView = parentForm;
            InputDateOfBirth.MinDate = DateTime.Now.AddYears(-99);
            InputDateOfBirth.MaxDate = DateTime.Now.AddYears(-16);
            InputEmploymentType.Items.Add(User.EMPLOYMENT_FULLTIME);
            InputEmploymentType.Items.Add(User.EMPLOYMENT_PARTTIME);
        }
        private void ResetForm()
        {
            InputName.ResetText();
            InputPassword.ResetText();
            InputPasswordRepeat.ResetText();
            InputUsername.ResetText();
            InputEmail.ResetText();
            InputContactNumber.ResetText();
            InputAddress.ResetText();
            InputDateOfBirth.ResetText();
            InputEmploymentType.ResetText();
        }
        private void DisableFields()
        {
            InputName.Enabled = false;
            InputPassword.Enabled = false;
            InputPasswordRepeat.Enabled = false;
            InputUsername.Enabled = false;
            InputEmail.Enabled = false;
            InputContactNumber.Enabled = false;
            InputAddress.Enabled = false;
            InputDateOfBirth.Enabled = false;
            InputEmploymentType.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
        }
        private void EnableFields()
        {
            InputName.Enabled = true;
            InputPassword.Enabled = true;
            InputPasswordRepeat.Enabled = true;
            InputUsername.Enabled = true;
            InputEmail.Enabled = true;
            InputContactNumber.Enabled = true;
            InputAddress.Enabled = true;
            InputDateOfBirth.Enabled = true;
            InputEmploymentType.Enabled = true;
            Cursor.Current = Cursors.Default;
        }
        private void Register()
        {
            DisableFields();
            RegistrationForm form = new RegistrationForm();
            form.Name = InputName.Text.Trim();
            form.Password = InputPassword.Text.Trim();
            form.PasswordRepeat = InputPasswordRepeat.Text.Trim();
            form.Username = InputUsername.Text.Trim();
            form.Email = InputEmail.Text.Trim();
            form.ContactNumber = InputContactNumber.Text.Trim();
            form.Address = InputAddress.Text.Trim();
            form.DateOfBirth = InputDateOfBirth.Value;
            form.EmploymentType = InputEmploymentType.Text.Trim();
            
            if (!form.Register())
            {
                if (form.HasValidationError)
                {
                    Helper.ShowValidationErrorDialog(form.ValidationResults);
                } else
                {
                    Helper.ShowGenericErrorDialog();
                    InputPassword.Text = string.Empty;
                    InputPasswordRepeat.Text = string.Empty;
                }
            } else
            {
                ResetForm();
                MessageBox.Show(
                    "You can login after adminstator activate your account.",
                    "Registration successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                _parentView.DisplayChildForm(new LoginView(_parentView));
                return;
            }
            EnableFields();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
            _parentView.DisplayChildForm(new LoginView(_parentView));
        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }
        private void InputUsername_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
