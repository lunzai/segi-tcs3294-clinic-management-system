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
    public partial class PatientFormView : Form
    {
        public bool HasChanges = false;
        public Patient Model { get; set; } = new Patient();
        public PatientFormView(Patient model)
        {
            InitializeComponent();
            Model = model;
            if (model.IsNewRecord)
            {
                FormTitle.Text = "Add Patient";
                BtnSave.Text = "Save";
            } else
            {
                FormTitle.Text = "Update Patient";
                BtnSave.Text = "Update";
                LoadViewForm();
            }
            HasChanges = false;
        }
        protected void Submit()
        {
            DisableForm();
            PatientForm form = new PatientForm(Model);
            form.Name = InputName.Text.Trim();
            form.ContactNumber = InputContactNumber.Text.Trim();
            form.Email = InputEmail.Text.Trim();
            form.Address = InputAddress.Text.Trim();
            if (!form.Save())
            {
                if (form.HasValidationError)
                {
                    Helper.ShowValidationErrorDialog(form.ValidationResults);
                } else
                {
                    Helper.ShowGenericErrorDialog();
                }
            } else
            {
                Model = form.Model;
                MessageBox.Show(
                    "Patient saved successfully.",
                    "Patient Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
            }
            EnableForm();
        }
        protected void LoadViewForm()
        {
            InputAddress.Text = Model.Address;
            InputContactNumber.Text = Model.ContactNumber;
            InputEmail.Text = Model.Email;
            InputName.Text = Model.Name;
        }
        protected void DisableForm()
        {
            InputAddress.Enabled = false;
            InputContactNumber.Enabled = false;
            InputEmail.Enabled = false;
            InputName.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
        }
        protected void EnableForm()
        {
            InputAddress.Enabled = true;
            InputContactNumber.Enabled = true;
            InputEmail.Enabled = true;
            InputName.Enabled = true;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            Cursor.Current = Cursors.Default;
        }
        protected void CloseForm()
        {
            if (HasChanges)
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
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Submit();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void InputTextBox_Changed(object sender, EventArgs e)
        {
            HasChanges = true;
        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit();
            }
        }
    }
}
