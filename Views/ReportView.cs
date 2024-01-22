/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Common;
using cms.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class ReportView : Form
    {
        const string TYPE_APPOINTMENT = "Appointment";
        const string TYPE_DOCTOR = "Doctor";
        const string TYPE_MEDICATION = "Medication";
        const string TYPE_ORDER = "Order";
        const string TYPE_PATIENT = "Patient";
        const string TYPE_STAFF = "Staff";

        private readonly MainWindowView _parentView;
        public ReportView(MainWindowView parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            BtnDoctor.Paint += new PaintEventHandler(PaintDoctorGradient);            
            BtnOrder.Paint += new PaintEventHandler(PaintOrderGradient);
            BtnMedication.Paint += new PaintEventHandler(PaintMedicationGradient);
            BtnAppointment.Paint += new PaintEventHandler(PaintAppointmentGradient);
            BtnPatient.Paint += new PaintEventHandler(PaintPatientGradient);
            BtnStaff.Paint += new PaintEventHandler(PaintStaffGradient);

            BtnDoctor.Tag = TYPE_DOCTOR;
            BtnOrder.Tag = TYPE_ORDER;
            BtnMedication.Tag = TYPE_MEDICATION;
            BtnAppointment.Tag = TYPE_APPOINTMENT;
            BtnPatient.Tag = TYPE_PATIENT;
            BtnStaff.Tag = TYPE_STAFF;

            BtnDoctor.Refresh();
            BtnOrder.Refresh();
            BtnMedication.Refresh();
            BtnAppointment.Refresh();
            BtnPatient.Refresh();
            BtnStaff.Refresh();
        }        
        private void SaveFileDialog(string filename, string type)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "CSV|*.csv";
            dialog.FileName = filename;
            dialog.FileOk += SaveFile_FileOk;
            dialog.Tag = type;
            dialog.ShowDialog();
        }
        private void exportAppointment(string filename)
        {
            using (var writer = new StreamWriter(filename))
            using (var csv = new CsvWriter(writer, Helper.GetCulture()))
            {
                csv.WriteHeader<Appointment>();
                csv.WriteHeader<AppointmentMedication>();
                csv.NextRecord();

                Appointment model = new Appointment();
                List<Appointment> appointments = model.FindAll();
                foreach (Appointment appointment in appointments)
                {
                    if (appointment.AppointmentMedications.Count > 0)
                    {
                        foreach (AppointmentMedication prescription in appointment.AppointmentMedications)
                        {
                            csv.WriteRecord(appointment);
                            csv.WriteRecord(prescription);
                            csv.NextRecord();
                        }
                    } else
                    {
                        csv.WriteRecord(appointment);
                        csv.NextRecord();
                    }
                }
            }
            SuccessDialog();
        }
        private void exportDoctor(string filename)
        {
            using (var writer = new StreamWriter(filename))
            using (var csv = new CsvWriter(writer, Helper.GetCulture()))
            {
                Doctor model = new Doctor();
                List<Doctor> list = model.FindAll();
                csv.WriteRecords(list);
            }
            SuccessDialog();
        }
        private void exportMedication(string filename)
        {
            using (var writer = new StreamWriter(filename))
            using (var csv = new CsvWriter(writer, Helper.GetCulture()))
            {
                Medication model = new Medication();
                List<Medication> list = model.FindAll();
                csv.WriteRecords(list);
            }
            SuccessDialog();
        }
        private void exportOrder(string filename)
        {
            using (var writer = new StreamWriter(filename))
            using (var csv = new CsvWriter(writer, Helper.GetCulture()))
            {
                Order model = new Order();
                List<Order> list = model.FindAll();
                csv.WriteRecords(list);
            }
            SuccessDialog();
        }
        private void exportPatient(string filename)
        {
            using (var writer = new StreamWriter(filename))
            using (var csv = new CsvWriter(writer, Helper.GetCulture()))
            {
                Patient model = new Patient();
                List<Patient> list = model.FindAll();
                csv.WriteRecords(list);
            }
            SuccessDialog();
        }
        private void exportStaff(string filename)
        {
            using (var writer = new StreamWriter(filename))
            using (var csv = new CsvWriter(writer, Helper.GetCulture()))
            {
                User model = new User();
                List<User> list = model.FindAllStaff();
                csv.WriteRecords(list);
            }
            SuccessDialog();
        }
        private void SuccessDialog()
        {
            MessageBox.Show(
                "Report exported successfully",
                "Report Export",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private void SaveFile_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
            {
                return;
            }
            SaveFileDialog dialog = (SaveFileDialog)sender;
            string filename = dialog.FileName;
            string type = (string)dialog.Tag;
            switch (type)
            {
                case TYPE_APPOINTMENT:
                    exportAppointment(filename);
                    break;
                case TYPE_DOCTOR:
                    exportDoctor(filename);
                    break;
                case TYPE_MEDICATION:
                    exportMedication(filename);
                    break;
                case TYPE_ORDER:
                    exportOrder(filename);
                    break;
                case TYPE_PATIENT:
                    exportPatient(filename);
                    break;
                case TYPE_STAFF:
                    exportStaff(filename);
                    break;
            }
            return;
        }
        private string GenerateFilename(string type)
        {
            return $"Report - {type} - " + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";
        }
        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            SaveFileDialog(
                GenerateFilename(TYPE_DOCTOR),
                TYPE_DOCTOR
            );
        }
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            SaveFileDialog(
                GenerateFilename(TYPE_ORDER),
                TYPE_ORDER
            );
        }
        private void BtnMedication_Click(object sender, EventArgs e)
        {
            SaveFileDialog(
                GenerateFilename(TYPE_MEDICATION),
                TYPE_MEDICATION
            );
        }
        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            SaveFileDialog(
                GenerateFilename(TYPE_APPOINTMENT),
                TYPE_APPOINTMENT
            );
        }
        private void BtnPatient_Click(object sender, EventArgs e)
        {
            SaveFileDialog(
                GenerateFilename(TYPE_PATIENT),
                TYPE_PATIENT
            );
        }
        private void BtnStaff_Click(object sender, EventArgs e)
        {
            SaveFileDialog(
                GenerateFilename(TYPE_STAFF),
                TYPE_STAFF
            );
        }
        private void ButtonGradient(Graphics g, Button btn, Color start, Color end, float angle = -135f)
        {
            Rectangle rectangle = new Rectangle(0, 0, btn.Width, btn.Height);
            LinearGradientBrush lgb = new LinearGradientBrush(
               rectangle,
               start,
               end,
               angle
           );
            g.FillRectangle(lgb, rectangle);
        }
        private void ButtonText(Graphics g, Button btn)
        {
            SizeF size = g.MeasureString(btn.Text, btn.Font);
            PointF topLeft = new PointF(btn.Width / 2 - size.Width / 2, btn.Height / 2 - size.Height / 2);
            g.DrawString(btn.Text, btn.Font, Brushes.White, topLeft);
        }
        private void PaintDoctorGradient(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Button btn = BtnDoctor;
            ButtonGradient(
                g,
                btn,
                Color.FromArgb(91, 33, 182),
                Color.FromArgb(167, 139, 250)
            );
            ButtonText(g, btn);
        }
        private void PaintOrderGradient(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Button btn = BtnOrder;
            ButtonGradient(
                g,
                btn,
                Color.FromArgb(55, 48, 163),
                Color.FromArgb(129, 140, 248)
            );
            ButtonText(g, btn);
        }
        private void PaintMedicationGradient(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Button btn = BtnMedication;
            ButtonGradient(
                g,
                btn,
                Color.FromArgb(30, 64, 175),
                Color.FromArgb(96, 165, 250)
            );
            ButtonText(g, btn);
        }
        private void PaintAppointmentGradient(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Button btn = BtnAppointment;
            ButtonGradient(
                g,
                btn,
                Color.FromArgb(7, 89, 133),
                Color.FromArgb(56, 189, 248)
            );
            ButtonText(g, btn);
        }
        private void PaintPatientGradient(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Button btn = BtnPatient;
            ButtonGradient(
                g,
                btn,
                Color.FromArgb(21, 94, 117),
                Color.FromArgb(34, 211, 238)
            );
            ButtonText(g, btn);
        }
        private void PaintStaffGradient(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Button btn = BtnStaff;
            ButtonGradient(
                g,
                btn,
                Color.FromArgb(17, 94, 89),
                Color.FromArgb(45, 212, 191)
            );
            ButtonText(g, btn);
        }
    }
}
