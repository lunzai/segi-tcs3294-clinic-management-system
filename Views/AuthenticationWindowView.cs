/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace cms.Views
{
    public partial class AuthenticationWindowView : Form
    {
        private Form _currentForm;
        public AuthenticationWindowView()
        {
            InitializeComponent();
            PanelLeft.Paint += new PaintEventHandler(PanelGradient);
            PanelLeft.Refresh();
            DisplayChildForm(new LoginView(this));
        }
        public void DisplayChildForm(Form form)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }
            _currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(form);
            PanelContent.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void PanelGradient(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(0, 0, PanelLeft.Width, PanelLeft.Height);
            LinearGradientBrush lgb = new LinearGradientBrush(
                rectangle,
                Color.FromArgb(139, 92, 246),
                Color.FromArgb(76, 29, 149),
                135f
            );
            e.Graphics.FillRectangle(lgb, rectangle);
        }
        private void LayoutCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
