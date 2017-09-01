namespace bestMeAM
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.rpvInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvInvoice
            // 
            this.rpvInvoice.AccessibleDescription = "";
            this.rpvInvoice.AccessibleName = "";
            this.rpvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InvoiceDetails";
            reportDataSource1.Value = this.invoiceDetailBindingSource;
            this.rpvInvoice.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvInvoice.LocalReport.ReportEmbeddedResource = "bestMeAM.Invoice.rdlc";
            this.rpvInvoice.Location = new System.Drawing.Point(0, 0);
            this.rpvInvoice.Name = "rpvInvoice";
            this.rpvInvoice.Size = new System.Drawing.Size(1240, 504);
            this.rpvInvoice.TabIndex = 0;
            this.rpvInvoice.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataSource = typeof(bestMeAM.invoiceDetail);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 504);
            this.Controls.Add(this.rpvInvoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvoice";
            this.Text = "Invoice ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpvInvoice;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;

    }
}