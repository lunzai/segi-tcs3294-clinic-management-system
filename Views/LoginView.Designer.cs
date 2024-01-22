namespace cms.Views
{
    partial class LoginView
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
            this.components = new System.ComponentModel.Container();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.IconHelp = new FontAwesome.Sharp.IconPictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnHelp = new FontAwesome.Sharp.IconButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconHelp)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputUsername
            // 
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.Location = new System.Drawing.Point(0, 67);
            this.InputUsername.Margin = new System.Windows.Forms.Padding(0);
            this.InputUsername.MaxLength = 50;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(300, 25);
            this.InputUsername.TabIndex = 0;
            this.InputUsername.TextChanged += new System.EventHandler(this.InputUsername_TextChanged);
            this.InputUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(0, 47);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(77, 17);
            this.LabelUsername.TabIndex = 1;
            this.LabelUsername.Text = "USERNAME";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(0, 102);
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
            this.InputPassword.Location = new System.Drawing.Point(0, 122);
            this.InputPassword.Margin = new System.Windows.Forms.Padding(0);
            this.InputPassword.MaxLength = 100;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(300, 25);
            this.InputPassword.TabIndex = 2;
            this.InputPassword.UseSystemPasswordChar = true;
            this.InputPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.LabelUsername);
            this.flowLayoutPanel1.Controls.Add(this.InputUsername);
            this.flowLayoutPanel1.Controls.Add(this.LabelPassword);
            this.flowLayoutPanel1.Controls.Add(this.InputPassword);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(100, 150);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 285);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.BtnLogin);
            this.flowLayoutPanel2.Controls.Add(this.BtnRegister);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 162);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(300, 29);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(0, 0);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnLogin.Size = new System.Drawing.Size(85, 29);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.AutoSize = true;
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRegister.Location = new System.Drawing.Point(90, 0);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnRegister.Size = new System.Drawing.Size(88, 29);
            this.BtnRegister.TabIndex = 1;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // IconHelp
            // 
            this.IconHelp.BackColor = System.Drawing.Color.White;
            this.IconHelp.ForeColor = System.Drawing.Color.DarkGray;
            this.IconHelp.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.IconHelp.IconColor = System.Drawing.Color.DarkGray;
            this.IconHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconHelp.IconSize = 24;
            this.IconHelp.Location = new System.Drawing.Point(312, 411);
            this.IconHelp.Margin = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.IconHelp.Name = "IconHelp";
            this.IconHelp.Size = new System.Drawing.Size(24, 24);
            this.IconHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconHelp.TabIndex = 2;
            this.IconHelp.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.BtnHelp);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(183, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.MinimumSize = new System.Drawing.Size(30, 29);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(117, 29);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.BtnHelp.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHelp.IconSize = 24;
            this.BtnHelp.Location = new System.Drawing.Point(88, 0);
            this.BtnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(29, 29);
            this.BtnHelp.TabIndex = 0;
            this.BtnHelp.UseVisualStyleBackColor = false;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 60000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ToolTip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.IsBalloon = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.ToolTipTitle = "Test Accounts";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 576);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.IconHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(500, 576);
            this.MinimumSize = new System.Drawing.Size(500, 576);
            this.Name = "LoginView";
            this.Padding = new System.Windows.Forms.Padding(100, 50, 100, 50);
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconHelp)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegister;
        private FontAwesome.Sharp.IconPictureBox IconHelp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private FontAwesome.Sharp.IconButton BtnHelp;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}