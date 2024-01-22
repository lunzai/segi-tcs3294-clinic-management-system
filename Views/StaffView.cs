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
    public partial class StaffView : Form
    {
        public User Model = new User();
        private readonly MainWindowView _parentView;
        private int _currentSelectedIndex = -1;
        public User CurrentModel { get; set; }
        public StaffView(MainWindowView parentView)
        {
            InitializeComponent();
            ObjectList.SelectedBackColor = Color.FromArgb(238, 242, 255); // 129, 140, 248
            ObjectList.UnfocusedSelectedBackColor = Color.FromArgb(238, 242, 255);
            ObjectList.SelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);
            ObjectList.UnfocusedSelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);
            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
            RefreshObjectList();
            _parentView = parentView;
        }
        public void RefreshObjectList()
        {
            List<User> list = Model.FindAllStaff();
            ObjectList.SetObjects(list);
            ObjectList.SelectedIndex = _currentSelectedIndex;
            if (_currentSelectedIndex != -1)
            {
                Model = (User)ObjectList.SelectedItem.RowObject;
                UpdateDetails(Model);
            } else
            {
                ResetDetails();
            }
            Refresh();
        }
        public void UpdateDetails(User model)
        {
            DVId.Text = model.Id.ToString();
            DVName.Text = model.Name;
            DVContactNumber.Text = model.ContactNumber;
            DVAddress.Text = model.Address;
            DVEmail.Text = model.Email;
            DVUsername.Text = model.Username;
            DVLastLogonAt.Text = model.LastLogonAt == null ? "-" : model.LastLogonAt.ToString();
            DVStatus.Text = model.Status;
        }
        public void ResetDetails()
        {
            DVId.Text = "-";
            DVName.Text = "-";
            DVContactNumber.Text = "-";
            DVAddress.Text = "-";
            DVEmail.Text = "-";
            DVUsername.Text = "-";
            DVLastLogonAt.Text = "-";
            DVStatus.Text = "-";
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
                User model = (User) ObjectList.SelectedItem.RowObject;
                CurrentModel = model;
                UpdateDetails(model);
                BtnUpdate.Visible = true;
                BtnDelete.Visible = true;
            } else
            {
                BtnUpdate.Visible = false;
                BtnDelete.Visible = false;
            }
        }
        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            StaffFormView form = new StaffFormView(this, new User());
            form.TopLevel = true;
            form.ShowDialog();
            RefreshObjectList();
        }
        private void UpdateStaff()
        {
            int index = ObjectList.SelectedItem.Index;
            StaffFormView form = new StaffFormView(this, CurrentModel);
            form.TopLevel = true;
            form.ShowDialog();
            RefreshObjectList();
            ObjectList.SelectedIndex = index;
        }
        private void ObjectList_DoubleClick(object sender, System.EventArgs e)
        {
            UpdateStaff();
        }
        private void BtnUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateStaff();
        }
        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            if (!Helper.ShowDeleteConfirmationDialog() || CurrentModel.IsNewRecord)
            {
                return;
            }
            if (!CurrentModel.Delete())
            {
                Helper.ShowGenericErrorDialog();
            }
            else
            {
                MessageBox.Show(
                    "Staff deleted successfully.",
                    "Staff Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                ResetDetails();
            }
            RefreshObjectList();
        }
    }
}
