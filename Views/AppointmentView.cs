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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class AppointmentView : Form
    {
        public Appointment Model = new Appointment();
        private readonly MainWindowView _parentView;
        private User _currentUser;
        private List<Medication> _medicationList;
        private readonly Medication _medication = new Medication();
        private readonly AppointmentMedication _appointmentMedication = new AppointmentMedication();
        private int _currentSelectedIndex = -1;
        public AppointmentView(MainWindowView parentView, User currentUser)
        {
            InitializeComponent();
            ObjectList.SelectedBackColor = Color.FromArgb(238, 242, 255);
            ObjectList.UnfocusedSelectedBackColor = Color.FromArgb(238, 242, 255);
            ObjectList.SelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);
            ObjectList.UnfocusedSelectedForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DGPrescriptions.AutoGenerateColumns = false;
            DGPrescriptions.Columns.Add("Medication", "Medication");
            DGPrescriptions.Columns.Add("SellingPrice", "Price");
            DGPrescriptions.Columns.Add("Qty", "Qty");
            DGPrescriptions.Columns.Add("Status", "Status");
            DGPrescriptions.Columns["Medication"].DataPropertyName = "Name";
            DGPrescriptions.Columns["Medication"].MinimumWidth = 260;
            DGPrescriptions.Columns["Medication"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGPrescriptions.Columns["SellingPrice"].DataPropertyName = "SellingPrice";
            DGPrescriptions.Columns["SellingPrice"].DefaultCellStyle.Format = "c2";
            DGPrescriptions.Columns["SellingPrice"].DefaultCellStyle.FormatProvider = Helper.GetCulture();
            DGPrescriptions.Columns["Qty"].DataPropertyName = "Qty";
            DGPrescriptions.Columns["Status"].DataPropertyName = "Status";
            
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Action";
            buttonColumn.Text = "Remove";
            buttonColumn.FlatStyle = FlatStyle.System;
            buttonColumn.UseColumnTextForButtonValue = true;
            DGPrescriptions.Columns.Add(buttonColumn);

            _parentView = parentView;
            _currentUser = currentUser;
            InputMedication.ValueMember = "Id";
            InputMedication.DisplayMember = "Name";

            RefreshObjectList();
            ResetDetails();
        }
        private void ShowForm(Appointment model)
        {
            AppointmentFormView form = new AppointmentFormView(model, _currentUser);
            form.TopLevel = true;
            form.ShowDialog();
        }
        private void RefreshInputMedication()
        {
            _medicationList = _medication.FindAll();
            InputMedication.DataSource = _medicationList;
        }
        private void RefreshObjectList()
        {
            List<Appointment> list = Model.FindAll();
            ObjectList.SetObjects(list);
            OLColumnName.GroupKeyGetter = delegate (object row)
            {
                Appointment model = (Appointment)row;
                return model.Status;
            };
            ObjectList.Sort(OLColumnName, SortOrder.Descending);
            ObjectList.SelectedIndex = _currentSelectedIndex;
            if (_currentSelectedIndex != -1)
            {
                Model = (Appointment)ObjectList.SelectedItem.RowObject;
                UpdateDetails(Model);
            }
            else
            {
                ResetDetails();
            }
            RefreshInputMedication();
            Refresh();
        }
        private void UpdateDataGrid(Appointment model)
        {
            var data = model.AppointmentMedications.Select(m =>
            {
                return new
                {
                    m.Medication.Name,
                    m.SellingPrice,
                    m.Qty,
                    m.Status,
                    m.Id,
                    Model = m
                };
            }).ToList();
            DGPrescriptions.DataSource = data;
        }
        private void UpdateDetails(Appointment model)
        {
            DVId.Text = model.Id.ToString();
            DVDoctor.Text = model.Doctor?.Name ?? "-";
            DVPatient.Text = model.Patient?.Name ?? "-";
            DVStaff.Text = model.Staff?.Name ?? "-";
            DVStatus.Text = model.Status;
            DVDate.Text = model.Start.ToString("dddd, d MMMM yyyy");
            DVTimeslot.Text = model.Timeslot;
            DVConfirmedAt.Text = model.ConfirmedAt != null ? model.ConfirmedAt.ToString() : "-";
            DVCompletedAt.Text = model.CompletedAt != null ? model.CompletedAt.ToString() : "-";
            InputConsultNote.Text = model.ConsultNote;
            DVCreatedAt.Text = model.CreatedAt.ToString();
            UpdateDataGrid(model);
        }
        private void ResetDetails()
        {
            DVId.Text = "-";
            DVDoctor.Text = "-";
            DVPatient.Text = "-";
            DVStaff.Text = "-";
            DVStatus.Text = "-";
            DVDate.Text = "-";
            DVTimeslot.Text = "-";
            DVConfirmedAt.Text = "-";
            DVCompletedAt.Text = "-";
            DVCreatedAt.Text = "-";
            BtnCompleted.Visible = false;
            BtnConfirm.Visible = false;
            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
            BtnAddPrescription.Enabled = false;
            BtnConsultNote.Enabled = false;
            DGPrescriptions.ReadOnly = true;
            InputConsultNote.ReadOnly = true;
            InputQty.Enabled = false;
            InputMedication.Enabled = false;
        }
        private void ObjectList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ResetDetails();
            _currentSelectedIndex = -1;
            if (ObjectList.SelectedItem != null)
            {
                _currentSelectedIndex = ObjectList.SelectedIndex;
                Appointment model = (Appointment)ObjectList.SelectedItem.RowObject;
                UpdateDetails(model);
                Model = model;
                BtnDelete.Visible = true;
                BtnUpdate.Visible = true;
                if (model.IsConfirmed)
                {
                    if (!model.IsCompleted)
                    {
                        BtnCompleted.Visible = true;
                        BtnAddPrescription.Enabled = true;
                        BtnConsultNote.Enabled = true;
                        DGPrescriptions.ReadOnly = false;
                        InputConsultNote.ReadOnly = false;
                        InputQty.Enabled = true;
                        InputMedication.Enabled = true;
                    } 
                }
                if (model.IsPending)
                {
                    BtnConfirm.Visible = true;
                    TabMain.SelectedIndex = 0;
                }
            }
        }
        private void ObjectList_DoubleClick(object sender, System.EventArgs e)
        {
            if (Model.IsCompleted)
            {
                MessageBox.Show(
                   "Consultation cannot be updated post-consult due to medical & legal compliance.",
                   "Unable To Update",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
                return;
            }
            int index = ObjectList.SelectedItem.Index;
            ShowForm(Model);
            RefreshObjectList();
            ObjectList.SelectedIndex = index;
        }
        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            ShowForm(new Appointment());
            RefreshObjectList();
        }
        private void BtnUpdate_Click(object sender, System.EventArgs e)
        {
            if (Model.IsCompleted)
            {
                MessageBox.Show(
                   "Consultation cannot be updated post-consult due to medical & legal compliance.",
                   "Unable To Update",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
                return;
            }
            int index = ObjectList.SelectedItem.Index;
            ShowForm(Model);
            RefreshObjectList();
            ObjectList.SelectedIndex = index;
        }
        private void BtnCompleted_Click(object sender, System.EventArgs e)
        {
            if (Model.IsNewRecord || !Model.IsConfirmed)
            {
                return;
            }
            if (Model.AppointmentMedications.Count > 0)
            {
                List<AppointmentMedication> list = Model.AppointmentMedications
                    .Where(m => m.Qty > m.Medication.StockQty)
                    .ToList();
                if (list.Count > 0)
                {
                    string message = string.Empty;
                    foreach (AppointmentMedication item in list)
                    {
                        message += $"{item.Medication.Name} only has {item.Medication.StockQty} in stock.{Environment.NewLine}{Environment.NewLine}";
                    }
                    message += "If you wish to update quantity, please remove existing prescription and add again.";
                    MessageBox.Show(
                        message,
                        "Insufficient Inventory",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                } 
            }            
            var icon = MessageBoxIcon.Question;
            string alert = $"Are you sure you want to mark this consult as completed?{Environment.NewLine}{Environment.NewLine}You will NOT be able to alter / delete this consult after completion.";
            if (Model.ConsultNote.Trim() == string.Empty || Model.Medications.Count == 0)
            {
                alert = $"Consult note or prescription is empty.{Environment.NewLine}{Environment.NewLine}" + alert;
                icon = MessageBoxIcon.Warning;
            } 
            var result = MessageBox.Show(
                alert,
                "Are You Sure?",
                MessageBoxButtons.OKCancel,
                icon
            );
            if (result != DialogResult.OK)
            {
                return;
            }
            if (!Model.Complete())
            {
                Helper.ShowGenericErrorDialog();
            }
            else
            {
                MessageBox.Show(
                    $"Appointment completed.{Environment.NewLine}{Environment.NewLine}Alteration / deletion will be forbidden due to medical & legal compliance.",
                    "Appointment Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            RefreshObjectList();
        }
        private void BtnConfirm_Click(object sender, System.EventArgs e)
        {
            if (Model.IsNewRecord || !Model.IsPending)
            {
                return;
            }
            var result = MessageBox.Show(
                "Are you sure you want to confirm this appointment?",
                "Are You Sure",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (result != DialogResult.OK)
            {
                return;
            }
            if (!Model.Confirm())
            {
                Helper.ShowGenericErrorDialog();
            } else
            {
                MessageBox.Show(
                    $"Appointment confirmed.{Environment.NewLine}{Environment.NewLine}Please notify patient of confirmation.",
                    "Appointment Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            RefreshObjectList();
        }
        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            if (Model.IsCompleted)
            {
                MessageBox.Show(
                   "Consultation cannot be deleted post-consult due to medical & legal compliance!",
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
                    "Appointment deleted successfully.",
                    "Appointment Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                ResetDetails();
            }
            RefreshObjectList();
        }
        private void BtnAddPrescription_Click(object sender, EventArgs e)
        {
            if (!Model.IsConfirmed || Model.IsCompleted)
            {
                return;
            }
            if (InputQty.Value <= 0 || InputMedication.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Validation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }            
            int qty = (int)InputQty.Value;
            Medication medication = (Medication)InputMedication.SelectedItem;
            if (Model.AppointmentMedications.Any(m => m.MedicationId == medication.Id))
            {
                MessageBox.Show(
                    $"{medication.Name} has already been prescribed.{Environment.NewLine}{Environment.NewLine}If you wish to update quantity, please remove existing prescription and add again.",
                    "Duplicated prescription",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            if (qty > medication.StockQty)
            {
                var result = MessageBox.Show(
                    $"{medication.Name} only has {medication.StockQty} in stock.{Environment.NewLine}{Environment.NewLine}Click OK to prescribe {medication.StockQty} {medication.Name}.{Environment.NewLine}{Environment.NewLine}Click CANCEL to return.",
                    "Insufficant Inventory",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                );
                if (result == DialogResult.OK)
                {
                    qty = medication.StockQty;
                } else
                {
                    return;
                }
            }
            if (!_appointmentMedication.Save(Model, medication, qty))
            {
                Helper.ShowGenericErrorDialog();
            } else
            {
                MessageBox.Show(
                    "Prescription added successfully.",
                    "Prescription added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                RefreshObjectList();
            }
        }
        private void BtnConsultNote_Click(object sender, EventArgs e)
        {
            if (!Model.IsConfirmed || Model.IsCompleted)
            {
                return;
            }
            if (InputConsultNote.Text.Trim() == string.Empty)
            {
                MessageBox.Show(
                    "Please fill in the consult note.",
                    "Validation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            if (!Model.UpdateConsultNote(InputConsultNote.Text))
            {
                Helper.ShowGenericErrorDialog();
            } else
            {
                MessageBox.Show(
                    "Consult note updated successfully.",
                    "Consult Note Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabMain.SelectedIndex > 0 && !Model.IsConfirmed) {
                MessageBox.Show(
                    "Consult note and prescription is only applicable for confirmed appointment.",
                    "Tab Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                TabMain.SelectedIndex = 0;
                return;
            }
        }
        private void DGPrescriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGPrescriptions.Columns["Action"].Index)
            {
                var item = (Object)DGPrescriptions.Rows[e.RowIndex].DataBoundItem;
                Type type = item.GetType();
                AppointmentMedication model = (AppointmentMedication)type.GetProperty("Model").GetValue(item, null);
                if (model.Status == AppointmentMedication.STATUS_COMPLETED)
                {
                    MessageBox.Show(
                       "Prescription cannot be deleted post-consult due to medical & legal compliance!",
                       "Unable To Delete",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                    );
                    return;
                }
                var result = MessageBox.Show(
                    "Are you sure you want to remove this prescription?",
                    "Are you sure",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.OK)
                {
                    model.Delete();
                    RefreshObjectList();
                }
            }            
        }
    }
}
