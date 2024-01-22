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
    public partial class LoginView : Form
    {
        private AuthenticationWindowView _parentView;
        public LoginView(AuthenticationWindowView parentForm)
        {
            InitializeComponent();
            _parentView = parentForm;
            ToolTip.SetToolTip(this.BtnHelp, "Feel free to use the following demo accounts\n - admin : admin1234\n - staff1 : staff1234\n - staff2 : staff1234");
        }
        private void LoginView_Load(object sender, EventArgs e)
        {
        }
        private void ResetForm()
        {
            InputUsername.Text = string.Empty;
            InputPassword.Text = string.Empty;
        }
        private void DisableFields()
        {
            InputUsername.Enabled = false;
            InputPassword.Enabled = false;
            BtnLogin.Enabled = false;
            BtnRegister.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
        }
        private void EnableFields()
        {
            InputUsername.Enabled = true;
            InputPassword.Enabled = true;
            BtnLogin.Enabled = true;
            BtnRegister.Enabled = true;
            Cursor.Current = Cursors.Default;
        }
        private void Login()
        {
            DisableFields();
            LoginForm form = new LoginForm();
            form.Username = InputUsername.Text;
            form.Password = InputPassword.Text;
            if (!form.Login())
            {
                if (form.HasValidationError)
                {
                    Helper.ShowValidationErrorDialog(form.ValidationResults);
                } else
                {
                    MessageBox.Show(
                        "Incorrect username or password.",
                        "Unable To Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    InputPassword.Text = string.Empty;
                }
            } else
            {
                ResetForm();
                form.User.TouchLastLogonAt();
                MainWindowView app = new MainWindowView(form.User, _parentView);
                _parentView.Hide();
                app.Show();
            }
            EnableFields();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            _parentView.DisplayChildForm(new RegistrationView(_parentView));
        }
        private void InputUsername_TextChanged(object sender, EventArgs e)
        {
            InputUsername.Text = InputUsername.Text.Trim().ToLower();
            InputUsername.Select(InputUsername.Text.Length, 0);
        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
