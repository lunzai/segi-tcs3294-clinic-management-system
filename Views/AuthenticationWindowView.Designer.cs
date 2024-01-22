namespace cms.Views
{
    partial class AuthenticationWindowView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationWindowView));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelControlButton = new System.Windows.Forms.Panel();
            this.LayoutMinimizeButton = new FontAwesome.Sharp.IconButton();
            this.LayoutCloseButton = new FontAwesome.Sharp.IconButton();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelControlButton.SuspendLayout();
            this.PanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.PanelLeft.Controls.Add(this.AppName);
            this.PanelLeft.Controls.Add(this.pictureBox1);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(300, 600);
            this.PanelLeft.TabIndex = 0;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Location = new System.Drawing.Point(41, 249);
            this.AppName.MaximumSize = new System.Drawing.Size(300, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(218, 135);
            this.AppName.TabIndex = 1;
            this.AppName.Text = "Clinic Management System";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::cms.Properties.Resources.medical_care;
            this.pictureBox1.InitialImage = global::cms.Properties.Resources.medical_care;
            this.pictureBox1.Location = new System.Drawing.Point(72, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelControlButton
            // 
            this.PanelControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelControlButton.Controls.Add(this.LayoutMinimizeButton);
            this.PanelControlButton.Controls.Add(this.LayoutCloseButton);
            this.PanelControlButton.Location = new System.Drawing.Point(752, 0);
            this.PanelControlButton.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControlButton.Name = "PanelControlButton";
            this.PanelControlButton.Size = new System.Drawing.Size(48, 24);
            this.PanelControlButton.TabIndex = 2;
            // 
            // LayoutMinimizeButton
            // 
            this.LayoutMinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.LayoutMinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LayoutMinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LayoutMinimizeButton.FlatAppearance.BorderSize = 0;
            this.LayoutMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayoutMinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.LayoutMinimizeButton.IconColor = System.Drawing.Color.Gray;
            this.LayoutMinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LayoutMinimizeButton.IconSize = 14;
            this.LayoutMinimizeButton.Location = new System.Drawing.Point(0, 0);
            this.LayoutMinimizeButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LayoutMinimizeButton.Name = "LayoutMinimizeButton";
            this.LayoutMinimizeButton.Size = new System.Drawing.Size(24, 24);
            this.LayoutMinimizeButton.TabIndex = 2;
            this.LayoutMinimizeButton.UseVisualStyleBackColor = false;
            this.LayoutMinimizeButton.Click += new System.EventHandler(this.LayoutMinimizeButton_Click);
            // 
            // LayoutCloseButton
            // 
            this.LayoutCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.LayoutCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LayoutCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LayoutCloseButton.FlatAppearance.BorderSize = 0;
            this.LayoutCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LayoutCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayoutCloseButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.LayoutCloseButton.IconColor = System.Drawing.Color.Gray;
            this.LayoutCloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LayoutCloseButton.IconSize = 14;
            this.LayoutCloseButton.Location = new System.Drawing.Point(24, 0);
            this.LayoutCloseButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LayoutCloseButton.Name = "LayoutCloseButton";
            this.LayoutCloseButton.Size = new System.Drawing.Size(24, 24);
            this.LayoutCloseButton.TabIndex = 0;
            this.LayoutCloseButton.UseVisualStyleBackColor = false;
            this.LayoutCloseButton.Click += new System.EventHandler(this.LayoutCloseButton_Click);
            // 
            // PanelRight
            // 
            this.PanelRight.Controls.Add(this.PanelContent);
            this.PanelRight.Controls.Add(this.PanelHeader);
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRight.Location = new System.Drawing.Point(300, 0);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(500, 600);
            this.PanelRight.TabIndex = 3;
            // 
            // PanelContent
            // 
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 24);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(500, 576);
            this.PanelContent.TabIndex = 1;
            // 
            // PanelHeader
            // 
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(500, 24);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // AuthenticationWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.PanelControlButton);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AuthenticationWindowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management System";
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelControlButton.ResumeLayout(false);
            this.PanelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelControlButton;
        private FontAwesome.Sharp.IconButton LayoutMinimizeButton;
        private FontAwesome.Sharp.IconButton LayoutCloseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Panel PanelHeader;
    }
}