namespace bestMeAM
{
    partial class frmAllSales
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
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDetails = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(873, 23);
            this.label1.TabIndex = 2;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.contact,
            this.email,
            this.creditLimit});
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInvoices.Location = new System.Drawing.Point(20, 112);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(873, 396);
            this.dgvInvoices.TabIndex = 5;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(25, 23);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(578, 74);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Here..";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(315, 30);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Here..";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEdit.Location = new System.Drawing.Point(92, 65);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 39);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseSelectable = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Enabled = false;
            this.btnDetails.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDetails.Location = new System.Drawing.Point(191, 65);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(93, 39);
            this.btnDetails.TabIndex = 16;
            this.btnDetails.Text = "&Details";
            this.btnDetails.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.Location = new System.Drawing.Point(290, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 39);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseSelectable = true;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "Invoice No";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Company";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "Address";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Comodity";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // creditLimit
            // 
            this.creditLimit.DataPropertyName = "creditLimit";
            this.creditLimit.HeaderText = "Sale Voucher No";
            this.creditLimit.Name = "creditLimit";
            this.creditLimit.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPrint.Location = new System.Drawing.Point(389, 65);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 39);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseSelectable = true;
            // 
            // frmAllSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 528);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.label1);
            this.Name = "frmAllSales";
            this.Text = "All Sale Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDetails;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLimit;
        private MetroFramework.Controls.MetroButton btnPrint;
    }
}