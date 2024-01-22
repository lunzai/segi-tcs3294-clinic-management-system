namespace cms.Views
{
    partial class MedicationFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationFormView));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FormTitle = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelUnitPrice = new System.Windows.Forms.Label();
            this.LabelSellingPrice = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.InputCategory = new System.Windows.Forms.ComboBox();
            this.InputUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.InputSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FormTitle);
            this.flowLayoutPanel1.Controls.Add(this.LabelName);
            this.flowLayoutPanel1.Controls.Add(this.InputName);
            this.flowLayoutPanel1.Controls.Add(this.LabelCategory);
            this.flowLayoutPanel1.Controls.Add(this.InputCategory);
            this.flowLayoutPanel1.Controls.Add(this.LabelUnitPrice);
            this.flowLayoutPanel1.Controls.Add(this.InputUnitPrice);
            this.flowLayoutPanel1.Controls.Add(this.LabelSellingPrice);
            this.flowLayoutPanel1.Controls.Add(this.InputSellingPrice);
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
            this.InputName.Tag = "";
            this.InputName.TextChanged += new System.EventHandler(this.InputTextBox_Changed);
            this.InputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategory.Location = new System.Drawing.Point(0, 96);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(61, 17);
            this.LabelCategory.TabIndex = 4;
            this.LabelCategory.Text = "Category";
            // 
            // LabelUnitPrice
            // 
            this.LabelUnitPrice.AutoSize = true;
            this.LabelUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnitPrice.Location = new System.Drawing.Point(0, 151);
            this.LabelUnitPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelUnitPrice.Name = "LabelUnitPrice";
            this.LabelUnitPrice.Size = new System.Drawing.Size(102, 17);
            this.LabelUnitPrice.TabIndex = 6;
            this.LabelUnitPrice.Text = "Unit Price (MYR)";
            // 
            // LabelSellingPrice
            // 
            this.LabelSellingPrice.AutoSize = true;
            this.LabelSellingPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSellingPrice.Location = new System.Drawing.Point(0, 206);
            this.LabelSellingPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelSellingPrice.Name = "LabelSellingPrice";
            this.LabelSellingPrice.Size = new System.Drawing.Size(117, 17);
            this.LabelSellingPrice.TabIndex = 8;
            this.LabelSellingPrice.Text = "Selling Price (MYR)";
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
            this.BtnSave.TabIndex = 100;
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
            this.BtnCancel.TabIndex = 110;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // InputCategory
            // 
            this.InputCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCategory.FormattingEnabled = true;
            this.InputCategory.Items.AddRange(new object[] {
            "Apex Pharmacy Marketing Sdn Bhd",
            "Pharmex Sdn Bhd",
            "Zuellig Pharma Sdn Bhd",
            "CCM Pharmaceuticals Sdn Bhd",
            "Germax Sdn Bhd",
            "Borneo Pharmacy Supplies Sdn Bhd"});
            this.InputCategory.Location = new System.Drawing.Point(0, 116);
            this.InputCategory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputCategory.Name = "InputCategory";
            this.InputCategory.Size = new System.Drawing.Size(400, 25);
            this.InputCategory.TabIndex = 11;
            this.InputCategory.SelectedIndexChanged += new System.EventHandler(this.InputCategory_SelectedIndexChanged);
            // 
            // InputUnitPrice
            // 
            this.InputUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUnitPrice.DecimalPlaces = 2;
            this.InputUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUnitPrice.Location = new System.Drawing.Point(0, 171);
            this.InputUnitPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputUnitPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.InputUnitPrice.Name = "InputUnitPrice";
            this.InputUnitPrice.Size = new System.Drawing.Size(400, 25);
            this.InputUnitPrice.TabIndex = 16;
            this.InputUnitPrice.ValueChanged += new System.EventHandler(this.Input_ValueChanged);
            // 
            // InputSellingPrice
            // 
            this.InputSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputSellingPrice.DecimalPlaces = 2;
            this.InputSellingPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSellingPrice.Location = new System.Drawing.Point(0, 226);
            this.InputSellingPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputSellingPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.InputSellingPrice.Name = "InputSellingPrice";
            this.InputSellingPrice.Size = new System.Drawing.Size(400, 25);
            this.InputSellingPrice.TabIndex = 17;
            this.InputSellingPrice.ValueChanged += new System.EventHandler(this.Input_ValueChanged);
            // 
            // MedicationFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 465);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicationFormView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medication";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputSellingPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelUnitPrice;
        private System.Windows.Forms.Label LabelSellingPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox InputCategory;
        private System.Windows.Forms.NumericUpDown InputUnitPrice;
        private System.Windows.Forms.NumericUpDown InputSellingPrice;
    }
}