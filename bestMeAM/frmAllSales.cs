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
    public partial class frmAllSales : MetroFramework.Forms.MetroForm
    {
        bestMeAMEntities db = new bestMeAMEntities();
        public frmAllSales()
        {
            InitializeComponent();
            onLoad();
        }
        public void onLoad()
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnPrint.Enabled = false;
            dgvInvoices.AutoGenerateColumns = false;
            dgvInvoices.DataSource = db.invoiceMasters.ToList();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            dgvInvoices.DataSource = db.invoiceMasters.Where(t => t.companyName.Contains(search)).ToList();
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
            {
                return;
            }
            if (dgv.CurrentRow.Selected)
            {
                lblFind.Text = dgv.Rows[e.RowIndex].Cells["invoiceNo"].Value.ToString();
                lblFind.Hide();
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnPrint.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblFind.Text != "")
            {
                int ino = Convert.ToInt32(lblFind.Text);
                invoiceMaster im = db.invoiceMasters.Find(ino);
                if (im != null)
                {
                    var id = db.invoiceDetails.Where(r => r.invoiceNo == ino);
                    var confirm = MessageBox.Show("Are You Sure To Delete This Item ?? This Item and Its Details Will be Deleted ","Confirm Delete" ,MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        db.invoiceMasters.Remove(im);
                        db.invoiceDetails.RemoveRange(id);
                        db.SaveChanges();
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                        btnPrint.Enabled = false;
                        onLoad();
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int ino = Convert.ToInt32(lblFind.Text);
            invoiceMaster im = db.invoiceMasters.SingleOrDefault(r => r.invoiceNo == ino);
            List<invoiceDetail> InvoiceDetails = db.invoiceDetails.Where(r => r.invoiceNo == ino).ToList();
            int sum = Convert.ToInt32(InvoiceDetails.Select(r => r.amount___).Sum());
            degitToWord dtw = new degitToWord();
            string amount = dtw.convertNumber(sum) + " Dollars Only";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("invoiceNo" , im.invoiceNo.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("invoiceDate", im.invoiceDate.ToString("dd/MM/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("company", im.companyName.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("comodity", (InvoiceDetails.Select(r=>r.comodity).Distinct().First().ToString())),
                new Microsoft.Reporting.WinForms.ReportParameter("containers", (InvoiceDetails.ToList().Count())+ "*40'".ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("amount", amount)
            };
            frmInvoice i = new frmInvoice();
            ReportDataSource rps = new ReportDataSource("bestMeAM", InvoiceDetails.ToList());
            i.rpvInvoice.LocalReport.DataSources.Add(rps);
            i.rpvInvoice.LocalReport.SetParameters(p);
            i.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ino = Convert.ToInt32(lblFind.Text);
            invoiceMaster im = db.invoiceMasters.SingleOrDefault(r => r.invoiceNo == ino);
            frmSale s = new frmSale();
            s.txtInvoiceNo.Text = im.invoiceNo.ToString();
            s.dtpInvoiceDate.Value = im.invoiceDate;
            s.cmbCompany.Text = im.companyName.ToString();
            s.dgvDetails.AutoGenerateColumns = false;
            s.dgvDetails.DataSource = db.invoiceDetails.Where(r => r.invoiceNo == ino).ToList();
            s.Show();
        }
    }
}
