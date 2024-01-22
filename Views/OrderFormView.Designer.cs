namespace cms.Views
{
    partial class OrderFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFormView));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FormTitle = new System.Windows.Forms.Label();
            this.LabelSupplierName = new System.Windows.Forms.Label();
            this.InputSupplierName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputMedication = new System.Windows.Forms.ComboBox();
            this.LabelQty = new System.Windows.Forms.Label();
            this.InputQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.InputUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.InputTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTotalPrice)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FormTitle);
            this.flowLayoutPanel1.Controls.Add(this.LabelSupplierName);
            this.flowLayoutPanel1.Controls.Add(this.InputSupplierName);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.InputMedication);
            this.flowLayoutPanel1.Controls.Add(this.LabelQty);
            this.flowLayoutPanel1.Controls.Add(this.InputQty);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.InputUnitPrice);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.InputTotalPrice);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 445);
            this.flowLayoutPanel1.TabIndex = 1;
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
            // LabelSupplierName
            // 
            this.LabelSupplierName.AutoSize = true;
            this.LabelSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSupplierName.Location = new System.Drawing.Point(0, 41);
            this.LabelSupplierName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelSupplierName.Name = "LabelSupplierName";
            this.LabelSupplierName.Size = new System.Drawing.Size(95, 17);
            this.LabelSupplierName.TabIndex = 2;
            this.LabelSupplierName.Text = "Supplier Name";
            // 
            // InputSupplierName
            // 
            this.InputSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSupplierName.FormattingEnabled = true;
            this.InputSupplierName.Items.AddRange(new object[] {
            "Apex Pharmacy Marketing Sdn Bhd",
            "Pharmex Sdn Bhd",
            "Zuellig Pharma Sdn Bhd",
            "CCM Pharmaceuticals Sdn Bhd",
            "Germax Sdn Bhd",
            "Borneo Pharmacy Supplies Sdn Bhd"});
            this.InputSupplierName.Location = new System.Drawing.Point(0, 61);
            this.InputSupplierName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputSupplierName.Name = "InputSupplierName";
            this.InputSupplierName.Size = new System.Drawing.Size(400, 25);
            this.InputSupplierName.TabIndex = 5;
            this.InputSupplierName.SelectedValueChanged += new System.EventHandler(this.InputSupplierName_SelectedValueChanged);
            this.InputSupplierName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Medication";
            // 
            // InputMedication
            // 
            this.InputMedication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputMedication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMedication.FormattingEnabled = true;
            this.InputMedication.Location = new System.Drawing.Point(0, 116);
            this.InputMedication.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputMedication.Name = "InputMedication";
            this.InputMedication.Size = new System.Drawing.Size(400, 25);
            this.InputMedication.TabIndex = 12;
            this.InputMedication.SelectedValueChanged += new System.EventHandler(this.InputMedication_SelectedValueChanged);
            this.InputMedication.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // LabelQty
            // 
            this.LabelQty.AutoSize = true;
            this.LabelQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQty.Location = new System.Drawing.Point(0, 151);
            this.LabelQty.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelQty.Name = "LabelQty";
            this.LabelQty.Size = new System.Drawing.Size(56, 17);
            this.LabelQty.TabIndex = 13;
            this.LabelQty.Text = "Quantity";
            // 
            // InputQty
            // 
            this.InputQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputQty.Location = new System.Drawing.Point(0, 171);
            this.InputQty.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.InputQty.Name = "InputQty";
            this.InputQty.Size = new System.Drawing.Size(400, 25);
            this.InputQty.TabIndex = 13;
            this.InputQty.ValueChanged += new System.EventHandler(this.InputQtyUnitPrice_ValueChanged);
            this.InputQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputQtyUnitPrice_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Unit Price (MYR)";
            // 
            // InputUnitPrice
            // 
            this.InputUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUnitPrice.DecimalPlaces = 2;
            this.InputUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUnitPrice.Location = new System.Drawing.Point(0, 226);
            this.InputUnitPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputUnitPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.InputUnitPrice.Name = "InputUnitPrice";
            this.InputUnitPrice.Size = new System.Drawing.Size(400, 25);
            this.InputUnitPrice.TabIndex = 15;
            this.InputUnitPrice.ValueChanged += new System.EventHandler(this.InputQtyUnitPrice_ValueChanged);
            this.InputUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputQtyUnitPrice_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total Price (MYR)";
            // 
            // InputTotalPrice
            // 
            this.InputTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTotalPrice.DecimalPlaces = 2;
            this.InputTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTotalPrice.Location = new System.Drawing.Point(0, 281);
            this.InputTotalPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InputTotalPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.InputTotalPrice.Name = "InputTotalPrice";
            this.InputTotalPrice.ReadOnly = true;
            this.InputTotalPrice.Size = new System.Drawing.Size(400, 25);
            this.InputTotalPrice.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.BtnSave);
            this.flowLayoutPanel3.Controls.Add(this.BtnCancel);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 326);
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
            // OrderFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 465);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderFormView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTotalPrice)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label LabelSupplierName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox InputMedication;
        private System.Windows.Forms.Label LabelQty;
        private System.Windows.Forms.NumericUpDown InputQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown InputUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown InputTotalPrice;
        private System.Windows.Forms.ComboBox InputSupplierName;
    }
}