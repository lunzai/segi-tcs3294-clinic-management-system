namespace cms.Views
{
    partial class ReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LayoutMain = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnDoctor = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnMedication = new System.Windows.Forms.Button();
            this.BtnAppointment = new System.Windows.Forms.Button();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnStaff = new System.Windows.Forms.Button();
            this.LayoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            this.LayoutMain.BackColor = System.Drawing.Color.White;
            this.LayoutMain.Controls.Add(this.BtnDoctor);
            this.LayoutMain.Controls.Add(this.BtnOrder);
            this.LayoutMain.Controls.Add(this.BtnMedication);
            this.LayoutMain.Controls.Add(this.BtnAppointment);
            this.LayoutMain.Controls.Add(this.BtnPatient);
            this.LayoutMain.Controls.Add(this.BtnStaff);
            this.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMain.Location = new System.Drawing.Point(10, 10);
            this.LayoutMain.Name = "LayoutMain";
            this.LayoutMain.Padding = new System.Windows.Forms.Padding(10);
            this.LayoutMain.Size = new System.Drawing.Size(819, 688);
            this.LayoutMain.TabIndex = 0;
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.BtnDoctor.FlatAppearance.BorderSize = 0;
            this.BtnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoctor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctor.ForeColor = System.Drawing.Color.White;
            this.BtnDoctor.Location = new System.Drawing.Point(10, 10);
            this.BtnDoctor.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(260, 120);
            this.BtnDoctor.TabIndex = 1;
            this.BtnDoctor.Text = "Doctor Report";
            this.BtnDoctor.UseVisualStyleBackColor = false;
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.BtnOrder.FlatAppearance.BorderSize = 0;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.Color.White;
            this.BtnOrder.Location = new System.Drawing.Point(280, 10);
            this.BtnOrder.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(259, 120);
            this.BtnOrder.TabIndex = 2;
            this.BtnOrder.Text = "Order Report";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnMedication
            // 
            this.BtnMedication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.BtnMedication.FlatAppearance.BorderSize = 0;
            this.BtnMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedication.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedication.ForeColor = System.Drawing.Color.White;
            this.BtnMedication.Location = new System.Drawing.Point(549, 10);
            this.BtnMedication.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMedication.Name = "BtnMedication";
            this.BtnMedication.Size = new System.Drawing.Size(260, 120);
            this.BtnMedication.TabIndex = 3;
            this.BtnMedication.Text = "Medication Report";
            this.BtnMedication.UseVisualStyleBackColor = false;
            this.BtnMedication.Click += new System.EventHandler(this.BtnMedication_Click);
            // 
            // BtnAppointment
            // 
            this.BtnAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.BtnAppointment.FlatAppearance.BorderSize = 0;
            this.BtnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAppointment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppointment.ForeColor = System.Drawing.Color.White;
            this.BtnAppointment.Location = new System.Drawing.Point(10, 140);
            this.BtnAppointment.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.BtnAppointment.Name = "BtnAppointment";
            this.BtnAppointment.Size = new System.Drawing.Size(260, 120);
            this.BtnAppointment.TabIndex = 4;
            this.BtnAppointment.Text = "Appointment Report";
            this.BtnAppointment.UseVisualStyleBackColor = false;
            this.BtnAppointment.Click += new System.EventHandler(this.BtnAppointment_Click);
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(178)))));
            this.BtnPatient.FlatAppearance.BorderSize = 0;
            this.BtnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatient.ForeColor = System.Drawing.Color.White;
            this.BtnPatient.Location = new System.Drawing.Point(280, 140);
            this.BtnPatient.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(259, 120);
            this.BtnPatient.TabIndex = 5;
            this.BtnPatient.Text = "Patient Report";
            this.BtnPatient.UseVisualStyleBackColor = false;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // BtnStaff
            // 
            this.BtnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.BtnStaff.FlatAppearance.BorderSize = 0;
            this.BtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStaff.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStaff.ForeColor = System.Drawing.Color.White;
            this.BtnStaff.Location = new System.Drawing.Point(549, 140);
            this.BtnStaff.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStaff.Name = "BtnStaff";
            this.BtnStaff.Size = new System.Drawing.Size(260, 120);
            this.BtnStaff.TabIndex = 6;
            this.BtnStaff.Text = "Staff Report";
            this.BtnStaff.UseVisualStyleBackColor = false;
            this.BtnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(839, 708);
            this.Controls.Add(this.LayoutMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Download Reports";
            this.LayoutMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LayoutMain;
        private System.Windows.Forms.Button BtnDoctor;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnMedication;
        private System.Windows.Forms.Button BtnAppointment;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button BtnStaff;
    }
}