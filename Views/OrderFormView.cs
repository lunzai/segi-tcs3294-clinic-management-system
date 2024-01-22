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
using System.Linq;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class OrderFormView : Form
    {
        public bool HasChanges = false;
        public Order Model { get; set; } = new Order();
        public List<Medication> Medications { get; set; }
        public OrderFormView(Order model)
        {
            InitializeComponent();
            Model = model;
            Medications = (new Medication()).FindAll();
            InputMedication.DisplayMember = "Name";
            InputMedication.ValueMember = "Id";
            InputMedication.DataSource = Medications;
            if (model.IsNewRecord)
            {
                FormTitle.Text = "Add Order";
                BtnSave.Text = "Save";
            }
            else
            {
                FormTitle.Text = "Update Order";
                BtnSave.Text = "Update";
                LoadViewForm();
            }
            HasChanges = false;
        }
        protected void Submit()
        {
            DisableForm();
            OrderForm form = new OrderForm(Model);
            form.SupplierName = InputSupplierName.Text.Trim();
            form.MedicationId = (int) InputMedication.SelectedValue;
            form.Qty = (int) InputQty.Value;
            form.UnitPrice = (double)InputUnitPrice.Value;
            form.TotalPrice = form.UnitPrice * form.Qty;
            
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
                    "Order created successfully.",
                    "Order Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
            }
            EnableForm();
        }
        protected void LoadViewForm()
        {
            InputQty.Value = Model.Qty;
            InputUnitPrice.Value = (decimal)Model.UnitPrice;
            InputTotalPrice.Value = (decimal)Model.TotalPrice;
            if (Model.Medication != null)
            {
                InputSupplierName.SelectedIndex = InputSupplierName.FindStringExact(Model.SupplierName);
                var foundItem = InputMedication.Items.Cast<Medication>().FirstOrDefault(item => item.Id == Model.MedicationId);
                if (foundItem != null)
                {
                    InputMedication.SelectedItem = foundItem;
                }
            }
        }
        protected void DisableForm()
        {
            InputSupplierName.Enabled = false;
            InputMedication.Enabled = false;
            InputQty.Enabled = false;
            InputUnitPrice.Enabled = false;
            InputTotalPrice.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
        }
        protected void EnableForm()
        {
            InputSupplierName.Enabled = true;
            InputMedication.Enabled = true;
            InputQty.Enabled = true;
            InputUnitPrice.Enabled = true;
            InputTotalPrice.Enabled = true;
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
        private void Input_ValueChanged(object sender, EventArgs e)
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
        private void InputQtyUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            HasChanges = true;
            if (InputUnitPrice.Value >= 0 && InputQty.Value >= 0)
            {
                InputTotalPrice.Value = InputUnitPrice.Value * InputQty.Value;
            }
        }
        private void InputMedication_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (InputMedication.SelectedItem != null)
            {
                HasChanges = true;
                InputUnitPrice.Value = (decimal)((Medication)InputMedication.SelectedItem).UnitPrice;
            }            
        }
        private void InputSupplierName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (InputSupplierName.SelectedItem != null)
            {
                HasChanges = true;
            }            
        }
    }
}
