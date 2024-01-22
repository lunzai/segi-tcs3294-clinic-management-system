namespace cms.Views
{
    partial class RegistrationView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.LabelContactNumber = new System.Windows.Forms.Label();
            this.InputContactNumber = new System.Windows.Forms.TextBox();
            this.LabelDateOfBirth = new System.Windows.Forms.Label();
            this.InputDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelPasswordRepeat = new System.Windows.Forms.Label();
            this.InputPasswordRepeat = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.LabelEmploymentType = new System.Windows.Forms.Label();
            this.InputEmploymentType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 105);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 360);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "REGISTER ACCOUNT";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.LabelUsername);
            this.flowLayoutPanel5.Controls.Add(this.InputUsername);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(420, 45);
            this.flowLayoutPanel5.TabIndex = 18;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(0, 0);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(77, 17);
            this.LabelUsername.TabIndex = 1;
            this.LabelUsername.Text = "USERNAME";
            // 
            // InputUsername
            // 
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.InputUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.Location = new System.Drawing.Point(0, 20);
            this.InputUsername.Margin = new System.Windows.Forms.Padding(0);
            this.InputUsername.MaxLength = 50;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(420, 25);
            this.InputUsername.TabIndex = 0;
            this.InputUsername.TextChanged += new System.EventHandler(this.InputUsername_TextChanged);
            this.InputUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.LabelPassword);
            this.flowLayoutPanel3.Controls.Add(this.InputPassword);
            this.flowLayoutPanel3.Controls.Add(this.LabelName);
            this.flowLayoutPanel3.Controls.Add(this.InputName);
            this.flowLayoutPanel3.Controls.Add(this.LabelContactNumber);
            this.flowLayoutPanel3.Controls.Add(this.InputContactNumber);
            this.flowLayoutPanel3.Controls.Add(this.LabelDateOfBirth);
            this.flowLayoutPanel3.Controls.Add(this.InputDateOfBirth);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 92);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 220);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(0, 10);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(78, 17);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "PASSWORD";
            // 
            // InputPassword
            // 
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.Location = new System.Drawing.Point(0, 30);
            this.InputPassword.Margin = new System.Windows.Forms.Padding(0);
            this.InputPassword.MaxLength = 100;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(200, 25);
            this.InputPassword.TabIndex = 2;
            this.InputPassword.UseSystemPasswordChar = true;
            this.InputPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(0, 65);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(46, 17);
            this.LabelName.TabIndex = 9;
            this.LabelName.Text = "NAME";
            // 
            // InputName
            // 
            this.InputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputName.Location = new System.Drawing.Point(0, 85);
            this.InputName.Margin = new System.Windows.Forms.Padding(0);
            this.InputName.MaxLength = 100;
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(200, 25);
            this.InputName.TabIndex = 8;
            this.InputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelContactNumber
            // 
            this.LabelContactNumber.AutoSize = true;
            this.LabelContactNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContactNumber.Location = new System.Drawing.Point(0, 120);
            this.LabelContactNumber.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelContactNumber.Name = "LabelContactNumber";
            this.LabelContactNumber.Size = new System.Drawing.Size(124, 17);
            this.LabelContactNumber.TabIndex = 13;
            this.LabelContactNumber.Text = "CONTACT NUMBER";
            // 
            // InputContactNumber
            // 
            this.InputContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputContactNumber.Location = new System.Drawing.Point(0, 140);
            this.InputContactNumber.Margin = new System.Windows.Forms.Padding(0);
            this.InputContactNumber.MaxLength = 20;
            this.InputContactNumber.Name = "InputContactNumber";
            this.InputContactNumber.Size = new System.Drawing.Size(200, 25);
            this.InputContactNumber.TabIndex = 12;
            this.InputContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelDateOfBirth
            // 
            this.LabelDateOfBirth.AutoSize = true;
            this.LabelDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDateOfBirth.Location = new System.Drawing.Point(0, 175);
            this.LabelDateOfBirth.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelDateOfBirth.Name = "LabelDateOfBirth";
            this.LabelDateOfBirth.Size = new System.Drawing.Size(101, 17);
            this.LabelDateOfBirth.TabIndex = 15;
            this.LabelDateOfBirth.Text = "DATE OF BIRTH";
            // 
            // InputDateOfBirth
            // 
            this.InputDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.InputDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InputDateOfBirth.Location = new System.Drawing.Point(0, 195);
            this.InputDateOfBirth.Margin = new System.Windows.Forms.Padding(0);
            this.InputDateOfBirth.Name = "InputDateOfBirth";
            this.InputDateOfBirth.Size = new System.Drawing.Size(200, 25);
            this.InputDateOfBirth.TabIndex = 16;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.LabelPasswordRepeat);
            this.flowLayoutPanel4.Controls.Add(this.InputPasswordRepeat);
            this.flowLayoutPanel4.Controls.Add(this.LabelEmail);
            this.flowLayoutPanel4.Controls.Add(this.InputEmail);
            this.flowLayoutPanel4.Controls.Add(this.LabelAddress);
            this.flowLayoutPanel4.Controls.Add(this.InputAddress);
            this.flowLayoutPanel4.Controls.Add(this.LabelEmploymentType);
            this.flowLayoutPanel4.Controls.Add(this.InputEmploymentType);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(220, 92);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 220);
            this.flowLayoutPanel4.TabIndex = 17;
            // 
            // LabelPasswordRepeat
            // 
            this.LabelPasswordRepeat.AutoSize = true;
            this.LabelPasswordRepeat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordRepeat.Location = new System.Drawing.Point(0, 10);
            this.LabelPasswordRepeat.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelPasswordRepeat.Name = "LabelPasswordRepeat";
            this.LabelPasswordRepeat.Size = new System.Drawing.Size(127, 17);
            this.LabelPasswordRepeat.TabIndex = 7;
            this.LabelPasswordRepeat.Text = "REPEAT PASSWORD";
            // 
            // InputPasswordRepeat
            // 
            this.InputPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPasswordRepeat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPasswordRepeat.Location = new System.Drawing.Point(0, 30);
            this.InputPasswordRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.InputPasswordRepeat.MaxLength = 100;
            this.InputPasswordRepeat.Name = "InputPasswordRepeat";
            this.InputPasswordRepeat.Size = new System.Drawing.Size(200, 25);
            this.InputPasswordRepeat.TabIndex = 6;
            this.InputPasswordRepeat.UseSystemPasswordChar = true;
            this.InputPasswordRepeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(0, 65);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(46, 17);
            this.LabelEmail.TabIndex = 11;
            this.LabelEmail.Text = "EMAIL";
            // 
            // InputEmail
            // 
            this.InputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.InputEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEmail.Location = new System.Drawing.Point(0, 85);
            this.InputEmail.Margin = new System.Windows.Forms.Padding(0);
            this.InputEmail.MaxLength = 100;
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(200, 25);
            this.InputEmail.TabIndex = 10;
            this.InputEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(0, 120);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(64, 17);
            this.LabelAddress.TabIndex = 15;
            this.LabelAddress.Text = "ADDRESS";
            // 
            // InputAddress
            // 
            this.InputAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddress.Location = new System.Drawing.Point(0, 140);
            this.InputAddress.Margin = new System.Windows.Forms.Padding(0);
            this.InputAddress.MaxLength = 100;
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Size = new System.Drawing.Size(200, 25);
            this.InputAddress.TabIndex = 14;
            this.InputAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelEmploymentType
            // 
            this.LabelEmploymentType.AutoSize = true;
            this.LabelEmploymentType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmploymentType.Location = new System.Drawing.Point(0, 175);
            this.LabelEmploymentType.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.LabelEmploymentType.Name = "LabelEmploymentType";
            this.LabelEmploymentType.Size = new System.Drawing.Size(129, 17);
            this.LabelEmploymentType.TabIndex = 16;
            this.LabelEmploymentType.Text = "EMPLOYMENT TYPE";
            // 
            // InputEmploymentType
            // 
            this.InputEmploymentType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEmploymentType.FormattingEnabled = true;
            this.InputEmploymentType.Location = new System.Drawing.Point(0, 195);
            this.InputEmploymentType.Margin = new System.Windows.Forms.Padding(0);
            this.InputEmploymentType.Name = "InputEmploymentType";
            this.InputEmploymentType.Size = new System.Drawing.Size(200, 25);
            this.InputEmploymentType.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.BtnRegister);
            this.flowLayoutPanel2.Controls.Add(this.BtnCancel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 327);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(212, 29);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // BtnRegister
            // 
            this.BtnRegister.AutoSize = true;
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(0, 0);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnRegister.Size = new System.Drawing.Size(86, 29);
            this.BtnRegister.TabIndex = 0;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
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
            this.BtnCancel.Location = new System.Drawing.Point(91, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCancel.Size = new System.Drawing.Size(116, 29);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Back to Login";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // RegistrationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 576);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(500, 576);
            this.MinimumSize = new System.Drawing.Size(500, 576);
            this.Name = "RegistrationView";
            this.Text = "RegistrationView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label LabelPasswordRepeat;
        private System.Windows.Forms.TextBox InputPasswordRepeat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Label LabelContactNumber;
        private System.Windows.Forms.TextBox InputContactNumber;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox InputAddress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label LabelDateOfBirth;
        private System.Windows.Forms.DateTimePicker InputDateOfBirth;
        private System.Windows.Forms.Label LabelEmploymentType;
        private System.Windows.Forms.ComboBox InputEmploymentType;
    }
}