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
    public partial class DoctorView : Form
    {
        public Doctor Model = new Doctor();
        private readonly MainWindowView _parentView;
        private int _currentSelectedIndex = -1;
        public DoctorView(MainWindowView parentView)
        {
            InitializeComponent();
            ObjectList.SelectedBackColor = Color.FromArgb(238, 242, 255); // 129, 140, 248
            ObjectList.UnfocusedSelectedBackColor = Color.FromArgb(238, 242, 255);
            ObjectList.SelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);
            ObjectList.UnfocusedSelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);

            DataGrid.AutoGenerateColumns = false;
            DataGrid.Columns.Add("Date", "Date");
            DataGrid.Columns.Add("Timeslot", "Timeslot");
            DataGrid.Columns.Add("Patient", "Patient");
            DataGrid.Columns.Add("Status", "Status");
            DataGrid.Columns["Date"].DataPropertyName = "Date";
            DataGrid.Columns["Timeslot"].DataPropertyName = "Timeslot";
            DataGrid.Columns["Patient"].DataPropertyName = "PatientName";
            DataGrid.Columns["Status"].DataPropertyName = "Status";

            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
            _parentView = parentView;

            RefreshObjectList();
            ResetDetails();
        }
        private void RefreshDataGrid(Doctor model)
        {
            DataGrid.DataSource = model.Appointments;
        }
        private void ShowForm(Doctor model)
        {
            DoctorFormView form = new DoctorFormView(model);
            form.TopLevel = true;
            form.ShowDialog();
        }
        public void RefreshObjectList()
        {
            List<Doctor> list = Model.FindAll();
            ObjectList.SetObjects(list);
            ObjectList.SelectedIndex = _currentSelectedIndex;
            if (_currentSelectedIndex != -1)
            {
                Model = (Doctor)ObjectList.SelectedItem.RowObject;
                UpdateDetails(Model);
            } else
            {
                ResetDetails();
            }
            Refresh();
        }
        private void UpdateDetails(Doctor model)
        {
            DVId.Text = model.Id.ToString();
            DVName.Text = model.Name;
            DVContactNumber.Text = model.ContactNumber;
            DVAddress.Text = model.Address;
            DVEmail.Text = model.Email;
            RefreshDataGrid(model);
        }
        private void ResetDetails()
        {
            DVId.Text = "-";
            DVName.Text = "-";
            DVContactNumber.Text = "-";
            DVAddress.Text = "-";
            DVEmail.Text = "-";
            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
        }
        private void ObjectList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ResetDetails();
            _currentSelectedIndex = -1;
            if (ObjectList.SelectedItem != null)
            {
                _currentSelectedIndex = ObjectList.SelectedIndex;
                Doctor model = (Doctor)ObjectList.SelectedItem.RowObject;
                Model = model;
                UpdateDetails(model);
                BtnUpdate.Visible = true;
                BtnDelete.Visible = true;
            } else
            {
                BtnUpdate.Visible = false;
                BtnDelete.Visible = false;
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
            ShowForm(new Doctor());
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
            } else
            {
                MessageBox.Show(
                    "Doctor successfully deleted.",
                    "Doctor Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                ResetDetails();
            }
            RefreshObjectList();
        }
    }
}
