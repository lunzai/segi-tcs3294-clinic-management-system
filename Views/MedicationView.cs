/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using cms.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class MedicationView : Form
    {
        public Medication Model = new Medication();
        public readonly Order OrderModel = new Order();
        private readonly MainWindowView _parentView;
        private int _currentSelectedIndex = -1;
        public MedicationView(MainWindowView parentView)
        {
            InitializeComponent();
            ObjectList.SelectedBackColor = Color.FromArgb(238, 242, 255); // 129, 140, 248
            ObjectList.UnfocusedSelectedBackColor = Color.FromArgb(238, 242, 255);
            ObjectList.SelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);
            ObjectList.UnfocusedSelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);

            DataGrid.AutoGenerateColumns = false;
            DataGrid.Columns.Add("SupplierName", "Supplier Name");
            DataGrid.Columns.Add("Qty", "Qty");
            DataGrid.Columns.Add("UnitPrice", "Unit Price");
            DataGrid.Columns.Add("TotalPrice", "Total Price");
            DataGrid.Columns.Add("Status", "Status");
            DataGrid.Columns.Add("ReceivedAt", "Received At");
            DataGrid.Columns["UnitPrice"].DefaultCellStyle.Format = "c2";
            DataGrid.Columns["UnitPrice"].DefaultCellStyle.FormatProvider = Helper.GetCulture();
            DataGrid.Columns["TotalPrice"].DefaultCellStyle.Format = "c2";
            DataGrid.Columns["TotalPrice"].DefaultCellStyle.FormatProvider = Helper.GetCulture();
            DataGrid.Columns["SupplierName"].DataPropertyName = "SupplierName";
            DataGrid.Columns["Qty"].DataPropertyName = "Qty";
            DataGrid.Columns["UnitPrice"].DataPropertyName = "UnitPrice";
            DataGrid.Columns["TotalPrice"].DataPropertyName = "TotalPrice";
            DataGrid.Columns["Status"].DataPropertyName = "Status";
            DataGrid.Columns["ReceivedAt"].DataPropertyName = "ReceivedAt";
            DGPrescription.AutoGenerateColumns = false;
            DGPrescription.Columns.Add("Date", "Date");
            DGPrescription.Columns.Add("Doctor", "Doctor");
            DGPrescription.Columns.Add("Patient", "Patient");
            DGPrescription.Columns.Add("Qty", "Qty");
            DGPrescription.Columns.Add("SellingPrice", "Selling Price");
            DGPrescription.Columns.Add("TotalPrice", "Total Price");
            DGPrescription.Columns["SellingPrice"].DefaultCellStyle.Format = "c2";
            DGPrescription.Columns["SellingPrice"].DefaultCellStyle.FormatProvider = Helper.GetCulture();
            DGPrescription.Columns["TotalPrice"].DefaultCellStyle.Format = "c2";
            DGPrescription.Columns["TotalPrice"].DefaultCellStyle.FormatProvider = Helper.GetCulture();
            DGPrescription.Columns["Date"].DataPropertyName = "AppointmentDate";
            DGPrescription.Columns["Doctor"].DataPropertyName = "DoctorName";
            DGPrescription.Columns["Patient"].DataPropertyName = "PatientName";
            DGPrescription.Columns["Qty"].DataPropertyName = "Qty";
            DGPrescription.Columns["SellingPrice"].DataPropertyName = "SellingPrice";
            DGPrescription.Columns["TotalPrice"].DataPropertyName = "TotalPrice";

            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
            _parentView = parentView;

            RefreshObjectList();
            ResetDetails();
        }
        private void RefreshDataGrid(Medication model)
        {
            DataGrid.DataSource = model.Orders;
        }
        private void RefreshPrescription(Medication model)
        {
            if (model.IsNewRecord)
            {
                return;
            }
            AppointmentMedication prescriptionModel = new AppointmentMedication();
            List<AppointmentMedication> list = prescriptionModel.FindAllByMedicationId((int)model.Id);
            DGPrescription.DataSource = list;
        }
        private void ShowForm(Medication model)
        {
            MedicationFormView form = new MedicationFormView(model);
            form.TopLevel = true;
            form.ShowDialog();
        }
        private void RefreshObjectList()
        {
            List<Medication> list = Model.FindAll();
            ObjectList.SetObjects(list);
            ObjectList.SelectedIndex = _currentSelectedIndex;
            if (_currentSelectedIndex != -1)
            {
                Model = (Medication)ObjectList.SelectedItem.RowObject;
                UpdateDetails(Model);
            }
            else
            {
                ResetDetails();
            }
            Refresh();
        }       
        private void UpdateDetails(Medication model)
        {
            DVId.Text = model.Id.ToString();
            DVName.Text = model.Name;
            DVCategory.Text = model.Category;
            DVTotalQty.Text = model.TotalQty.ToString();
            DVSoldQty.Text = model.SoldQty.ToString();
            DVStockQty.Text = model.StockQty.ToString();
            DVUnitPrice.Text = Helper.AsCurrency(model.UnitPrice);
            DVSellingPrice.Text = Helper.AsCurrency(model.SellingPrice);
            RefreshDataGrid(model);
            RefreshPrescription(model);
        }
        private void ResetDetails()
        {
            DVId.Text = "-";
            DVName.Text = "-";
            DVCategory.Text = "-";
            DVTotalQty.Text = "-";
            DVSoldQty.Text = "-";
            DVStockQty.Text = "-";
            DVUnitPrice.Text = "-";
            DVSellingPrice.Text = "-";
            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
        }
        private void ObjectList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ResetDetails();
            _currentSelectedIndex = -1;
            if (ObjectList.SelectedItem != null)
            {
                _currentSelectedIndex = ObjectList.SelectedIndex;
                Medication model = (Medication)ObjectList.SelectedItem.RowObject;
                Model = model;
                UpdateDetails(model);
                BtnDelete.Visible = true;
                BtnUpdate.Visible = true;
            } else
            {
                BtnDelete.Visible = false;
                BtnUpdate.Visible = false;
            }
        }
        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            if (Model.Orders.Count > 0)
            {
                MessageBox.Show(
                    "Unable to delete as there are order(s) associated to this medication.",
                    "Unable To Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            if (!Helper.ShowDeleteConfirmationDialog() || Model.IsNewRecord)
            {
                return;
            }            
            if (!Model.Delete())
            {
                Helper.ShowGenericErrorDialog();
            }
            else
            {
                MessageBox.Show(
                    "Medication deleted successfully.",
                    "Medication Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                ResetDetails();
            }
            RefreshObjectList();
        }
        private void BtnUpdate_Click(object sender, System.EventArgs e)
        {
            int index = ObjectList.SelectedItem.Index;
            ShowForm(Model);
            RefreshObjectList();
            ObjectList.SelectedIndex = index;
        }
        private void ObjectList_DoubleClick(object sender, System.EventArgs e)
        {
            int index = ObjectList.SelectedItem.Index;
            ShowForm(Model);
            RefreshObjectList();
            ObjectList.SelectedIndex = index;
        }
        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            ShowForm(new Medication());
            RefreshObjectList();
        }
    }
}
