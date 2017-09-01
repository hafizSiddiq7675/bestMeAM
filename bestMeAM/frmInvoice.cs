using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bestMeAM
{
    public partial class frmInvoice : Form
    {
        bestMeAMEntities db = new bestMeAMEntities();
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            invoiceMaster im = db.invoiceMasters.SingleOrDefault(r => r.invoiceNo == 20);
            List<invoiceDetail> InvoiceDetails = db.invoiceDetails.Where(r => r.invoiceNo == 20).ToList();
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("invoiceNo" , im.invoiceNo.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("invoiceDate", im.invoiceDate.ToString("MM/dd/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("company", im.companyName.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("comodity", (InvoiceDetails.Select(r=>r.comodity).Distinct().First().ToString())),
                new Microsoft.Reporting.WinForms.ReportParameter("containers", (InvoiceDetails.ToList().Count())+ " *4o'".ToString())
            };
            ReportDataSource rps = new ReportDataSource();
            rps.Name = "InvoiceDetails";
            rps.Value = InvoiceDetails.ToList();
            this.rpvInvoice.LocalReport.SetParameters(p);
            this.rpvInvoice.LocalReport.DataSources.Add(rps);
            this.rpvInvoice.RefreshReport();
        }
    }
}
