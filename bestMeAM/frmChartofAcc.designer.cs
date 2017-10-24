namespace bestMeAM
{
    partial class frmChartofAcc
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtcode = new MetroFramework.Controls.MetroTextBox();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.cmbPacc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOd = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOc = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.chkIsGroup = new System.Windows.Forms.CheckBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.accountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAccSearch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(30, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1310, 2);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code";
            // 
            // txtcode
            // 
            // 
            // 
            // 
            this.txtcode.CustomButton.Image = null;
            this.txtcode.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.txtcode.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtcode.CustomButton.Name = "";
            this.txtcode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcode.CustomButton.TabIndex = 1;
            this.txtcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcode.CustomButton.UseSelectable = true;
            this.txtcode.CustomButton.Visible = false;
            this.txtcode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtcode.Lines = new string[0];
            this.txtcode.Location = new System.Drawing.Point(90, 250);
            this.txtcode.Margin = new System.Windows.Forms.Padding(5);
            this.txtcode.MaxLength = 32767;
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '\0';
            this.txtcode.ReadOnly = true;
            this.txtcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcode.SelectedText = "";
            this.txtcode.SelectionLength = 0;
            this.txtcode.SelectionStart = 0;
            this.txtcode.ShortcutsEnabled = true;
            this.txtcode.Size = new System.Drawing.Size(315, 30);
            this.txtcode.TabIndex = 15;
            this.txtcode.UseSelectable = true;
            this.txtcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbAccType
            // 
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Items.AddRange(new object[] {
            "Assets",
            "Laibility",
            "Capital ",
            "Expense",
            "Revenue"});
            this.cmbAccType.Location = new System.Drawing.Point(84, 123);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(315, 27);
            this.cmbAccType.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.txtname.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(93, 317);
            this.txtname.Margin = new System.Windows.Forms.Padding(5);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(315, 30);
            this.txtname.TabIndex = 15;
            this.txtname.UseSelectable = true;
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbPacc
            // 
            this.cmbPacc.FormattingEnabled = true;
            this.cmbPacc.Items.AddRange(new object[] {
            "New Parent"});
            this.cmbPacc.Location = new System.Drawing.Point(87, 186);
            this.cmbPacc.Name = "cmbPacc";
            this.cmbPacc.Size = new System.Drawing.Size(315, 27);
            this.cmbPacc.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parent Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 427);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Opening Debit ($)";
            // 
            // txtOd
            // 
            // 
            // 
            // 
            this.txtOd.CustomButton.Image = null;
            this.txtOd.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.txtOd.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtOd.CustomButton.Name = "";
            this.txtOd.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtOd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOd.CustomButton.TabIndex = 1;
            this.txtOd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOd.CustomButton.UseSelectable = true;
            this.txtOd.CustomButton.Visible = false;
            this.txtOd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtOd.Lines = new string[0];
            this.txtOd.Location = new System.Drawing.Point(93, 451);
            this.txtOd.Margin = new System.Windows.Forms.Padding(5);
            this.txtOd.MaxLength = 32767;
            this.txtOd.Name = "txtOd";
            this.txtOd.PasswordChar = '\0';
            this.txtOd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOd.SelectedText = "";
            this.txtOd.SelectionLength = 0;
            this.txtOd.SelectionStart = 0;
            this.txtOd.ShortcutsEnabled = true;
            this.txtOd.Size = new System.Drawing.Size(315, 30);
            this.txtOd.TabIndex = 15;
            this.txtOd.UseSelectable = true;
            this.txtOd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 485);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Opening Credit ($)";
            // 
            // txtOc
            // 
            // 
            // 
            // 
            this.txtOc.CustomButton.Image = null;
            this.txtOc.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.txtOc.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtOc.CustomButton.Name = "";
            this.txtOc.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtOc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOc.CustomButton.TabIndex = 1;
            this.txtOc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOc.CustomButton.UseSelectable = true;
            this.txtOc.CustomButton.Visible = false;
            this.txtOc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtOc.Lines = new string[0];
            this.txtOc.Location = new System.Drawing.Point(93, 509);
            this.txtOc.Margin = new System.Windows.Forms.Padding(5);
            this.txtOc.MaxLength = 32767;
            this.txtOc.Name = "txtOc";
            this.txtOc.PasswordChar = '\0';
            this.txtOc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOc.SelectedText = "";
            this.txtOc.SelectionLength = 0;
            this.txtOc.SelectionStart = 0;
            this.txtOc.ShortcutsEnabled = true;
            this.txtOc.Size = new System.Drawing.Size(315, 30);
            this.txtOc.TabIndex = 15;
            this.txtOc.UseSelectable = true;
            this.txtOc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.Location = new System.Drawing.Point(176, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 39);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 361);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Description";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.txtDescription.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(93, 385);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(315, 30);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkIsGroup
            // 
            this.chkIsGroup.AutoSize = true;
            this.chkIsGroup.Location = new System.Drawing.Point(94, 547);
            this.chkIsGroup.Name = "chkIsGroup";
            this.chkIsGroup.Size = new System.Drawing.Size(106, 23);
            this.chkIsGroup.TabIndex = 18;
            this.chkIsGroup.Text = "IS GROUP?";
            this.chkIsGroup.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.Location = new System.Drawing.Point(830, 589);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 39);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountType,
            this.code,
            this.name,
            this.description,
            this.parentCode,
            this.openingDebit,
            this.openingCredit});
            this.dgvAccounts.Location = new System.Drawing.Point(495, 135);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(768, 435);
            this.dgvAccounts.TabIndex = 21;
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellClick);
            // 
            // accountType
            // 
            this.accountType.DataPropertyName = "accountType";
            this.accountType.HeaderText = "Account Type";
            this.accountType.Name = "accountType";
            this.accountType.ReadOnly = true;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // parentCode
            // 
            this.parentCode.DataPropertyName = "parentCode";
            this.parentCode.HeaderText = "Parent Code";
            this.parentCode.Name = "parentCode";
            this.parentCode.ReadOnly = true;
            // 
            // openingDebit
            // 
            this.openingDebit.DataPropertyName = "openingDebit";
            this.openingDebit.HeaderText = "Opening Debit ($)";
            this.openingDebit.Name = "openingDebit";
            this.openingDebit.ReadOnly = true;
            // 
            // openingCredit
            // 
            this.openingCredit.DataPropertyName = "openingCredit";
            this.openingCredit.HeaderText = "Opening Credit ($)";
            this.openingCredit.Name = "openingCredit";
            this.openingCredit.ReadOnly = true;
            // 
            // txtAccSearch
            // 
            // 
            // 
            // 
            this.txtAccSearch.CustomButton.Image = null;
            this.txtAccSearch.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.txtAccSearch.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccSearch.CustomButton.Name = "";
            this.txtAccSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAccSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccSearch.CustomButton.TabIndex = 1;
            this.txtAccSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccSearch.CustomButton.UseSelectable = true;
            this.txtAccSearch.CustomButton.Visible = false;
            this.txtAccSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAccSearch.Lines = new string[0];
            this.txtAccSearch.Location = new System.Drawing.Point(948, 101);
            this.txtAccSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccSearch.MaxLength = 32767;
            this.txtAccSearch.Name = "txtAccSearch";
            this.txtAccSearch.PasswordChar = '\0';
            this.txtAccSearch.PromptText = "Search Here..";
            this.txtAccSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccSearch.SelectedText = "";
            this.txtAccSearch.SelectionLength = 0;
            this.txtAccSearch.SelectionStart = 0;
            this.txtAccSearch.ShortcutsEnabled = true;
            this.txtAccSearch.Size = new System.Drawing.Size(315, 30);
            this.txtAccSearch.TabIndex = 22;
            this.txtAccSearch.UseSelectable = true;
            this.txtAccSearch.WaterMark = "Search Here..";
            this.txtAccSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAccSearch_KeyUp);
            // 
            // frmChartofAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 628);
            this.Controls.Add(this.txtAccSearch);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkIsGroup);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPacc);
            this.Controls.Add(this.cmbAccType);
            this.Controls.Add(this.txtOc);
            this.Controls.Add(this.txtOd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChartofAcc";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 30);
            this.Text = "Chart OF Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtcode;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtname;
        private System.Windows.Forms.ComboBox cmbPacc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtOd;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtOc;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private System.Windows.Forms.CheckBox chkIsGroup;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private MetroFramework.Controls.MetroTextBox txtAccSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingCredit;
    }
}