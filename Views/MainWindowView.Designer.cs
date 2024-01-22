namespace cms.Views
{
    partial class MainWindowView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowView));
            this.LayoutMenu = new System.Windows.Forms.Panel();
            this.LayoutMenuBottom = new System.Windows.Forms.Panel();
            this.MenuProfile = new FontAwesome.Sharp.IconButton();
            this.MenuLogout = new FontAwesome.Sharp.IconButton();
            this.MenuStaffs = new FontAwesome.Sharp.IconButton();
            this.MenuOrders = new FontAwesome.Sharp.IconButton();
            this.MenuMedications = new FontAwesome.Sharp.IconButton();
            this.MenuPatients = new FontAwesome.Sharp.IconButton();
            this.MenuDoctors = new FontAwesome.Sharp.IconButton();
            this.MenuAppointments = new FontAwesome.Sharp.IconButton();
            this.LayoutPanelLogo = new System.Windows.Forms.Panel();
            this.LayoutMenuLogo = new System.Windows.Forms.PictureBox();
            this.LayoutHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LayoutMinimizeButton = new FontAwesome.Sharp.IconButton();
            this.LayoutMaximiseButton = new FontAwesome.Sharp.IconButton();
            this.LayoutCloseButton = new FontAwesome.Sharp.IconButton();
            this.LayoutTitle = new System.Windows.Forms.Label();
            this.LayoutContent = new System.Windows.Forms.Panel();
            this.imageRenderer1 = new BrightIdeasSoftware.ImageRenderer();
            this.MenuReport = new FontAwesome.Sharp.IconButton();
            this.LayoutMenu.SuspendLayout();
            this.LayoutMenuBottom.SuspendLayout();
            this.LayoutPanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutMenuLogo)).BeginInit();
            this.LayoutHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMenu
            // 
            this.LayoutMenu.BackColor = System.Drawing.Color.White;
            this.LayoutMenu.Controls.Add(this.MenuReport);
            this.LayoutMenu.Controls.Add(this.LayoutMenuBottom);
            this.LayoutMenu.Controls.Add(this.MenuStaffs);
            this.LayoutMenu.Controls.Add(this.MenuOrders);
            this.LayoutMenu.Controls.Add(this.MenuMedications);
            this.LayoutMenu.Controls.Add(this.MenuPatients);
            this.LayoutMenu.Controls.Add(this.MenuDoctors);
            this.LayoutMenu.Controls.Add(this.MenuAppointments);
            this.LayoutMenu.Controls.Add(this.LayoutPanelLogo);
            this.LayoutMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.LayoutMenu.Name = "LayoutMenu";
            this.LayoutMenu.Size = new System.Drawing.Size(165, 768);
            this.LayoutMenu.TabIndex = 0;
            // 
            // LayoutMenuBottom
            // 
            this.LayoutMenuBottom.Controls.Add(this.MenuProfile);
            this.LayoutMenuBottom.Controls.Add(this.MenuLogout);
            this.LayoutMenuBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMenuBottom.Location = new System.Drawing.Point(0, 440);
            this.LayoutMenuBottom.Name = "LayoutMenuBottom";
            this.LayoutMenuBottom.Size = new System.Drawing.Size(165, 328);
            this.LayoutMenuBottom.TabIndex = 10;
            // 
            // MenuProfile
            // 
            this.MenuProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuProfile.FlatAppearance.BorderSize = 0;
            this.MenuProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.MenuProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuProfile.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.MenuProfile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProfile.IconSize = 20;
            this.MenuProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuProfile.Location = new System.Drawing.Point(0, 228);
            this.MenuProfile.Margin = new System.Windows.Forms.Padding(0);
            this.MenuProfile.Name = "MenuProfile";
            this.MenuProfile.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.MenuProfile.Size = new System.Drawing.Size(165, 50);
            this.MenuProfile.TabIndex = 10;
            this.MenuProfile.Text = "Profile";
            this.MenuProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuProfile.UseVisualStyleBackColor = true;
            this.MenuProfile.Click += new System.EventHandler(this.MenuProfile_Click);
            // 
            // MenuLogout
            // 
            this.MenuLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuLogout.FlatAppearance.BorderSize = 0;
            this.MenuLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.MenuLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.MenuLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuLogout.IconSize = 20;
            this.MenuLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuLogout.Location = new System.Drawing.Point(0, 278);
            this.MenuLogout.Margin = new System.Windows.Forms.Padding(0);
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.MenuLogout.Size = new System.Drawing.Size(165, 50);
            this.MenuLogout.TabIndex = 9;
            this.MenuLogout.Text = "Logout";
            this.MenuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuLogout.UseVisualStyleBackColor = true;
            this.MenuLogout.Click += new System.EventHandler(this.MenuLogout_Click);
            // 
            // MenuStaffs
            // 
            this.MenuStaffs.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuStaffs.FlatAppearance.BorderSize = 0;
            this.MenuStaffs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.MenuStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuStaffs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStaffs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuStaffs.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.MenuStaffs.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuStaffs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuStaffs.IconSize = 20;
            this.MenuStaffs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuStaffs.Location = new System.Drawing.Point(0, 390);
            this.MenuStaffs.Margin = new System.Windows.Forms.Padding(0);
            this.MenuStaffs.Name = "MenuStaffs";
            this.MenuStaffs.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.MenuStaffs.Size = new System.Drawing.Size(165, 50);
            this.MenuStaffs.TabIndex = 8;
            this.MenuStaffs.Text = "Staffs";
            this.MenuStaffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuStaffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuStaffs.UseVisualStyleBackColor = true;
            this.MenuStaffs.Click += new System.EventHandler(this.MenuStaffs_Click);
            // 
            // MenuOrders
            // 
            this.MenuOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuOrders.FlatAppearance.BorderSize = 0;
            this.MenuOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.MenuOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuOrders.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuOrders.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.MenuOrders.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuOrders.IconSize = 20;
            this.MenuOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuOrders.Location = new System.Drawing.Point(0, 340);
            this.MenuOrders.Margin = new System.Windows.Forms.Padding(0);
            this.MenuOrders.Name = "MenuOrders";
            this.MenuOrders.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.MenuOrders.Size = new System.Drawing.Size(165, 50);
            this.MenuOrders.TabIndex = 7;
            this.MenuOrders.Text = "Orders";
            this.MenuOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuOrders.UseVisualStyleBackColor = true;
            this.MenuOrders.Click += new System.EventHandler(this.MenuOrders_Click);
            // 
            // MenuMedications
            // 
            this.MenuMedications.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuMedications.FlatAppearance.BorderSize = 0;
            this.MenuMedications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.MenuMedications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuMedications.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMedications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuMedications.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.MenuMedications.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuMedications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMedications.IconSize = 20;
            this.MenuMedications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuMedications.Location = new System.Drawing.Point(0, 290);
            this.MenuMedications.Margin = new System.Windows.Forms.Padding(0);
            this.MenuMedications.Name = "MenuMedications";
            this.MenuMedications.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.MenuMedications.Size = new System.Drawing.Size(165, 50);
            this.MenuMedications.TabIndex = 6;
            this.MenuMedications.Text = "Medications";
            this.MenuMedications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuMedications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuMedications.UseVisualStyleBackColor = true;
            this.MenuMedications.Click += new System.EventHandler(this.MenuMedications_Click);
            // 
            // MenuPatients
            // 
            this.MenuPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPatients.FlatAppearance.BorderSize = 0;
            this.MenuPatients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.MenuPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuPatients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPatients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuPatients.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.MenuPatients.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuPatients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuPatients.IconSize = 20;
            this.MenuPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuPatients.Location = new System.Drawing.Point(0, 240);
            this.MenuPatients.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPatients.Name = "MenuPatients";
            this.MenuPatients.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.MenuPatients.Size = new System.Drawing.Size(165, 50);
            this.MenuPatients.TabIndex = 5;
            this.MenuPatients.Text = "Patients";
            this.MenuPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuPatients.UseVisualStyleBackColor = true;
            this.MenuPatients.Click += new System.EventHandler(this.MenuPatients_Click);
            // 
            // MenuDoctors
            // 
            this.MenuDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuDoctors.FlatAppearance.BorderSize = 0;
            this.MenuDoctors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.MenuDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuDoctors.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDoctors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuDoctors.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.MenuDoctors.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuDoctors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuDoctors.IconSize = 20;
            this.MenuDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuDoctors.Location = new System.Drawing.Point(0, 190);
            this.MenuDoctors.Margin = new System.Windows.Forms.Padding(0);
            this.MenuDoctors.Name = "MenuDoctors";
            this.MenuDoctors.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.MenuDoctors.Size = new System.Drawing.Size(165, 50);
            this.MenuDoctors.TabIndex = 4;
            this.MenuDoctors.Text = "Doctors";
            this.MenuDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuDoctors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuDoctors.UseVisualStyleBackColor = true;
            this.MenuDoctors.Click += new System.EventHandler(this.MenuDoctors_Click);
            // 
            // MenuAppointments
            // 
            this.MenuAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuAppointments.FlatAppearance.BorderSize = 0;
            this.MenuAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.MenuAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuAppointments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuAppointments.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.MenuAppointments.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuAppointments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAppointments.IconSize = 20;
            this.MenuAppointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuAppointments.Location = new System.Drawing.Point(0, 140);
            this.MenuAppointments.Margin = new System.Windows.Forms.Padding(0);
            this.MenuAppointments.Name = "MenuAppointments";
            this.MenuAppointments.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.MenuAppointments.Size = new System.Drawing.Size(165, 50);
            this.MenuAppointments.TabIndex = 3;
            this.MenuAppointments.Text = "Appointments";
            this.MenuAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuAppointments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuAppointments.UseVisualStyleBackColor = true;
            this.MenuAppointments.Click += new System.EventHandler(this.MenuAppointments_Click);
            // 
            // LayoutPanelLogo
            // 
            this.LayoutPanelLogo.Controls.Add(this.LayoutMenuLogo);
            this.LayoutPanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutPanelLogo.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutPanelLogo.Name = "LayoutPanelLogo";
            this.LayoutPanelLogo.Size = new System.Drawing.Size(165, 140);
            this.LayoutPanelLogo.TabIndex = 2;
            // 
            // LayoutMenuLogo
            // 
            this.LayoutMenuLogo.Image = global::cms.Properties.Resources.medical_care;
            this.LayoutMenuLogo.Location = new System.Drawing.Point(0, 40);
            this.LayoutMenuLogo.Name = "LayoutMenuLogo";
            this.LayoutMenuLogo.Size = new System.Drawing.Size(165, 65);
            this.LayoutMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LayoutMenuLogo.TabIndex = 1;
            this.LayoutMenuLogo.TabStop = false;
            // 
            // LayoutHeader
            // 
            this.LayoutHeader.Controls.Add(this.panel1);
            this.LayoutHeader.Controls.Add(this.LayoutTitle);
            this.LayoutHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutHeader.Location = new System.Drawing.Point(165, 0);
            this.LayoutHeader.Name = "LayoutHeader";
            this.LayoutHeader.Padding = new System.Windows.Forms.Padding(10);
            this.LayoutHeader.Size = new System.Drawing.Size(859, 40);
            this.LayoutHeader.TabIndex = 1;
            this.LayoutHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LayoutHeader_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LayoutMinimizeButton);
            this.panel1.Controls.Add(this.LayoutMaximiseButton);
            this.panel1.Controls.Add(this.LayoutCloseButton);
            this.panel1.Location = new System.Drawing.Point(757, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 24);
            this.panel1.TabIndex = 1;
            // 
            // LayoutMinimizeButton
            // 
            this.LayoutMinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LayoutMinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LayoutMinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LayoutMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayoutMinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.LayoutMinimizeButton.IconColor = System.Drawing.Color.Gray;
            this.LayoutMinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LayoutMinimizeButton.IconSize = 14;
            this.LayoutMinimizeButton.Location = new System.Drawing.Point(18, 0);
            this.LayoutMinimizeButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LayoutMinimizeButton.Name = "LayoutMinimizeButton";
            this.LayoutMinimizeButton.Size = new System.Drawing.Size(24, 24);
            this.LayoutMinimizeButton.TabIndex = 2;
            this.LayoutMinimizeButton.UseVisualStyleBackColor = false;
            this.LayoutMinimizeButton.Click += new System.EventHandler(this.LayoutMinimizeButton_Click);
            // 
            // LayoutMaximiseButton
            // 
            this.LayoutMaximiseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LayoutMaximiseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LayoutMaximiseButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LayoutMaximiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayoutMaximiseButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.LayoutMaximiseButton.IconColor = System.Drawing.Color.Gray;
            this.LayoutMaximiseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LayoutMaximiseButton.IconSize = 14;
            this.LayoutMaximiseButton.Location = new System.Drawing.Point(42, 0);
            this.LayoutMaximiseButton.Name = "LayoutMaximiseButton";
            this.LayoutMaximiseButton.Size = new System.Drawing.Size(24, 24);
            this.LayoutMaximiseButton.TabIndex = 1;
            this.LayoutMaximiseButton.UseVisualStyleBackColor = false;
            this.LayoutMaximiseButton.Click += new System.EventHandler(this.LayoutMaximiseButton_Click);
            // 
            // LayoutCloseButton
            // 
            this.LayoutCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LayoutCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LayoutCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LayoutCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LayoutCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayoutCloseButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.LayoutCloseButton.IconColor = System.Drawing.Color.Gray;
            this.LayoutCloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LayoutCloseButton.IconSize = 14;
            this.LayoutCloseButton.Location = new System.Drawing.Point(66, 0);
            this.LayoutCloseButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LayoutCloseButton.Name = "LayoutCloseButton";
            this.LayoutCloseButton.Size = new System.Drawing.Size(24, 24);
            this.LayoutCloseButton.TabIndex = 0;
            this.LayoutCloseButton.UseVisualStyleBackColor = false;
            this.LayoutCloseButton.Click += new System.EventHandler(this.LayoutCloseButton_Click);
            // 
            // LayoutTitle
            // 
            this.LayoutTitle.AutoSize = true;
            this.LayoutTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutTitle.Location = new System.Drawing.Point(10, 6);
            this.LayoutTitle.Name = "LayoutTitle";
            this.LayoutTitle.Size = new System.Drawing.Size(117, 28);
            this.LayoutTitle.TabIndex = 0;
            this.LayoutTitle.Text = "Header Title";
            this.LayoutTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LayoutContent
            // 
            this.LayoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutContent.Location = new System.Drawing.Point(165, 40);
            this.LayoutContent.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutContent.Name = "LayoutContent";
            this.LayoutContent.Padding = new System.Windows.Forms.Padding(10);
            this.LayoutContent.Size = new System.Drawing.Size(859, 728);
            this.LayoutContent.TabIndex = 2;
            // 
            // MenuReport
            // 
            this.MenuReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuReport.FlatAppearance.BorderSize = 0;
            this.MenuReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.MenuReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.MenuReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReport.IconSize = 20;
            this.MenuReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuReport.Location = new System.Drawing.Point(0, 440);
            this.MenuReport.Margin = new System.Windows.Forms.Padding(0);
            this.MenuReport.Name = "MenuReport";
            this.MenuReport.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.MenuReport.Size = new System.Drawing.Size(165, 50);
            this.MenuReport.TabIndex = 11;
            this.MenuReport.Text = "Reports";
            this.MenuReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuReport.UseVisualStyleBackColor = true;
            this.MenuReport.Click += new System.EventHandler(this.MenuReport_Click);
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.LayoutContent);
            this.Controls.Add(this.LayoutHeader);
            this.Controls.Add(this.LayoutMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management System";
            this.LayoutMenu.ResumeLayout(false);
            this.LayoutMenuBottom.ResumeLayout(false);
            this.LayoutPanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LayoutMenuLogo)).EndInit();
            this.LayoutHeader.ResumeLayout(false);
            this.LayoutHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LayoutMenu;
        private System.Windows.Forms.PictureBox LayoutMenuLogo;
        private System.Windows.Forms.Panel LayoutPanelLogo;
        private FontAwesome.Sharp.IconButton MenuAppointments;
        private FontAwesome.Sharp.IconButton MenuOrders;
        private FontAwesome.Sharp.IconButton MenuMedications;
        private FontAwesome.Sharp.IconButton MenuPatients;
        private FontAwesome.Sharp.IconButton MenuDoctors;
        private System.Windows.Forms.Panel LayoutMenuBottom;
        private FontAwesome.Sharp.IconButton MenuStaffs;
        private FontAwesome.Sharp.IconButton MenuLogout;
        private FontAwesome.Sharp.IconButton MenuProfile;
        private System.Windows.Forms.Panel LayoutHeader;
        private System.Windows.Forms.Label LayoutTitle;
        private System.Windows.Forms.Panel LayoutContent;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton LayoutCloseButton;
        private FontAwesome.Sharp.IconButton LayoutMinimizeButton;
        private FontAwesome.Sharp.IconButton LayoutMaximiseButton;
        private BrightIdeasSoftware.ImageRenderer imageRenderer1;
        private FontAwesome.Sharp.IconButton MenuReport;
    }
}