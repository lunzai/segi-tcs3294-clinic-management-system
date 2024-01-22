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
using System.Linq;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class PatientView : Form
    {
        public Patient Model = new Patient();
        private readonly MainWindowView _parentView;
        private int _currentSelectedIndex = -1;
        public PatientView(MainWindowView parentView)
        {
            InitializeComponent();
            ObjectList.SelectedBackColor = Color.FromArgb(238, 242, 255); // 129, 140, 248
            ObjectList.UnfocusedSelectedBackColor = Color.FromArgb(238, 242, 255);
            ObjectList.SelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);
            ObjectList.UnfocusedSelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);

            DataGrid.AutoGenerateColumns = false;
            DataGrid.Columns.Add("Date", "Date");
            DataGrid.Columns.Add("Timeslot", "Timeslot");
            DataGrid.Columns.Add("Doctor", "Doctor");
            DataGrid.Columns.Add("Status", "Status");
            DataGrid.Columns["Date"].DataPropertyName = "Date";
            DataGrid.Columns["Timeslot"].DataPropertyName = "Timeslot";
            DataGrid.Columns["Doctor"].DataPropertyName = "DoctorName";
            DataGrid.Columns["Status"].DataPropertyName = "Status";
            DGPrescription.AutoGenerateColumns = false;
            DGPrescription.Columns.Add("Date", "Date");
            DGPrescription.Columns.Add("Doctor", "Doctor");
            DGPrescription.Columns.Add("Medication", "Medication");
            DGPrescription.Columns.Add("Qty", "Qty");
            DGPrescription.Columns.Add("SellingPrice", "Selling Price");
            DGPrescription.Columns.Add("TotalPrice", "Total Price");
            DGPrescription.Columns["SellingPrice"].DefaultCellStyle.Format = "c2";
            DGPrescription.Columns["SellingPrice"].DefaultCellStyle.FormatProvider = Helper.GetCulture();
            DGPrescription.Columns["TotalPrice"].DefaultCellStyle.Format = "c2";
            DGPrescription.Columns["TotalPrice"].DefaultCellStyle.FormatProvider = Helper.GetCulture();
            DGPrescription.Columns["Date"].DataPropertyName = "AppointmentDate";
            DGPrescription.Columns["Doctor"].DataPropertyName = "DoctorName";
            DGPrescription.Columns["Medication"].DataPropertyName = "MedicationName";
            DGPrescription.Columns["Qty"].DataPropertyName = "Qty";
            DGPrescription.Columns["SellingPrice"].DataPropertyName = "SellingPrice";
            DGPrescription.Columns["TotalPrice"].DataPropertyName = "TotalPrice";

            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
            _parentView = parentView;

            ResetDetails();
            RefreshObjectList();
        }
        private void RefreshDataGrid(Patient model)
        {
            DataGrid.DataSource = model.Appointments;
        }
        private void RefreshPrescription(Patient model)
        {
            if (model.IsNewRecord)
            {
                return;
            }
            AppointmentMedication prescriptionModel = new AppointmentMedication();
            List<AppointmentMedication> list = prescriptionModel.FindAllByPatientId((int)model.Id);
            DGPrescription.DataSource = list;
        }
        private void ShowForm(Patient model)
        {
            PatientFormView form = new PatientFormView(model);
            form.TopLevel = true;
            form.ShowDialog();
        }
        public void RefreshObjectList()
        {
            List<Patient> list = Model.FindAll();
            ObjectList.SetObjects(list);
            ObjectList.SelectedIndex = _currentSelectedIndex;
            if (_currentSelectedIndex != -1)
            {
                Model = (Patient)ObjectList.SelectedItem.RowObject;
                UpdateDetails(Model);
            }
            else
            {
                ResetDetails();
            }
            Refresh();
        }
        private void UpdateDetails(Patient model)
        {
            DVId.Text = model.Id.ToString();
            DVName.Text = model.Name;
            DVContactNumber.Text = model.ContactNumber;
            DVAddress.Text = model.Address;
            DVEmail.Text = model.Email;
            RefreshDataGrid(model);
            RefreshPrescription(model);
        }
        private void ResetDetails()
        {
            DVId.Text = "-";
            DVName.Text = "-";
            DVContactNumber.Text = "-";
            DVAddress.Text = "-";
            DVEmail.Text = "-";
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
                Patient model = (Patient)ObjectList.SelectedItem.RowObject;
                Model = model;
                UpdateDetails(model);
                BtnUpdate.Visible = true;
                BtnDelete.Visible= true;
            }
            else
            {
                BtnDelete.Visible = false;
                BtnUpdate.Visible = false;
            }
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
            Patient model = new Patient();
            ShowForm(model);
            RefreshObjectList();
        }
        private void BtnUpdate_Click(object sender, System.EventArgs e)
        {
            int index = ObjectList.SelectedItem.Index;
            ShowForm(Model);
            RefreshObjectList();
            ObjectList.SelectedIndex = index;
        }
        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
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
                    "Patient deleted successfully.",
                    "Patient Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                ResetDetails();
            }
            RefreshObjectList();
        }
    }
}
