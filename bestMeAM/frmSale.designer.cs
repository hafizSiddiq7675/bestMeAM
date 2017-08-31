namespace bestMeAM
{
    partial class frmSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpMaster = new System.Windows.Forms.GroupBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtInvoiceNo = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRate = new MetroFramework.Controls.MetroTextBox();
            this.txtWeight = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtSr = new MetroFramework.Controls.MetroTextBox();
            this.txtComodity = new MetroFramework.Controls.MetroTextBox();
            this.txtContainerNo = new MetroFramework.Controls.MetroTextBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.srNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comodity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTot = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblContainer = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpMaster.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(30, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1210, 2);
            this.label1.TabIndex = 1;
            // 
            // grpMaster
            // 
            this.grpMaster.BackColor = System.Drawing.Color.White;
            this.grpMaster.Controls.Add(this.dtpInvoiceDate);
            this.grpMaster.Controls.Add(this.cmbCompany);
            this.grpMaster.Controls.Add(this.label3);
            this.grpMaster.Controls.Add(this.label10);
            this.grpMaster.Controls.Add(this.label4);
            this.grpMaster.Controls.Add(this.label2);
            this.grpMaster.Controls.Add(this.txtAddress);
            this.grpMaster.Controls.Add(this.txtInvoiceNo);
            this.grpMaster.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaster.Location = new System.Drawing.Point(34, 105);
            this.grpMaster.Margin = new System.Windows.Forms.Padding(4);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Padding = new System.Windows.Forms.Padding(4);
            this.grpMaster.Size = new System.Drawing.Size(1206, 117);
            this.grpMaster.TabIndex = 2;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "Sale Master";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Checked = false;
            this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(237, 44);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(250, 26);
            this.dtpInvoiceDate.TabIndex = 0;
            this.dtpInvoiceDate.TabStop = false;
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(575, 45);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(250, 27);
            this.cmbCompany.TabIndex = 0;
            this.cmbCompany.TabStop = false;
            this.cmbCompany.SelectionChangeCommitted += new System.EventHandler(this.cmbCompany_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Company";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(233, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(901, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Invoice No";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtAddress.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(905, 46);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(250, 25);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TabStop = false;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInvoiceNo
            // 
            // 
            // 
            // 
            this.txtInvoiceNo.CustomButton.Image = null;
            this.txtInvoiceNo.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtInvoiceNo.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtInvoiceNo.CustomButton.Name = "";
            this.txtInvoiceNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtInvoiceNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNo.CustomButton.TabIndex = 1;
            this.txtInvoiceNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNo.CustomButton.UseSelectable = true;
            this.txtInvoiceNo.CustomButton.Visible = false;
            this.txtInvoiceNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInvoiceNo.Lines = new string[0];
            this.txtInvoiceNo.Location = new System.Drawing.Point(29, 44);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtInvoiceNo.MaxLength = 32767;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.SelectionLength = 0;
            this.txtInvoiceNo.SelectionStart = 0;
            this.txtInvoiceNo.ShortcutsEnabled = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(117, 25);
            this.txtInvoiceNo.TabIndex = 0;
            this.txtInvoiceNo.TabStop = false;
            this.txtInvoiceNo.UseSelectable = true;
            this.txtInvoiceNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtSr);
            this.groupBox1.Controls.Add(this.txtComodity);
            this.groupBox1.Controls.Add(this.txtContainerNo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(279, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Particulars";
            // 
            // btnAdd
            // 
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdd.Location = new System.Drawing.Point(90, 422);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Rate/Ton";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 285);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Weight/Ton";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Sr NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Comodity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 152);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Container No";
            // 
            // txtRate
            // 
            // 
            // 
            // 
            this.txtRate.CustomButton.Image = null;
            this.txtRate.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtRate.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtRate.CustomButton.Name = "";
            this.txtRate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRate.CustomButton.TabIndex = 1;
            this.txtRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRate.CustomButton.UseSelectable = true;
            this.txtRate.CustomButton.Visible = false;
            this.txtRate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRate.Lines = new string[0];
            this.txtRate.Location = new System.Drawing.Point(29, 372);
            this.txtRate.Margin = new System.Windows.Forms.Padding(5);
            this.txtRate.MaxLength = 32767;
            this.txtRate.Name = "txtRate";
            this.txtRate.PasswordChar = '\0';
            this.txtRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRate.SelectedText = "";
            this.txtRate.SelectionLength = 0;
            this.txtRate.SelectionStart = 0;
            this.txtRate.ShortcutsEnabled = true;
            this.txtRate.Size = new System.Drawing.Size(220, 25);
            this.txtRate.TabIndex = 5;
            this.txtRate.UseSelectable = true;
            this.txtRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtWeight
            // 
            // 
            // 
            // 
            this.txtWeight.CustomButton.Image = null;
            this.txtWeight.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtWeight.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtWeight.CustomButton.Name = "";
            this.txtWeight.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWeight.CustomButton.TabIndex = 1;
            this.txtWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeight.CustomButton.UseSelectable = true;
            this.txtWeight.CustomButton.Visible = false;
            this.txtWeight.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtWeight.Lines = new string[0];
            this.txtWeight.Location = new System.Drawing.Point(29, 309);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(5);
            this.txtWeight.MaxLength = 32767;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeight.SelectedText = "";
            this.txtWeight.SelectionLength = 0;
            this.txtWeight.SelectionStart = 0;
            this.txtWeight.ShortcutsEnabled = true;
            this.txtWeight.Size = new System.Drawing.Size(220, 25);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.UseSelectable = true;
            this.txtWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtQuantity.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(29, 242);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(220, 25);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSr
            // 
            // 
            // 
            // 
            this.txtSr.CustomButton.Image = null;
            this.txtSr.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtSr.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtSr.CustomButton.Name = "";
            this.txtSr.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSr.CustomButton.TabIndex = 1;
            this.txtSr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSr.CustomButton.UseSelectable = true;
            this.txtSr.CustomButton.Visible = false;
            this.txtSr.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSr.Lines = new string[0];
            this.txtSr.Location = new System.Drawing.Point(29, 113);
            this.txtSr.Margin = new System.Windows.Forms.Padding(5);
            this.txtSr.MaxLength = 32767;
            this.txtSr.Name = "txtSr";
            this.txtSr.PasswordChar = '\0';
            this.txtSr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSr.SelectedText = "";
            this.txtSr.SelectionLength = 0;
            this.txtSr.SelectionStart = 0;
            this.txtSr.ShortcutsEnabled = true;
            this.txtSr.Size = new System.Drawing.Size(220, 25);
            this.txtSr.TabIndex = 1;
            this.txtSr.UseSelectable = true;
            this.txtSr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtComodity
            // 
            // 
            // 
            // 
            this.txtComodity.CustomButton.Image = null;
            this.txtComodity.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtComodity.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtComodity.CustomButton.Name = "";
            this.txtComodity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtComodity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComodity.CustomButton.TabIndex = 1;
            this.txtComodity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComodity.CustomButton.UseSelectable = true;
            this.txtComodity.CustomButton.Visible = false;
            this.txtComodity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtComodity.Lines = new string[0];
            this.txtComodity.Location = new System.Drawing.Point(29, 48);
            this.txtComodity.Margin = new System.Windows.Forms.Padding(5);
            this.txtComodity.MaxLength = 32767;
            this.txtComodity.Name = "txtComodity";
            this.txtComodity.PasswordChar = '\0';
            this.txtComodity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComodity.SelectedText = "";
            this.txtComodity.SelectionLength = 0;
            this.txtComodity.SelectionStart = 0;
            this.txtComodity.ShortcutsEnabled = true;
            this.txtComodity.Size = new System.Drawing.Size(220, 25);
            this.txtComodity.TabIndex = 1;
            this.txtComodity.UseSelectable = true;
            this.txtComodity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComodity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContainerNo
            // 
            // 
            // 
            // 
            this.txtContainerNo.CustomButton.Image = null;
            this.txtContainerNo.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtContainerNo.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtContainerNo.CustomButton.Name = "";
            this.txtContainerNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtContainerNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContainerNo.CustomButton.TabIndex = 1;
            this.txtContainerNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContainerNo.CustomButton.UseSelectable = true;
            this.txtContainerNo.CustomButton.Visible = false;
            this.txtContainerNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtContainerNo.Lines = new string[0];
            this.txtContainerNo.Location = new System.Drawing.Point(29, 176);
            this.txtContainerNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtContainerNo.MaxLength = 32767;
            this.txtContainerNo.Name = "txtContainerNo";
            this.txtContainerNo.PasswordChar = '\0';
            this.txtContainerNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContainerNo.SelectedText = "";
            this.txtContainerNo.SelectionLength = 0;
            this.txtContainerNo.SelectionStart = 0;
            this.txtContainerNo.ShortcutsEnabled = true;
            this.txtContainerNo.Size = new System.Drawing.Size(220, 25);
            this.txtContainerNo.TabIndex = 2;
            this.txtContainerNo.UseSelectable = true;
            this.txtContainerNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContainerNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srNo,
            this.comodity,
            this.containerNo,
            this.quantity,
            this.weight,
            this.rate,
            this.amount});
            this.dgvDetails.Location = new System.Drawing.Point(325, 245);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(915, 364);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.TabStop = false;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // srNo
            // 
            this.srNo.HeaderText = "Sr No";
            this.srNo.Name = "srNo";
            this.srNo.ReadOnly = true;
            // 
            // comodity
            // 
            this.comodity.DataPropertyName = "comodity";
            this.comodity.HeaderText = "Comodity";
            this.comodity.Name = "comodity";
            this.comodity.ReadOnly = true;
            // 
            // containerNo
            // 
            this.containerNo.DataPropertyName = "containerNo";
            this.containerNo.HeaderText = "Container No";
            this.containerNo.Name = "containerNo";
            this.containerNo.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "[weight/Ton($)]";
            this.weight.HeaderText = "Weight/Ton ($)";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.DataPropertyName = "[rate/Ton($)]";
            this.rate.HeaderText = "Rate/Ton ($)";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.Location = new System.Drawing.Point(367, 615);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save Invoice";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPrint.Location = new System.Drawing.Point(486, 615);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 39);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print Invoice";
            this.btnPrint.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.Location = new System.Drawing.Point(595, 615);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 39);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1086, 621);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total: ";
            // 
            // lbTot
            // 
            this.lbTot.AutoSize = true;
            this.lbTot.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTot.ForeColor = System.Drawing.Color.Red;
            this.lbTot.Location = new System.Drawing.Point(1143, 621);
            this.lbTot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTot.Name = "lbTot";
            this.lbTot.Size = new System.Drawing.Size(0, 21);
            this.lbTot.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1049, 652);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Containers:";
            // 
            // lblContainer
            // 
            this.lblContainer.AutoSize = true;
            this.lblContainer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContainer.ForeColor = System.Drawing.Color.Red;
            this.lblContainer.Location = new System.Drawing.Point(1143, 652);
            this.lblContainer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(0, 21);
            this.lblContainer.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(331, 223);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(0, 19);
            this.lblSearch.TabIndex = 3;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 720);
            this.Controls.Add(this.lblContainer);
            this.Controls.Add(this.lbTot);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSale";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 30);
            this.Text = "Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpMaster.ResumeLayout(false);
            this.grpMaster.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMaster;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtRate;
        private MetroFramework.Controls.MetroTextBox txtWeight;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroTextBox txtContainerNo;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.DataGridView dgvDetails;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtComodity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTot;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comodity;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroTextBox txtSr;
    }
}