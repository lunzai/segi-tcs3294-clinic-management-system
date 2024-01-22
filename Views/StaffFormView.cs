/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using cms.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class StaffFormView : Form
    {
        public StaffView ParentView;
        public User Model;
        private User _originalModel;
        private List<string> _changedAttributes = new List<string> { };
        public StaffFormView(StaffView parentView, User model)
        {
            InitializeComponent();
            ParentView = parentView;
            Model = model;
            _originalModel = model;
            InputEmploymentStatus.Items.Add(User.EMPLOYMENT_FULLTIME);
            InputEmploymentStatus.Items.Add(User.EMPLOYMENT_PARTTIME);
            InputStatus.Items.Add(User.STATUS_ACTIVE);
            InputStatus.Items.Add(User.STATUS_INACTIVE);
            InputDateOfBirth.MinDate = DateTime.Now.AddYears(-99);
            InputDateOfBirth.MaxDate = DateTime.Now.AddYears(-16);
            if (model.IsNewRecord)
            {
                FormTitle.Text = "Add Staff";
                BtnSave.Text = "Save";
                ClearForm();
            } else
            {
                FormTitle.Text = "Update Staff";
                BtnSave.Text = "Update";
                InputPassword.ReadOnly = true;
                InputRepeatPassword.ReadOnly = true;
                LoadForm();
            }
            //HasChanges = false;
        }
        protected void EnableForm()
        {
            InputAddress.Enabled = true;
            InputContactNumber.Enabled = true;
            InputDateOfBirth.Enabled = true;
            InputEmail.Enabled = true;
            InputEmploymentStatus.Enabled = true;
            InputName.Enabled = true;
            InputUsername.Enabled = true;
            InputPassword.Enabled = true;
            InputRepeatPassword.Enabled = true;
            InputStatus.Enabled = true;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            Cursor.Current = Cursors.WaitCursor;
        }
        protected void DisableForm()
        {
            InputAddress.Enabled = false;
            InputContactNumber.Enabled = false;
            InputDateOfBirth.Enabled = false;
            InputEmail.Enabled = false;
            InputEmploymentStatus.Enabled = false;
            InputName.Enabled = false;
            InputUsername.Enabled = false;
            InputPassword.Enabled = false;
            InputRepeatPassword.Enabled = false;
            InputStatus.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            ParentView.UseWaitCursor = false;
            Cursor.Current = Cursors.Default;
        }
        protected void LoadForm()
        {
            InputAddress.Text = Model.Address;
            InputContactNumber.Text = Model.ContactNumber;
            if (Model.DateOfBirth != null)
            {
                InputDateOfBirth.Value = (DateTime)Model.DateOfBirth;
            }            
            InputEmail.Text = Model.Email;
            InputEmploymentStatus.Text = Model.EmploymentType;
            InputName.Text = Model.Name;
            InputUsername.Text = Model.Username;
            InputStatus.Text = Model.Status;
        }
        protected void ClearForm()
        {
            InputAddress.ResetText();
            InputContactNumber.ResetText();
            InputDateOfBirth.ResetText();
            InputEmail.ResetText();
            InputEmploymentStatus.ResetText();
            InputName.ResetText();
            InputUsername.ResetText();
            InputStatus.ResetText();
            InputRepeatPassword.ResetText();
            InputPassword.ResetText();
        }
        protected void AddStaff()
        {
            DisableForm();
            RegistrationForm form = new RegistrationForm();
            form.Address = InputAddress.Text.Trim();
            form.ContactNumber = InputContactNumber.Text.Trim();
            form.DateOfBirth = InputDateOfBirth.Value;
            form.Email = InputEmail.Text.Trim();
            form.EmploymentType = InputEmploymentStatus.Text.Trim();
            form.Name = InputName.Text.Trim();
            form.Username = InputUsername.Text.Trim();
            form.Password = InputPassword.Text.Trim();
            form.PasswordRepeat = InputRepeatPassword.Text.Trim();
            form.Status = InputStatus.Text.Trim();
            if (!form.Register())
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
                Model = form.Model;
                MessageBox.Show(
                    "Staff account created successfully.",
                    "Staff Account Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
            }
            EnableForm();
        }
        protected void UpdateStaff()
        {
            DisableForm();
            StaffForm form = new StaffForm(Model);
            form.Address = InputAddress.Text.Trim();
            form.ContactNumber = InputContactNumber.Text.Trim();
            form.DateOfBirth = InputDateOfBirth.Value;
            form.Email = InputEmail.Text.Trim();
            form.EmploymentType = InputEmploymentStatus.Text.Trim();
            form.Name = InputName.Text.Trim();
            form.Username = InputUsername.Text.Trim();
            form.Password = InputPassword.Text.Trim();
            form.PasswordRepeat = InputRepeatPassword.Text.Trim();
            form.Status = InputStatus.Text.Trim();
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
                Model = form.Model;
                MessageBox.Show(
                    "Staff account updated successfully.",
                    "Staff Account Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
            }
            EnableForm();
        }
        protected void Submit()
        {
            DisableForm();
            ProfileForm form = new ProfileForm(Model);
            form.Address = InputAddress.Text;
            form.ContactNumber = InputContactNumber.Text;
            form.DateOfBirth = InputDateOfBirth.Value;
            form.Email = InputEmail.Text;
            form.EmploymentType = InputEmploymentStatus.Text;
            form.Name = InputName.Text;
            form.Username = InputUsername.Text;
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
                    "Profile saved successfully.",
                    "Profile Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                ParentView.CurrentModel = form.User;
                ParentView.UpdateDetails(form.User);
                Close();
            }
            EnableForm();
        }
        protected void CloseForm()
        {
            if (_changedAttributes.Count > 0)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to abandon your changes?",
                    "Are You Sure?",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            Close();
        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit();
            }
        }
        private void InputTextBox_Changed(object sender, EventArgs e)
        {
            var input = sender as TextBox;
            var originalValue = _originalModel
                .GetType()
                .GetProperty(input.Tag.ToString())
                .GetValue(_originalModel, null)
                .ToString();
            if (input.Text != originalValue)
            {
                _changedAttributes.Add(input.Tag.ToString());
            } else
            {
                _changedAttributes.Remove(input.Tag.ToString());
            }
        }
        private void InputDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            string attr = "DateOfBirth";
            if (InputDateOfBirth.Value != _originalModel.DateOfBirth)
            {
                _changedAttributes.Add(attr);
            } else
            {
                _changedAttributes.Remove(attr);
            }
        }
        private void InputEmploymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string attr = "EmploymentType";
            if (InputEmploymentStatus.Text != _originalModel.EmploymentType)
            {
                _changedAttributes.Add(attr);
            }
            else
            {
                _changedAttributes.Remove(attr);
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Model.IsNewRecord)
            {
                AddStaff();
            } else
            {
                UpdateStaff();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void InputPassword_DoubleClick(object sender, EventArgs e)
        {
            if (InputPassword.ReadOnly == true || InputRepeatPassword.ReadOnly == true)
            {
                InputPassword.ReadOnly = false;
                InputRepeatPassword.ReadOnly = false;
            }
        }
    }
}
