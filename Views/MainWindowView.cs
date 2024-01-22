/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using cms.Models;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class MainWindowView : Form
    {
        private IconButton _currentButton;
        private Form _currentForm;
        public User CurrentUser { get; set; }
        private AuthenticationWindowView _authenticationWindow { get; set; }
        public MainWindowView(User currentUser, AuthenticationWindowView authenticationWindow)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            _authenticationWindow = authenticationWindow;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            LayoutTitle.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            if (!CurrentUser.IsAdmin) { 
                MenuStaffs.Visible = false;
                MenuReport.Visible = false;
            } else
            {
                MenuStaffs.Visible = true;
                MenuReport.Visible = true;
            }
            ActivateButton(MenuAppointments);
            DisplayChildForm(new AppointmentView(this, CurrentUser));
        }
        private void ActivateButton(object sender)
        {
            Color TextColor = Color.FromArgb(101, 105, 238);
            Color BgColor = Color.FromArgb(224, 231, 255);
            if (sender != null)
            {
                ResetButton();
                _currentButton = sender as IconButton;
                _currentButton.BackColor = BgColor;
                _currentButton.ForeColor = TextColor;
                _currentButton.IconColor = TextColor;
                _currentButton.Padding = new Padding(15, 0, 10, 0);
            }
        }
        private void ResetButton()
        {
            Color TextColor = Color.FromArgb(64, 64, 64);
            Color BgColor = Color.FromArgb(255, 255, 255);
            if (_currentButton != null)
            {
                _currentButton.BackColor = BgColor;
                _currentButton.ForeColor = TextColor;
                _currentButton.IconColor = TextColor;
                _currentButton.Padding = new Padding(10, 0, 10, 0);
            }
        }
        private void DisplayChildForm(Form form)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }
            _currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            LayoutContent.Controls.Add(form);
            LayoutContent.Tag = form;
            form.BringToFront();
            form.Show();
            LayoutTitle.Text = form.Text;
        }
        private void MenuAppointments_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DisplayChildForm(new AppointmentView(this, CurrentUser));
        }
        private void MenuDoctors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DisplayChildForm(new DoctorView(this));
        }
        private void MenuPatients_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DisplayChildForm(new PatientView(this));
        }
        private void MenuMedications_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DisplayChildForm(new MedicationView(this));
        }
        private void MenuOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DisplayChildForm(new OrderView(this));
        }
        private void MenuReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DisplayChildForm(new ReportView(this));
        }
        private void MenuStaffs_Click(object sender, EventArgs e)
        {
            if (!CurrentUser.IsAdmin)
            {
                MessageBox.Show(
                    "You are not authorized to view this page.",
                    "Unauthorized Access",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
                return;
            }
            ActivateButton(sender);
            DisplayChildForm(new StaffView(this));
        }
        private void MenuProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DisplayChildForm(new ProfileView(this));
        }
        private void MenuLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Signing Out",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.OK)
            {
                this.Close();
                CurrentUser = null;
                _authenticationWindow.Show();
            }            
        }
        private void LayoutCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LayoutMaximiseButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void LayoutMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void LayoutHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
