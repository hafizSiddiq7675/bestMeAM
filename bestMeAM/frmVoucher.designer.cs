namespace bestMeAM
{
    partial class frmVoucher
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
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new MetroFramework.Controls.MetroTextBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.btnCr = new MetroFramework.Controls.MetroButton();
            this.btnDr = new MetroFramework.Controls.MetroButton();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAmt = new MetroFramework.Controls.MetroTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.accountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.lblDr = new System.Windows.Forms.Label();
            this.lblCr = new System.Windows.Forms.Label();
            this.grpMaster.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(30, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1225, 2);
            this.label1.TabIndex = 4;
            // 
            // grpMaster
            // 
            this.grpMaster.BackColor = System.Drawing.Color.White;
            this.grpMaster.Controls.Add(this.dtpVoucherDate);
            this.grpMaster.Controls.Add(this.cmbVtype);
            this.grpMaster.Controls.Add(this.label3);
            this.grpMaster.Controls.Add(this.label10);
            this.grpMaster.Controls.Add(this.label2);
            this.grpMaster.Controls.Add(this.txtVoucherNo);
            this.grpMaster.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaster.Location = new System.Drawing.Point(30, 94);
            this.grpMaster.Margin = new System.Windows.Forms.Padding(4);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Padding = new System.Windows.Forms.Padding(4);
            this.grpMaster.Size = new System.Drawing.Size(1206, 117);
            this.grpMaster.TabIndex = 5;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "Voucher";
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.Checked = false;
            this.dtpVoucherDate.CustomFormat = "dd/MM/yyyy";
            this.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoucherDate.Location = new System.Drawing.Point(469, 44);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(250, 26);
            this.dtpVoucherDate.TabIndex = 0;
            this.dtpVoucherDate.TabStop = false;
            this.dtpVoucherDate.Value = new System.DateTime(2017, 9, 4, 0, 0, 0, 0);
            // 
            // cmbVtype
            // 
            this.cmbVtype.FormattingEnabled = true;
            this.cmbVtype.Items.AddRange(new object[] {
            "Cash Payment",
            "Cash Receipt",
            "Bank Payment",
            "Bank Receipt",
            "Journal"});
            this.cmbVtype.Location = new System.Drawing.Point(858, 45);
            this.cmbVtype.Name = "cmbVtype";
            this.cmbVtype.Size = new System.Drawing.Size(250, 27);
            this.cmbVtype.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(854, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Voucher Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(465, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Voucher No";
            // 
            // txtVoucherNo
            // 
            // 
            // 
            // 
            this.txtVoucherNo.CustomButton.Image = null;
            this.txtVoucherNo.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtVoucherNo.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtVoucherNo.CustomButton.Name = "";
            this.txtVoucherNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtVoucherNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVoucherNo.CustomButton.TabIndex = 1;
            this.txtVoucherNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVoucherNo.CustomButton.UseSelectable = true;
            this.txtVoucherNo.CustomButton.Visible = false;
            this.txtVoucherNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtVoucherNo.Lines = new string[0];
            this.txtVoucherNo.Location = new System.Drawing.Point(79, 44);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtVoucherNo.MaxLength = 32767;
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.PasswordChar = '\0';
            this.txtVoucherNo.ReadOnly = true;
            this.txtVoucherNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVoucherNo.SelectedText = "";
            this.txtVoucherNo.SelectionLength = 0;
            this.txtVoucherNo.SelectionStart = 0;
            this.txtVoucherNo.ShortcutsEnabled = true;
            this.txtVoucherNo.Size = new System.Drawing.Size(250, 25);
            this.txtVoucherNo.TabIndex = 0;
            this.txtVoucherNo.TabStop = false;
            this.txtVoucherNo.UseSelectable = true;
            this.txtVoucherNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVoucherNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.White;
            this.grpDetails.Controls.Add(this.cmbAccount);
            this.grpDetails.Controls.Add(this.btnCr);
            this.grpDetails.Controls.Add(this.btnDr);
            this.grpDetails.Controls.Add(this.txtDesc);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label6);
            this.grpDetails.Controls.Add(this.label13);
            this.grpDetails.Controls.Add(this.txtAmt);
            this.grpDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(34, 219);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetails.Size = new System.Drawing.Size(279, 373);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Voucher Details";
            // 
            // cmbAccount
            // 
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(29, 46);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(220, 27);
            this.cmbAccount.TabIndex = 2;
            // 
            // btnCr
            // 
            this.btnCr.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCr.Location = new System.Drawing.Point(147, 289);
            this.btnCr.Name = "btnCr";
            this.btnCr.Size = new System.Drawing.Size(83, 35);
            this.btnCr.TabIndex = 6;
            this.btnCr.Text = "&Credit";
            this.btnCr.UseSelectable = true;
            this.btnCr.Click += new System.EventHandler(this.btnCr_Click);
            // 
            // btnDr
            // 
            this.btnDr.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDr.Location = new System.Drawing.Point(43, 289);
            this.btnDr.Name = "btnDr";
            this.btnDr.Size = new System.Drawing.Size(83, 35);
            this.btnDr.TabIndex = 5;
            this.btnDr.Text = "&Debit";
            this.btnDr.UseSelectable = true;
            this.btnDr.Click += new System.EventHandler(this.btnDr_Click);
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtDesc.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(29, 113);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(220, 100);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Description";
            // 
            // txtAmt
            // 
            // 
            // 
            // 
            this.txtAmt.CustomButton.Image = null;
            this.txtAmt.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtAmt.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtAmt.CustomButton.Name = "";
            this.txtAmt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmt.CustomButton.TabIndex = 1;
            this.txtAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmt.CustomButton.UseSelectable = true;
            this.txtAmt.CustomButton.Visible = false;
            this.txtAmt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAmt.Lines = new string[0];
            this.txtAmt.Location = new System.Drawing.Point(29, 242);
            this.txtAmt.Margin = new System.Windows.Forms.Padding(5);
            this.txtAmt.MaxLength = 32767;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.PasswordChar = '\0';
            this.txtAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmt.SelectedText = "";
            this.txtAmt.SelectionLength = 0;
            this.txtAmt.SelectionStart = 0;
            this.txtAmt.ShortcutsEnabled = true;
            this.txtAmt.Size = new System.Drawing.Size(220, 25);
            this.txtAmt.TabIndex = 4;
            this.txtAmt.UseSelectable = true;
            this.txtAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(333, 206);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(0, 19);
            this.lblSearch.TabIndex = 3;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNo,
            this.accountName,
            this.Description,
            this.debit,
            this.credit,
            this.code});
            this.dgvDetails.Location = new System.Drawing.Point(337, 228);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(915, 364);
            this.dgvDetails.TabIndex = 7;
            this.dgvDetails.TabStop = false;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // accountNo
            // 
            this.accountNo.DataPropertyName = "accountNo";
            this.accountNo.HeaderText = "Account No";
            this.accountNo.Name = "accountNo";
            this.accountNo.ReadOnly = true;
            this.accountNo.Visible = false;
            // 
            // accountName
            // 
            this.accountName.DataPropertyName = "accountName";
            this.accountName.HeaderText = "Account Name";
            this.accountName.Name = "accountName";
            this.accountName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // debit
            // 
            this.debit.DataPropertyName = "debit";
            this.debit.HeaderText = "Debit";
            this.debit.Name = "debit";
            this.debit.ReadOnly = true;
            // 
            // credit
            // 
            this.credit.DataPropertyName = "credit";
            this.credit.HeaderText = "Credit";
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPrint.Location = new System.Drawing.Point(543, 613);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 39);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print Voucher";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.Location = new System.Drawing.Point(652, 613);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 39);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.Location = new System.Drawing.Point(424, 613);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save Voucher";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDr
            // 
            this.lblDr.AutoSize = true;
            this.lblDr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDr.ForeColor = System.Drawing.Color.Red;
            this.lblDr.Location = new System.Drawing.Point(947, 613);
            this.lblDr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDr.Name = "lblDr";
            this.lblDr.Size = new System.Drawing.Size(0, 21);
            this.lblDr.TabIndex = 11;
            // 
            // lblCr
            // 
            this.lblCr.AutoSize = true;
            this.lblCr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCr.ForeColor = System.Drawing.Color.Red;
            this.lblCr.Location = new System.Drawing.Point(1124, 613);
            this.lblCr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCr.Name = "lblCr";
            this.lblCr.Size = new System.Drawing.Size(0, 21);
            this.lblCr.TabIndex = 11;
            // 
            // frmVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 772);
            this.Controls.Add(this.lblCr);
            this.Controls.Add(this.lblDr);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVoucher";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Text = "Voucher Entry";
            this.grpMaster.ResumeLayout(false);
            this.grpMaster.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDetails;
        private MetroFramework.Controls.MetroButton btnDr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSearch;
        private MetroFramework.Controls.MetroTextBox txtAmt;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private System.Windows.Forms.ComboBox cmbAccount;
        private MetroFramework.Controls.MetroButton btnCr;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label lblDr;
        private System.Windows.Forms.Label lblCr;
        public System.Windows.Forms.DateTimePicker dtpVoucherDate;
        public System.Windows.Forms.ComboBox cmbVtype;
        public MetroFramework.Controls.MetroTextBox txtVoucherNo;
        public System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.Label label4;
    }
}