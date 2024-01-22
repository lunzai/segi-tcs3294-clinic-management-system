namespace cms.Views
{
    partial class ProfileView
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
            this.TabProfile = new System.Windows.Forms.TabControl();
            this.TabProfileDetails = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PDLUsername = new System.Windows.Forms.Label();
            this.PDIUsername = new System.Windows.Forms.TextBox();
            this.PDLName = new System.Windows.Forms.Label();
            this.PDIName = new System.Windows.Forms.TextBox();
            this.PDLEmail = new System.Windows.Forms.Label();
            this.PDIEmail = new System.Windows.Forms.TextBox();
            this.PDLContactNumber = new System.Windows.Forms.Label();
            this.PDIContactNumber = new System.Windows.Forms.TextBox();
            this.PDLAddress = new System.Windows.Forms.Label();
            this.PDIAddress = new System.Windows.Forms.TextBox();
            this.PDLDateOfBirth = new System.Windows.Forms.Label();
            this.PDIDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.PDLEmploymentStatus = new System.Windows.Forms.Label();
            this.PDIEmploymentStatus = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PDBUpdate = new System.Windows.Forms.Button();
            this.PDBReset = new System.Windows.Forms.Button();
            this.TabChangePassword = new System.Windows.Forms.TabPage();
            this.PanelChangePassword = new System.Windows.Forms.FlowLayoutPanel();
            this.CPLCurrentPassword = new System.Windows.Forms.Label();
            this.CPICurrentPassword = new System.Windows.Forms.TextBox();
            this.CPLNewPassword = new System.Windows.Forms.Label();
            this.CPINewPassword = new System.Windows.Forms.TextBox();
            this.CPLNewPasswordRepeat = new System.Windows.Forms.Label();
            this.CPINewPasswordRepeat = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CPBUpdate = new System.Windows.Forms.Button();
            this.CPBReset = new System.Windows.Forms.Button();
            this.TabProfile.SuspendLayout();
            this.TabProfileDetails.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.TabChangePassword.SuspendLayout();
            this.PanelChangePassword.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabProfile
            // 
            this.TabProfile.Controls.Add(this.TabProfileDetails);
            this.TabProfile.Controls.Add(this.TabChangePassword);
            this.TabProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabProfile.Location = new System.Drawing.Point(10, 10);
            this.TabProfile.Margin = new System.Windows.Forms.Padding(0);
            this.TabProfile.Name = "TabProfile";
            this.TabProfile.Padding = new System.Drawing.Point(15, 5);
            this.TabProfile.SelectedIndex = 0;
            this.TabProfile.Size = new System.Drawing.Size(819, 688);
            this.TabProfile.TabIndex = 0;
            // 
            // TabProfileDetails
            // 
            this.TabProfileDetails.BackColor = System.Drawing.Color.White;
            this.TabProfileDetails.Controls.Add(this.flowLayoutPanel2);
            this.TabProfileDetails.Location = new System.Drawing.Point(4, 30);
            this.TabProfileDetails.Margin = new System.Windows.Forms.Padding(0);
            this.TabProfileDetails.Name = "TabProfileDetails";
            this.TabProfileDetails.Padding = new System.Windows.Forms.Padding(10);
            this.TabProfileDetails.Size = new System.Drawing.Size(811, 654);
            this.TabProfileDetails.TabIndex = 0;
            this.TabProfileDetails.Text = "Profile Details";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.PDLUsername);
            this.flowLayoutPanel2.Controls.Add(this.PDIUsername);
            this.flowLayoutPanel2.Controls.Add(this.PDLName);
            this.flowLayoutPanel2.Controls.Add(this.PDIName);
            this.flowLayoutPanel2.Controls.Add(this.PDLEmail);
            this.flowLayoutPanel2.Controls.Add(this.PDIEmail);
            this.flowLayoutPanel2.Controls.Add(this.PDLContactNumber);
            this.flowLayoutPanel2.Controls.Add(this.PDIContactNumber);
            this.flowLayoutPanel2.Controls.Add(this.PDLAddress);
            this.flowLayoutPanel2.Controls.Add(this.PDIAddress);
            this.flowLayoutPanel2.Controls.Add(this.PDLDateOfBirth);
            this.flowLayoutPanel2.Controls.Add(this.PDIDateOfBirth);
            this.flowLayoutPanel2.Controls.Add(this.PDLEmploymentStatus);
            this.flowLayoutPanel2.Controls.Add(this.PDIEmploymentStatus);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(791, 634);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // PDLUsername
            // 
            this.PDLUsername.AutoSize = true;
            this.PDLUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDLUsername.Location = new System.Drawing.Point(0, 0);
            this.PDLUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PDLUsername.Name = "PDLUsername";
            this.PDLUsername.Size = new System.Drawing.Size(67, 17);
            this.PDLUsername.TabIndex = 6;
            this.PDLUsername.Text = "Username";
            // 
            // PDIUsername
            // 
            this.PDIUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PDIUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDIUsername.Location = new System.Drawing.Point(0, 20);
            this.PDIUsername.Margin = new System.Windows.Forms.Padding(0);
            this.PDIUsername.MaxLength = 100;
            this.PDIUsername.Name = "PDIUsername";
            this.PDIUsername.ReadOnly = true;
            this.PDIUsername.Size = new System.Drawing.Size(400, 25);
            this.PDIUsername.TabIndex = 7;
            // 
            // PDLName
            // 
            this.PDLName.AutoSize = true;
            this.PDLName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDLName.Location = new System.Drawing.Point(0, 55);
            this.PDLName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.PDLName.Name = "PDLName";
            this.PDLName.Size = new System.Drawing.Size(43, 17);
            this.PDLName.TabIndex = 8;
            this.PDLName.Text = "Name";
            // 
            // PDIName
            // 
            this.PDIName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PDIName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDIName.Location = new System.Drawing.Point(0, 75);
            this.PDIName.Margin = new System.Windows.Forms.Padding(0);
            this.PDIName.MaxLength = 100;
            this.PDIName.Name = "PDIName";
            this.PDIName.Size = new System.Drawing.Size(400, 25);
            this.PDIName.TabIndex = 9;
            this.PDIName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileInput_KeyDown);
            // 
            // PDLEmail
            // 
            this.PDLEmail.AutoSize = true;
            this.PDLEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDLEmail.Location = new System.Drawing.Point(0, 110);
            this.PDLEmail.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.PDLEmail.Name = "PDLEmail";
            this.PDLEmail.Size = new System.Drawing.Size(39, 17);
            this.PDLEmail.TabIndex = 10;
            this.PDLEmail.Text = "Email";
            // 
            // PDIEmail
            // 
            this.PDIEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PDIEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDIEmail.Location = new System.Drawing.Point(0, 130);
            this.PDIEmail.Margin = new System.Windows.Forms.Padding(0);
            this.PDIEmail.MaxLength = 100;
            this.PDIEmail.Name = "PDIEmail";
            this.PDIEmail.Size = new System.Drawing.Size(400, 25);
            this.PDIEmail.TabIndex = 11;
            this.PDIEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileInput_KeyDown);
            // 
            // PDLContactNumber
            // 
            this.PDLContactNumber.AutoSize = true;
            this.PDLContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDLContactNumber.Location = new System.Drawing.Point(0, 165);
            this.PDLContactNumber.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.PDLContactNumber.Name = "PDLContactNumber";
            this.PDLContactNumber.Size = new System.Drawing.Size(104, 17);
            this.PDLContactNumber.TabIndex = 12;
            this.PDLContactNumber.Text = "Contact Number";
            // 
            // PDIContactNumber
            // 
            this.PDIContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PDIContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDIContactNumber.Location = new System.Drawing.Point(0, 185);
            this.PDIContactNumber.Margin = new System.Windows.Forms.Padding(0);
            this.PDIContactNumber.MaxLength = 100;
            this.PDIContactNumber.Name = "PDIContactNumber";
            this.PDIContactNumber.Size = new System.Drawing.Size(400, 25);
            this.PDIContactNumber.TabIndex = 13;
            this.PDIContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileInput_KeyDown);
            // 
            // PDLAddress
            // 
            this.PDLAddress.AutoSize = true;
            this.PDLAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDLAddress.Location = new System.Drawing.Point(0, 220);
            this.PDLAddress.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.PDLAddress.Name = "PDLAddress";
            this.PDLAddress.Size = new System.Drawing.Size(56, 17);
            this.PDLAddress.TabIndex = 14;
            this.PDLAddress.Text = "Address";
            // 
            // PDIAddress
            // 
            this.PDIAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PDIAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDIAddress.Location = new System.Drawing.Point(0, 240);
            this.PDIAddress.Margin = new System.Windows.Forms.Padding(0);
            this.PDIAddress.MaxLength = 100;
            this.PDIAddress.Name = "PDIAddress";
            this.PDIAddress.Size = new System.Drawing.Size(400, 25);
            this.PDIAddress.TabIndex = 15;
            this.PDIAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileInput_KeyDown);
            // 
            // PDLDateOfBirth
            // 
            this.PDLDateOfBirth.AutoSize = true;
            this.PDLDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDLDateOfBirth.Location = new System.Drawing.Point(0, 275);
            this.PDLDateOfBirth.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.PDLDateOfBirth.Name = "PDLDateOfBirth";
            this.PDLDateOfBirth.Size = new System.Drawing.Size(83, 17);
            this.PDLDateOfBirth.TabIndex = 16;
            this.PDLDateOfBirth.Text = "Date Of Birth";
            // 
            // PDIDateOfBirth
            // 
            this.PDIDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.PDIDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PDIDateOfBirth.Location = new System.Drawing.Point(0, 295);
            this.PDIDateOfBirth.Margin = new System.Windows.Forms.Padding(0);
            this.PDIDateOfBirth.Name = "PDIDateOfBirth";
            this.PDIDateOfBirth.Size = new System.Drawing.Size(400, 25);
            this.PDIDateOfBirth.TabIndex = 21;
            this.PDIDateOfBirth.ValueChanged += new System.EventHandler(this.PDIDateOfBirth_ValueChanged);
            // 
            // PDLEmploymentStatus
            // 
            this.PDLEmploymentStatus.AutoSize = true;
            this.PDLEmploymentStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDLEmploymentStatus.Location = new System.Drawing.Point(0, 330);
            this.PDLEmploymentStatus.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.PDLEmploymentStatus.Name = "PDLEmploymentStatus";
            this.PDLEmploymentStatus.Size = new System.Drawing.Size(119, 17);
            this.PDLEmploymentStatus.TabIndex = 18;
            this.PDLEmploymentStatus.Text = "Employment Status";
            // 
            // PDIEmploymentStatus
            // 
            this.PDIEmploymentStatus.FormattingEnabled = true;
            this.PDIEmploymentStatus.Location = new System.Drawing.Point(0, 350);
            this.PDIEmploymentStatus.Margin = new System.Windows.Forms.Padding(0);
            this.PDIEmploymentStatus.Name = "PDIEmploymentStatus";
            this.PDIEmploymentStatus.Size = new System.Drawing.Size(400, 25);
            this.PDIEmploymentStatus.TabIndex = 22;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.PDBUpdate);
            this.flowLayoutPanel3.Controls.Add(this.PDBReset);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 390);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(400, 27);
            this.flowLayoutPanel3.TabIndex = 20;
            // 
            // PDBUpdate
            // 
            this.PDBUpdate.AutoSize = true;
            this.PDBUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.PDBUpdate.FlatAppearance.BorderSize = 0;
            this.PDBUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.PDBUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.PDBUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDBUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDBUpdate.ForeColor = System.Drawing.Color.White;
            this.PDBUpdate.Location = new System.Drawing.Point(0, 0);
            this.PDBUpdate.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.PDBUpdate.Name = "PDBUpdate";
            this.PDBUpdate.Size = new System.Drawing.Size(75, 27);
            this.PDBUpdate.TabIndex = 6;
            this.PDBUpdate.Text = "Update";
            this.PDBUpdate.UseVisualStyleBackColor = false;
            this.PDBUpdate.Click += new System.EventHandler(this.PDBUpdate_Click);
            // 
            // PDBReset
            // 
            this.PDBReset.AutoSize = true;
            this.PDBReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.PDBReset.FlatAppearance.BorderSize = 0;
            this.PDBReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.PDBReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.PDBReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDBReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDBReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PDBReset.Location = new System.Drawing.Point(80, 0);
            this.PDBReset.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.PDBReset.Name = "PDBReset";
            this.PDBReset.Size = new System.Drawing.Size(75, 27);
            this.PDBReset.TabIndex = 7;
            this.PDBReset.Text = "Reset";
            this.PDBReset.UseVisualStyleBackColor = false;
            this.PDBReset.Click += new System.EventHandler(this.PDBReset_Click);
            // 
            // TabChangePassword
            // 
            this.TabChangePassword.BackColor = System.Drawing.Color.White;
            this.TabChangePassword.Controls.Add(this.PanelChangePassword);
            this.TabChangePassword.Location = new System.Drawing.Point(4, 30);
            this.TabChangePassword.Margin = new System.Windows.Forms.Padding(0);
            this.TabChangePassword.Name = "TabChangePassword";
            this.TabChangePassword.Padding = new System.Windows.Forms.Padding(10);
            this.TabChangePassword.Size = new System.Drawing.Size(811, 654);
            this.TabChangePassword.TabIndex = 1;
            this.TabChangePassword.Text = "Change Password";
            // 
            // PanelChangePassword
            // 
            this.PanelChangePassword.Controls.Add(this.CPLCurrentPassword);
            this.PanelChangePassword.Controls.Add(this.CPICurrentPassword);
            this.PanelChangePassword.Controls.Add(this.CPLNewPassword);
            this.PanelChangePassword.Controls.Add(this.CPINewPassword);
            this.PanelChangePassword.Controls.Add(this.CPLNewPasswordRepeat);
            this.PanelChangePassword.Controls.Add(this.CPINewPasswordRepeat);
            this.PanelChangePassword.Controls.Add(this.flowLayoutPanel1);
            this.PanelChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChangePassword.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelChangePassword.Location = new System.Drawing.Point(10, 10);
            this.PanelChangePassword.Name = "PanelChangePassword";
            this.PanelChangePassword.Size = new System.Drawing.Size(791, 634);
            this.PanelChangePassword.TabIndex = 0;
            // 
            // CPLCurrentPassword
            // 
            this.CPLCurrentPassword.AutoSize = true;
            this.CPLCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPLCurrentPassword.Location = new System.Drawing.Point(0, 0);
            this.CPLCurrentPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.CPLCurrentPassword.Name = "CPLCurrentPassword";
            this.CPLCurrentPassword.Size = new System.Drawing.Size(111, 17);
            this.CPLCurrentPassword.TabIndex = 0;
            this.CPLCurrentPassword.Text = "Current Password";
            // 
            // CPICurrentPassword
            // 
            this.CPICurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPICurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPICurrentPassword.Location = new System.Drawing.Point(0, 20);
            this.CPICurrentPassword.Margin = new System.Windows.Forms.Padding(0);
            this.CPICurrentPassword.MaxLength = 100;
            this.CPICurrentPassword.Name = "CPICurrentPassword";
            this.CPICurrentPassword.Size = new System.Drawing.Size(250, 25);
            this.CPICurrentPassword.TabIndex = 1;
            this.CPICurrentPassword.UseSystemPasswordChar = true;
            this.CPICurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePasswordInput_KeyDown);
            // 
            // CPLNewPassword
            // 
            this.CPLNewPassword.AutoSize = true;
            this.CPLNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPLNewPassword.Location = new System.Drawing.Point(0, 55);
            this.CPLNewPassword.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.CPLNewPassword.Name = "CPLNewPassword";
            this.CPLNewPassword.Size = new System.Drawing.Size(94, 17);
            this.CPLNewPassword.TabIndex = 2;
            this.CPLNewPassword.Text = "New Password";
            // 
            // CPINewPassword
            // 
            this.CPINewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPINewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPINewPassword.Location = new System.Drawing.Point(0, 75);
            this.CPINewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.CPINewPassword.MaxLength = 100;
            this.CPINewPassword.Name = "CPINewPassword";
            this.CPINewPassword.Size = new System.Drawing.Size(250, 25);
            this.CPINewPassword.TabIndex = 3;
            this.CPINewPassword.UseSystemPasswordChar = true;
            this.CPINewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePasswordInput_KeyDown);
            // 
            // CPLNewPasswordRepeat
            // 
            this.CPLNewPasswordRepeat.AutoSize = true;
            this.CPLNewPasswordRepeat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPLNewPasswordRepeat.Location = new System.Drawing.Point(0, 110);
            this.CPLNewPasswordRepeat.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.CPLNewPasswordRepeat.Name = "CPLNewPasswordRepeat";
            this.CPLNewPasswordRepeat.Size = new System.Drawing.Size(147, 17);
            this.CPLNewPasswordRepeat.TabIndex = 4;
            this.CPLNewPasswordRepeat.Text = "New Password (Repeat)";
            // 
            // CPINewPasswordRepeat
            // 
            this.CPINewPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPINewPasswordRepeat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPINewPasswordRepeat.Location = new System.Drawing.Point(0, 130);
            this.CPINewPasswordRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.CPINewPasswordRepeat.MaxLength = 100;
            this.CPINewPasswordRepeat.Name = "CPINewPasswordRepeat";
            this.CPINewPasswordRepeat.Size = new System.Drawing.Size(250, 25);
            this.CPINewPasswordRepeat.TabIndex = 5;
            this.CPINewPasswordRepeat.UseSystemPasswordChar = true;
            this.CPINewPasswordRepeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePasswordInput_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.CPBUpdate);
            this.flowLayoutPanel1.Controls.Add(this.CPBReset);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 170);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 27);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // CPBUpdate
            // 
            this.CPBUpdate.AutoSize = true;
            this.CPBUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.CPBUpdate.FlatAppearance.BorderSize = 0;
            this.CPBUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.CPBUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.CPBUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPBUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPBUpdate.ForeColor = System.Drawing.Color.White;
            this.CPBUpdate.Location = new System.Drawing.Point(0, 0);
            this.CPBUpdate.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.CPBUpdate.Name = "CPBUpdate";
            this.CPBUpdate.Size = new System.Drawing.Size(75, 27);
            this.CPBUpdate.TabIndex = 6;
            this.CPBUpdate.Text = "Update";
            this.CPBUpdate.UseVisualStyleBackColor = false;
            this.CPBUpdate.Click += new System.EventHandler(this.CPBUpdate_Click);
            // 
            // CPBReset
            // 
            this.CPBReset.AutoSize = true;
            this.CPBReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.CPBReset.FlatAppearance.BorderSize = 0;
            this.CPBReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.CPBReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.CPBReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPBReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPBReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CPBReset.Location = new System.Drawing.Point(80, 0);
            this.CPBReset.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.CPBReset.Name = "CPBReset";
            this.CPBReset.Size = new System.Drawing.Size(75, 27);
            this.CPBReset.TabIndex = 7;
            this.CPBReset.Text = "Reset";
            this.CPBReset.UseVisualStyleBackColor = false;
            this.CPBReset.Click += new System.EventHandler(this.CPBReset_Click);
            // 
            // ProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(839, 708);
            this.Controls.Add(this.TabProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Profile";
            this.TabProfile.ResumeLayout(false);
            this.TabProfileDetails.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.TabChangePassword.ResumeLayout(false);
            this.PanelChangePassword.ResumeLayout(false);
            this.PanelChangePassword.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabProfile;
        private System.Windows.Forms.TabPage TabProfileDetails;
        private System.Windows.Forms.TabPage TabChangePassword;
        private System.Windows.Forms.FlowLayoutPanel PanelChangePassword;
        private System.Windows.Forms.Label CPLCurrentPassword;
        private System.Windows.Forms.TextBox CPICurrentPassword;
        private System.Windows.Forms.Label CPLNewPassword;
        private System.Windows.Forms.TextBox CPINewPassword;
        private System.Windows.Forms.Label CPLNewPasswordRepeat;
        private System.Windows.Forms.TextBox CPINewPasswordRepeat;
        private System.Windows.Forms.Button CPBUpdate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CPBReset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label PDLUsername;
        private System.Windows.Forms.TextBox PDIUsername;
        private System.Windows.Forms.Label PDLName;
        private System.Windows.Forms.TextBox PDIName;
        private System.Windows.Forms.Label PDLEmail;
        private System.Windows.Forms.TextBox PDIEmail;
        private System.Windows.Forms.Label PDLContactNumber;
        private System.Windows.Forms.TextBox PDIContactNumber;
        private System.Windows.Forms.Label PDLAddress;
        private System.Windows.Forms.TextBox PDIAddress;
        private System.Windows.Forms.Label PDLDateOfBirth;
        private System.Windows.Forms.Label PDLEmploymentStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button PDBUpdate;
        private System.Windows.Forms.Button PDBReset;
        private System.Windows.Forms.DateTimePicker PDIDateOfBirth;
        private System.Windows.Forms.ComboBox PDIEmploymentStatus;
    }
}