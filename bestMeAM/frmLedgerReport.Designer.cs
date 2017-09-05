namespace bestMeAM
{
    partial class frmLedgerReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvLedger = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ledgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ledgerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvLedger
            // 
            this.rpvLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "siddiq";
            reportDataSource1.Value = this.ledgerBindingSource;
            this.rpvLedger.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvLedger.LocalReport.ReportEmbeddedResource = "bestMeAM.Ledger.rdlc";
            this.rpvLedger.Location = new System.Drawing.Point(0, 0);
            this.rpvLedger.Name = "rpvLedger";
            this.rpvLedger.Size = new System.Drawing.Size(1262, 507);
            this.rpvLedger.TabIndex = 0;
            // 
            // ledgerBindingSource
            // 
            this.ledgerBindingSource.DataSource = typeof(bestMeAM.ledger);
            // 
            // frmLedgerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 507);
            this.Controls.Add(this.rpvLedger);
            this.Name = "frmLedgerReport";
            this.Text = "Ledger Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLedgerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ledgerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpvLedger;
        private System.Windows.Forms.BindingSource ledgerBindingSource;

    }
}