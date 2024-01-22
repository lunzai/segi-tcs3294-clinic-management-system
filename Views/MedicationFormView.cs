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
    public partial class MedicationFormView : Form
    {
        public bool HasChanges = false;
        public Medication Model { get; set; } = new Medication();
        public MedicationFormView(Medication model)
        {
            InitializeComponent();
            Model = model;
            InputCategory.DataSource = Model.Categories;
            if (model.IsNewRecord)
            {
                FormTitle.Text = "Add Medication";
                BtnSave.Text = "Save";
            } else
            {
                FormTitle.Text = "Update Medication";
                BtnSave.Text = "Update";
                LoadViewForm();
            }
            HasChanges = false;
        }
        protected void Submit()
        {
            DisableForm();
            MedicationForm form = new MedicationForm(Model);
            form.Name = InputName.Text.Trim();
            form.Category = InputCategory.SelectedValue.ToString();
            form.UnitPrice = (double)InputUnitPrice.Value;
            form.SellingPrice = (double)InputSellingPrice.Value;
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
                    "Medication saved successfully.",
                    "Medication Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
            }
            EnableForm();
        }
        protected void LoadViewForm()
        {
            InputName.Text = Model.Name;
            InputCategory.SelectedIndex = InputCategory.FindStringExact(Model.Category);
            InputUnitPrice.Value = (decimal)Model.UnitPrice;
            InputSellingPrice.Value = (decimal)Model.SellingPrice;
        }
        protected void DisableForm()
        {
            InputName.Enabled = false;
            InputCategory.Enabled = false;
            InputUnitPrice.Enabled = false;
            InputSellingPrice.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
        }
        protected void EnableForm()
        {
            InputName.Enabled = true;
            InputCategory.Enabled = true;
            InputUnitPrice.Enabled = true;
            InputSellingPrice.Enabled = true;
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
        private void InputCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputCategory.SelectedItem != null)
            {
                HasChanges = true;
            }
        }
        private void Input_ValueChanged(object sender, EventArgs e)
        {
            HasChanges = true;
        }
    }
}
