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
using System.Drawing;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class OrderView : Form
    {
        public Order Model = new Order();
        private readonly MainWindowView _parentView;
        private int _currentSelectedIndex = -1;
        public OrderView(MainWindowView parentView)
        {
            InitializeComponent();
            ObjectList.SelectedBackColor = Color.FromArgb(238, 242, 255); // 129, 140, 248
            ObjectList.UnfocusedSelectedBackColor = Color.FromArgb(238, 242, 255);
            ObjectList.SelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);
            ObjectList.UnfocusedSelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);
            RefreshObjectList();
            _parentView = parentView;
            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
            BtnReceived.Visible = false;

        }
        private void ShowForm(Order model)
        {
            OrderFormView form = new OrderFormView(model);
            form.TopLevel = true;
            form.ShowDialog();
        }
        public void RefreshObjectList()
        {
            List<Order> list = Model.FindAll();
            ObjectList.SetObjects(list);
            OLColumnName.GroupKeyGetter = delegate (object row)
            {
                Order model = (Order)row;
                return model.Status;
            };
            ObjectList.Sort(OLColumnName, SortOrder.Descending);
            ObjectList.SelectedIndex = _currentSelectedIndex;
            if (_currentSelectedIndex != -1)
            {
                Model = (Order)ObjectList.SelectedItem.RowObject;
                UpdateDetails(Model);
            } else
            {
                ResetDetails();
            }
            Refresh();
        }
        private void UpdateDetails(Order model)
        {
            DVId.Text = model.Id.ToString();
            DVSupplierName.Text = model.SupplierName;
            DVMedicationName.Text = model.Medication?.Name;
            DVQty.Text = model.Qty.ToString();
            DVUnitPrice.Text = Helper.AsCurrency(model.UnitPrice);
            DVTotalPrice.Text = Helper.AsCurrency(model.TotalPrice);
            DVStatus.Text = model.Status;
            DVCreatedAt.Text = model.CreatedAt.ToString();
            DVReceivedAt.Text = model.ReceivedAt.ToString();
        }
        private void ResetDetails()
        {
            DVId.Text = "-";
            DVSupplierName.Text = "-";
            DVMedicationName.Text = "-";
            DVQty.Text = "-";
            DVUnitPrice.Text = "-";
            DVTotalPrice.Text = "-";
            DVStatus.Text = "-";
            DVCreatedAt.Text = "-";
            DVReceivedAt.Text = "-";
            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
            BtnReceived.Visible = false;
        }
        private void ObjectList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _currentSelectedIndex = -1;
            if (ObjectList.SelectedItem != null)
            {
                _currentSelectedIndex = ObjectList.SelectedIndex;
                Order model = (Order)ObjectList.SelectedItem.RowObject;
                Model = model;
                UpdateDetails(model);
                BtnDelete.Visible = true;
                BtnReceived.Visible = !model.IsReceived;
                BtnUpdate.Visible = model.IsPending;
            } else
            {
                BtnDelete.Visible = false;
                BtnUpdate.Visible = false;
                BtnReceived.Visible = false;
            }
        }
        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            if (!Helper.ShowDeleteConfirmationDialog() || Model.IsNewRecord)
            {
                return;
            }
            if (Model.Qty > Model.Medication.StockQty)
            {
                MessageBox.Show(
                    $"Order's quantity ({Model.Qty}) exceeded {Model.Medication.Name}'s available stock ({Model.Medication.StockQty}).",
                    "Unable To Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            if (!Model.Delete())
            {
                Helper.ShowGenericErrorDialog();
            }
            else
            {
                MessageBox.Show(
                    "Order deleted successfully.",
                    "Order Deleted",
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

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            ShowForm(new Order());
            RefreshObjectList();
        }
        private void ObjectList_DoubleClick(object sender, System.EventArgs e)
        {
            if (Model.IsReceived)
            {
                MessageBox.Show(
                    "The Order has been received, you are not allowed to modify this order.",
                    "Unable To Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int index = ObjectList.SelectedItem.Index;
            ShowForm(Model);
            RefreshObjectList();
            ObjectList.SelectedIndex = index;
        }
        // TODO UPDATE DISPLAY AFTER RECEIVED
        private void BtnReceived_Click(object sender, System.EventArgs e)
        {
            int index = ObjectList.SelectedItem.Index;
            if (!Model.Receive())
            {
                Helper.ShowGenericErrorDialog();
                return;
            }
            MessageBox.Show(
                $"Order marked as received{Environment.NewLine}{Environment.NewLine}Medication's quantity will be updated automatically.",
                "Order Received",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            RefreshObjectList();
            ObjectList.SelectedIndex = index;
        }

        private void ObjectList_BeforeCreatingGroups(object sender, BrightIdeasSoftware.CreateGroupsEventArgs e)
        {
            e.Parameters.GroupByOrder = SortOrder.Ascending;
        }
    }
}
