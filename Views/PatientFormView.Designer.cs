namespace cms.Views
{
    partial class PatientFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientFormView));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FormTitle = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.LabelContactNumber = new System.Windows.Forms.Label();
            this.InputContactNumber = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FormTitle);
            this.flowLayoutPanel1.Controls.Add(this.LabelName);
            this.flowLayoutPanel1.Controls.Add(this.InputName);
            this.flowLayoutPanel1.Controls.Add(this.LabelEmail);
            this.flowLayoutPanel1.Controls.Add(this.InputEmail);
            this.flowLayoutPanel1.Controls.Add(this.LabelContactNumber);
            this.flowLayoutPanel1.Controls.Add(this.InputContactNumber);
            this.flowLayoutPanel1.Controls.Add(this.LabelAddress);
            this.flowLayoutPanel1.Controls.Add(this.InputAddress);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 445);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.Location = new System.Drawing.Point(0, 0);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(51, 21);
            this.FormTitle.TabIndex = 1;
            this.FormTitle.Text = "label1";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(0, 41);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(43, 17);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name";
            // 
            // InputName
            // 
            this.InputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputName.Location = new System.Drawing.Point(0, 61);
            this.InputName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputName.MaxLength = 100;
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(400, 25);
            this.InputName.TabIndex = 3;
            this.InputName.Tag = "Username";
            this.InputName.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(0, 96);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(39, 17);
            this.LabelEmail.TabIndex = 4;
            this.LabelEmail.Text = "Email";
            // 
            // InputEmail
            // 
            this.InputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEmail.Location = new System.Drawing.Point(0, 116);
            this.InputEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputEmail.MaxLength = 100;
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(400, 25);
            this.InputEmail.TabIndex = 5;
            this.InputEmail.Tag = "Username";
            this.InputEmail.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelContactNumber
            // 
            this.LabelContactNumber.AutoSize = true;
            this.LabelContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContactNumber.Location = new System.Drawing.Point(0, 151);
            this.LabelContactNumber.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelContactNumber.Name = "LabelContactNumber";
            this.LabelContactNumber.Size = new System.Drawing.Size(104, 17);
            this.LabelContactNumber.TabIndex = 6;
            this.LabelContactNumber.Text = "Contact Number";
            // 
            // InputContactNumber
            // 
            this.InputContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputContactNumber.Location = new System.Drawing.Point(0, 171);
            this.InputContactNumber.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputContactNumber.MaxLength = 100;
            this.InputContactNumber.Name = "InputContactNumber";
            this.InputContactNumber.Size = new System.Drawing.Size(400, 25);
            this.InputContactNumber.TabIndex = 7;
            this.InputContactNumber.Tag = "Username";
            this.InputContactNumber.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(0, 206);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(56, 17);
            this.LabelAddress.TabIndex = 8;
            this.LabelAddress.Text = "Address";
            // 
            // InputAddress
            // 
            this.InputAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddress.Location = new System.Drawing.Point(0, 226);
            this.InputAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputAddress.MaxLength = 100;
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Size = new System.Drawing.Size(400, 25);
            this.InputAddress.TabIndex = 9;
            this.InputAddress.Tag = "Username";
            this.InputAddress.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(0, 0);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 27);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancel.Location = new System.Drawing.Point(80, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 27);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.BtnSave);
            this.flowLayoutPanel3.Controls.Add(this.BtnCancel);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 271);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(400, 27);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // PatientFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 465);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientFormView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Label LabelContactNumber;
        private System.Windows.Forms.TextBox InputContactNumber;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox InputAddress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}