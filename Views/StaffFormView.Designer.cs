namespace cms.Views
{
    partial class StaffFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffFormView));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FormTitle = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.LabelContactNumber = new System.Windows.Forms.Label();
            this.InputContactNumber = new System.Windows.Forms.TextBox();
            this.LabelEmploymentType = new System.Windows.Forms.Label();
            this.InputEmploymentStatus = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelRepeatPassword = new System.Windows.Forms.Label();
            this.InputRepeatPassword = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.LabelDateOfBirth = new System.Windows.Forms.Label();
            this.InputDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.InputStatus = new System.Windows.Forms.ComboBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FormTitle);
            this.flowLayoutPanel1.Controls.Add(this.LabelUsername);
            this.flowLayoutPanel1.Controls.Add(this.InputUsername);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.LabelAddress);
            this.flowLayoutPanel1.Controls.Add(this.InputAddress);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 465);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.Location = new System.Drawing.Point(10, 10);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(51, 21);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "label1";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(10, 51);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(67, 17);
            this.LabelUsername.TabIndex = 1;
            this.LabelUsername.Text = "Username";
            // 
            // InputUsername
            // 
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.InputUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.Location = new System.Drawing.Point(10, 71);
            this.InputUsername.Margin = new System.Windows.Forms.Padding(0);
            this.InputUsername.MaxLength = 100;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(400, 25);
            this.InputUsername.TabIndex = 2;
            this.InputUsername.Tag = "Username";
            this.InputUsername.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 96);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(400, 100);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(400, 220);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.LabelPassword);
            this.flowLayoutPanel4.Controls.Add(this.InputPassword);
            this.flowLayoutPanel4.Controls.Add(this.LabelName);
            this.flowLayoutPanel4.Controls.Add(this.InputName);
            this.flowLayoutPanel4.Controls.Add(this.LabelContactNumber);
            this.flowLayoutPanel4.Controls.Add(this.InputContactNumber);
            this.flowLayoutPanel4.Controls.Add(this.LabelEmploymentType);
            this.flowLayoutPanel4.Controls.Add(this.InputEmploymentStatus);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.MinimumSize = new System.Drawing.Size(195, 100);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(195, 220);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(0, 10);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(64, 17);
            this.LabelPassword.TabIndex = 0;
            this.LabelPassword.Text = "Password";
            // 
            // InputPassword
            // 
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.Location = new System.Drawing.Point(0, 30);
            this.InputPassword.Margin = new System.Windows.Forms.Padding(0);
            this.InputPassword.MaxLength = 100;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(195, 25);
            this.InputPassword.TabIndex = 1;
            this.InputPassword.Tag = "Name";
            this.InputPassword.UseSystemPasswordChar = true;
            this.InputPassword.DoubleClick += new System.EventHandler(this.InputPassword_DoubleClick);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(0, 65);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(43, 17);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name";
            // 
            // InputName
            // 
            this.InputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputName.Location = new System.Drawing.Point(0, 85);
            this.InputName.Margin = new System.Windows.Forms.Padding(0);
            this.InputName.MaxLength = 100;
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(195, 25);
            this.InputName.TabIndex = 3;
            this.InputName.Tag = "Name";
            this.InputName.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelContactNumber
            // 
            this.LabelContactNumber.AutoSize = true;
            this.LabelContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContactNumber.Location = new System.Drawing.Point(0, 120);
            this.LabelContactNumber.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelContactNumber.Name = "LabelContactNumber";
            this.LabelContactNumber.Size = new System.Drawing.Size(104, 17);
            this.LabelContactNumber.TabIndex = 4;
            this.LabelContactNumber.Text = "Contact Number";
            // 
            // InputContactNumber
            // 
            this.InputContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputContactNumber.Location = new System.Drawing.Point(0, 140);
            this.InputContactNumber.Margin = new System.Windows.Forms.Padding(0);
            this.InputContactNumber.MaxLength = 100;
            this.InputContactNumber.Name = "InputContactNumber";
            this.InputContactNumber.Size = new System.Drawing.Size(195, 25);
            this.InputContactNumber.TabIndex = 5;
            this.InputContactNumber.Tag = "ContactNumber";
            this.InputContactNumber.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelEmploymentType
            // 
            this.LabelEmploymentType.AutoSize = true;
            this.LabelEmploymentType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmploymentType.Location = new System.Drawing.Point(0, 175);
            this.LabelEmploymentType.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelEmploymentType.Name = "LabelEmploymentType";
            this.LabelEmploymentType.Size = new System.Drawing.Size(111, 17);
            this.LabelEmploymentType.TabIndex = 6;
            this.LabelEmploymentType.Text = "Employment Type";
            // 
            // InputEmploymentStatus
            // 
            this.InputEmploymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputEmploymentStatus.FormattingEnabled = true;
            this.InputEmploymentStatus.Location = new System.Drawing.Point(0, 195);
            this.InputEmploymentStatus.Margin = new System.Windows.Forms.Padding(0);
            this.InputEmploymentStatus.Name = "InputEmploymentStatus";
            this.InputEmploymentStatus.Size = new System.Drawing.Size(195, 25);
            this.InputEmploymentStatus.TabIndex = 7;
            this.InputEmploymentStatus.Tag = "EmploymentType";
            this.InputEmploymentStatus.SelectedIndexChanged += new System.EventHandler(this.InputEmploymentStatus_SelectedIndexChanged);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.LabelRepeatPassword);
            this.flowLayoutPanel5.Controls.Add(this.InputRepeatPassword);
            this.flowLayoutPanel5.Controls.Add(this.LabelEmail);
            this.flowLayoutPanel5.Controls.Add(this.InputEmail);
            this.flowLayoutPanel5.Controls.Add(this.LabelDateOfBirth);
            this.flowLayoutPanel5.Controls.Add(this.InputDateOfBirth);
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Controls.Add(this.InputStatus);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(205, 0);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel5.MinimumSize = new System.Drawing.Size(195, 100);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(195, 220);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // LabelRepeatPassword
            // 
            this.LabelRepeatPassword.AutoSize = true;
            this.LabelRepeatPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRepeatPassword.Location = new System.Drawing.Point(0, 10);
            this.LabelRepeatPassword.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelRepeatPassword.Name = "LabelRepeatPassword";
            this.LabelRepeatPassword.Size = new System.Drawing.Size(109, 17);
            this.LabelRepeatPassword.TabIndex = 0;
            this.LabelRepeatPassword.Text = "Repeat Password";
            // 
            // InputRepeatPassword
            // 
            this.InputRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputRepeatPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputRepeatPassword.Location = new System.Drawing.Point(0, 30);
            this.InputRepeatPassword.Margin = new System.Windows.Forms.Padding(0);
            this.InputRepeatPassword.MaxLength = 100;
            this.InputRepeatPassword.Name = "InputRepeatPassword";
            this.InputRepeatPassword.Size = new System.Drawing.Size(195, 25);
            this.InputRepeatPassword.TabIndex = 1;
            this.InputRepeatPassword.Tag = "Name";
            this.InputRepeatPassword.UseSystemPasswordChar = true;
            this.InputRepeatPassword.DoubleClick += new System.EventHandler(this.InputPassword_DoubleClick);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(0, 65);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(39, 17);
            this.LabelEmail.TabIndex = 2;
            this.LabelEmail.Text = "Email";
            // 
            // InputEmail
            // 
            this.InputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEmail.Location = new System.Drawing.Point(0, 85);
            this.InputEmail.Margin = new System.Windows.Forms.Padding(0);
            this.InputEmail.MaxLength = 100;
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(195, 25);
            this.InputEmail.TabIndex = 3;
            this.InputEmail.Tag = "Email";
            this.InputEmail.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelDateOfBirth
            // 
            this.LabelDateOfBirth.AutoSize = true;
            this.LabelDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDateOfBirth.Location = new System.Drawing.Point(0, 120);
            this.LabelDateOfBirth.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelDateOfBirth.Name = "LabelDateOfBirth";
            this.LabelDateOfBirth.Size = new System.Drawing.Size(83, 17);
            this.LabelDateOfBirth.TabIndex = 4;
            this.LabelDateOfBirth.Text = "Date Of Birth";
            // 
            // InputDateOfBirth
            // 
            this.InputDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.InputDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InputDateOfBirth.Location = new System.Drawing.Point(0, 140);
            this.InputDateOfBirth.Margin = new System.Windows.Forms.Padding(0);
            this.InputDateOfBirth.Name = "InputDateOfBirth";
            this.InputDateOfBirth.Size = new System.Drawing.Size(195, 25);
            this.InputDateOfBirth.TabIndex = 5;
            this.InputDateOfBirth.Tag = "DateOfBirth";
            this.InputDateOfBirth.ValueChanged += new System.EventHandler(this.InputDateOfBirth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status";
            // 
            // InputStatus
            // 
            this.InputStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputStatus.FormattingEnabled = true;
            this.InputStatus.Location = new System.Drawing.Point(0, 195);
            this.InputStatus.Margin = new System.Windows.Forms.Padding(0);
            this.InputStatus.Name = "InputStatus";
            this.InputStatus.Size = new System.Drawing.Size(195, 25);
            this.InputStatus.TabIndex = 7;
            this.InputStatus.Tag = "Status";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(10, 326);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(56, 17);
            this.LabelAddress.TabIndex = 4;
            this.LabelAddress.Text = "Address";
            // 
            // InputAddress
            // 
            this.InputAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddress.Location = new System.Drawing.Point(10, 346);
            this.InputAddress.Margin = new System.Windows.Forms.Padding(0);
            this.InputAddress.MaxLength = 100;
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Size = new System.Drawing.Size(400, 25);
            this.InputAddress.TabIndex = 5;
            this.InputAddress.Tag = "Address";
            this.InputAddress.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.BtnSave);
            this.flowLayoutPanel3.Controls.Add(this.BtnCancel);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(10, 391);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(400, 27);
            this.flowLayoutPanel3.TabIndex = 6;
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
            // StaffFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 465);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Staff";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Label LabelContactNumber;
        private System.Windows.Forms.TextBox InputContactNumber;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox InputAddress;
        private System.Windows.Forms.Label LabelDateOfBirth;
        private System.Windows.Forms.DateTimePicker InputDateOfBirth;
        private System.Windows.Forms.Label LabelEmploymentType;
        private System.Windows.Forms.ComboBox InputEmploymentStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label LabelRepeatPassword;
        private System.Windows.Forms.TextBox InputRepeatPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox InputStatus;
    }
}