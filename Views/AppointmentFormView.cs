/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using cms.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class AppointmentFormView : Form
    {
        public bool HasChanges = false;
        public Appointment Model { get; set; } = new Appointment();
        private readonly Doctor _doctor = new Doctor();
        private readonly Patient _patient = new Patient();
        private User _currentUser;
        public AppointmentFormView(Appointment model, User currentUser)
        {
            InitializeComponent();
            Model = model;
            InputDate.MinDate = DateTime.Today.AddMonths(-3);
            InputDate.MaxDate = DateTime.Today.AddMonths(3);
            InputTimeslot.DataSource = Model.Timeslots;
            InputDoctor.ValueMember = "Id";
            InputDoctor.DisplayMember = "Name";
            InputDoctor.DataSource = _doctor.FindAll();
            InputPatient.ValueMember = "Id";
            InputPatient.DisplayMember = "Name";
            InputPatient.DataSource = _patient.FindAll();
            if (model.IsNewRecord)
            {
                FormTitle.Text = "Add Appointment";
                BtnSave.Text = "Save";
            }
            else
            {
                FormTitle.Text = "Update Appointment";
                BtnSave.Text = "Update";
                LoadViewForm();
            }
            HasChanges = false;
            _currentUser = currentUser;
        }
        protected void Submit()
        {
            DisableForm();
            AppointmentForm form = new AppointmentForm(Model, _currentUser);
            form.Date = InputDate.Value;
            form.Timeslot = (Timeslot)InputTimeslot.SelectedItem;
            form.DoctorId = (int)InputDoctor.SelectedValue;
            form.PatientId = (int)InputPatient.SelectedValue;

            // check availability
            if (!form.Validate())
            {
                Helper.ShowValidationErrorDialog(form.ValidationResults);
                EnableForm();
                return;
            }

            form.LoadModel();
            Doctor doctor = InputDoctor.SelectedItem as Doctor;
            try
            {
                // will throw if no result from DB, means slot is available,
                // code will then jump to catch and cont
                Model.FindConfirmedAvailability(form.Model);                
                MessageBox.Show(
                    $"The selected date and timeslot for {doctor.Name} is not available.",
                    "Timeslot Not Available",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                EnableForm();
                return;
            }
            catch (Exception) { }

            try
            {
                Model.FindPendingAvailability(form.Model);
                var result = MessageBox.Show(
                    $@"There is a pending appointment for {doctor.Name} for the selected date and timeslot.{Environment.NewLine}{Environment.NewLine}Please confirm if you like to proceed or click Cancel to return to form.",
                    "Timeslot Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
                if (result != DialogResult.OK)
                {
                    EnableForm();
                    return;
                }
            }
            catch (Exception) { }

            if (!form.Save())
            {
                Helper.ShowGenericErrorDialog();
            } else
            {
                Model = form.Model;
                MessageBox.Show(
                    "Appointment saved successfully.",
                    "Appointment Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
            }
            EnableForm();
        }
        protected void LoadViewForm()
        {
            InputDate.Value = Model.Start;
            var findTimeslot = InputTimeslot.Items
                .Cast<Timeslot>()
                .FirstOrDefault(item => 
                    item.StartTimeSecond == Model.StartSecond && item.EndTimeSecond == Model.EndSecond
                );
            if (findTimeslot != null)
            {
                InputTimeslot.SelectedItem = findTimeslot;
            }
            var findDoctor = InputDoctor.Items.Cast<Doctor>().FirstOrDefault(item => item.Id == Model.DoctorId);
            if (findDoctor != null)
            {
                InputDoctor.SelectedItem = findDoctor;
            }
            var findPatient = InputPatient.Items.Cast<Patient>().FirstOrDefault(item => item.Id == Model.PatientId);
            if (findPatient != null)
            {
                InputPatient.SelectedItem = findPatient;
            }
        }
        protected void DisableForm()
        {
            InputDate.Enabled = false;
            InputDoctor.Enabled = false;
            InputPatient.Enabled = false;
            InputTimeslot.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
        }
        protected void EnableForm()
        {
            InputDate.Enabled = true;
            InputDoctor.Enabled = true;
            InputPatient.Enabled = true;
            InputTimeslot.Enabled = true;
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
            if (InputTimeslot.SelectedItem != null)
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
