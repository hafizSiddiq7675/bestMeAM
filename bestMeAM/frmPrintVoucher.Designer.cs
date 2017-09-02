namespace bestMeAM
{
    partial class frmPrintVoucher
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
            this.rpvVoucher = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VoucherDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VoucherDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvVoucher
            // 
            this.rpvVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "bestMeAM";
            reportDataSource1.Value = this.VoucherDetailBindingSource;
            this.rpvVoucher.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvVoucher.LocalReport.ReportEmbeddedResource = "bestMeAM.Voucher.rdlc";
            this.rpvVoucher.Location = new System.Drawing.Point(0, 0);
            this.rpvVoucher.Name = "rpvVoucher";
            this.rpvVoucher.Size = new System.Drawing.Size(982, 494);
            this.rpvVoucher.TabIndex = 0;
            // 
            // VoucherDetailBindingSource
            // 
            this.VoucherDetailBindingSource.DataSource = typeof(bestMeAM.VoucherDetail);
            // 
            // frmPrintVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 494);
            this.Controls.Add(this.rpvVoucher);
            this.Name = "frmPrintVoucher";
            this.Text = "Print Voucher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrintVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VoucherDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource VoucherDetailBindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer rpvVoucher;
    }
}