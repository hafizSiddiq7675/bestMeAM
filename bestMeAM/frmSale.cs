using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace bestMeAM
{
    public partial class frmSale : MetroFramework.Forms.MetroForm
    {
        bestMeAMEntities db = new bestMeAMEntities();
        public frmSale()
        {

            InitializeComponent();
            onLoad();
        }
        private void onLoad()
        {
            var max = db.invoiceMasters.OrderByDescending(r => r.invoiceNo).FirstOrDefault();
            txtInvoiceNo.Text = (max == null ? 1 : max.invoiceNo + 1).ToString();
            cmbCompany.DataSource = db.Customers.ToList();
            cmbCompany.ValueMember = "code";
            cmbCompany.DisplayMember = "name";
            txtRate.Text = 0.ToString();
            txtWeight.Text = 0.ToString();
            txtQuantity.Text = 0.ToString();
        }

        private void cmbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(cmbCompany.SelectedValue);
            Customer c = db.Customers.Single(r => r.code == code);
            txtAddress.Text = c.address;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblSearch.Text == "")
            {
                    var max = dgvDetails.Rows.Count;
                    BindingList<invoiceDetail> id = new BindingList<invoiceDetail>();
                    for (int i = 0; i < dgvDetails.Rows.Count; i++)
                    {
                        id.Add(new invoiceDetail
                        {
                            code = Convert.ToInt32(dgvDetails.Rows[i].Cells["code"].Value),
                            Sr_No = Convert.ToInt32(dgvDetails.Rows[i].Cells["srNo"].Value),
                            comodity = dgvDetails.Rows[i].Cells["comodity"].Value.ToString(),
                            containerNo = dgvDetails.Rows[i].Cells["containerNo"].Value.ToString(),
                            quantity = Convert.ToDecimal(dgvDetails.Rows[i].Cells["quantity"].Value),
                            weight_Ton = Convert.ToDecimal(dgvDetails.Rows[i].Cells["weight"].Value),
                            rate_Ton___ = Convert.ToDecimal(dgvDetails.Rows[i].Cells["rate"].Value),
                            amount___ = Convert.ToDecimal(dgvDetails.Rows[i].Cells["amount"].Value)
                        });
                    }
                    id.Add (new invoiceDetail {
                        Sr_No = Convert.ToInt32(txtSr.Text),
                        comodity = txtComodity.Text.ToString(),
                        containerNo = txtContainerNo.Text.ToString(),
                        quantity = Convert.ToDecimal(txtQuantity.Text),
                        weight_Ton = Convert.ToDecimal(txtWeight.Text),
                        rate_Ton___ = Convert.ToDecimal(txtRate.Text),
                        amount___ = Convert.ToDecimal(txtWeight.Text) * Convert.ToDecimal(txtRate.Text)
                    });
                    dgvDetails.AutoGenerateColumns = false;
                    dgvDetails.DataSource = id;
                    decimal sum = 0;
                    for (int j = 0; j < dgvDetails.Rows.Count; j++)
                    {
                        sum += Convert.ToDecimal(dgvDetails.Rows[j].Cells["amount"].Value);
                    }
                    lbTot.Text = "$ " + sum.ToString();
                    lblContainer.Text = (max + 1) + "*40'";
            }
            else
            {
                int j = Convert.ToInt32(lblSearch.Text);
                dgvDetails.Rows[j].Cells["comodity"].Value = txtComodity.Text;
                dgvDetails.Rows[j].Cells["srNo"].Value = txtSr.Text;
                dgvDetails.Rows[j].Cells["containerNo"].Value = txtContainerNo.Text;
                dgvDetails.Rows[j].Cells["quantity"].Value = Convert.ToDecimal(txtQuantity.Text);
                dgvDetails.Rows[j].Cells["weight"].Value = Convert.ToDecimal(txtWeight.Text);
                dgvDetails.Rows[j].Cells["rate"].Value = Convert.ToDecimal(txtRate.Text);
                dgvDetails.Rows[j].Cells["amount"].Value = (Convert.ToDecimal(txtWeight.Text) * Convert.ToDecimal(txtRate.Text));
                decimal sum = 0;
                for (int k = 0; k < dgvDetails.Rows.Count; k++)
                {
                    sum += Convert.ToDecimal(dgvDetails.Rows[k].Cells["amount"].Value);
                }
                lbTot.Text = "$ " + sum.ToString();
                btnAdd.Text = "&Add";
                lblSearch.Text = "";
            }
            btnSave.Enabled = true;
        }
        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
            {
                return;
            }
            if (dgv.CurrentRow.Selected)
            {
                txtComodity.Text = dgv.Rows[e.RowIndex].Cells["comodity"].Value.ToString();
                txtSr.Text = dgv.Rows[e.RowIndex].Cells["srNo"].Value.ToString();
                txtContainerNo.Text = dgv.Rows[e.RowIndex].Cells["containerNo"].Value.ToString();
                txtQuantity.Text = dgv.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
                txtWeight.Text = dgv.Rows[e.RowIndex].Cells["weight"].Value.ToString();
                txtRate.Text = dgv.Rows[e.RowIndex].Cells["rate"].Value.ToString();
                lblSearch.Text = (dgv.CurrentCell.RowIndex).ToString();
                lblSearch.Hide();
                btnAdd.Text = "&Edit";
                btnDelete.Enabled = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(lblSearch.Text);
            dgvDetails.Rows.RemoveAt(j);
            dgvDetails.Refresh();
            decimal sum = 0;
            int i = dgvDetails.Rows.Count;
            for (int k = 0; k < dgvDetails.Rows.Count; k++)
            {
                sum += Convert.ToDecimal(dgvDetails.Rows[k].Cells["amount"].Value);
            }
            lbTot.Text = "$ " + sum.ToString();
            lblContainer.Text = i + "*40'";
            txtComodity.Text = "";
            txtContainerNo.Text = "";
            txtQuantity.Text = 0.ToString();
            txtRate.Text = 0.ToString();
            txtWeight.Text = 0.ToString();
            lblSearch.Text = "";
            btnAdd.Text = "&Add";
            btnDelete.Enabled = false;
            if (!(dgvDetails.Rows.Count > 0))
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            invoiceMaster im = new invoiceMaster();
            Voucher v = new Voucher();
            im = db.invoiceMasters.Find(Convert.ToInt32(txtInvoiceNo.Text));
            if (im == null)
            {
                int containers = dgvDetails.Rows.Count;
                var maxV = db.Vouchers.OrderByDescending(r => r.voucherNo).FirstOrDefault();
                v.voucherNo = maxV == null ? 1 : (maxV.voucherNo + 1);
                v.voucherDate = dtpInvoiceDate.Value;
                v.voucherType = "Sale Voucher";
                db.Vouchers.Add(v);
                invoiceMaster New = new invoiceMaster();
                New.invoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
                New.invoiceDate = dtpInvoiceDate.Value;
                New.companyCode = Convert.ToInt32(cmbCompany.SelectedValue);
                New.companyName = cmbCompany.Text + " ," + txtAddress.Text;
                New.containers = containers.ToString() + "*40'";
                New.saleVoucherNo = v.voucherNo;
                db.invoiceMasters.Add(New);
                db.SaveChanges();
                decimal dr = 0;
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    invoiceDetail id = new invoiceDetail();
                    var max = db.invoiceDetails.OrderByDescending(r => r.code).FirstOrDefault();
                    id.code = max == null ? 1 : (max.code + 1);
                    id.amount___ = Convert.ToDecimal(dgvDetails.Rows[i].Cells["amount"].Value);
                    id.comodity = dgvDetails.Rows[i].Cells["comodity"].Value.ToString();
                    id.Sr_No = Convert.ToInt32(dgvDetails.Rows[i].Cells["srNo"].Value);
                    id.containerNo = dgvDetails.Rows[i].Cells["containerNo"].Value.ToString();
                    id.invoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
                    id.quantity = Convert.ToDecimal(dgvDetails.Rows[i].Cells["quantity"].Value);
                    id.rate_Ton___ = Convert.ToDecimal(dgvDetails.Rows[i].Cells["rate"].Value);
                    id.weight_Ton = Convert.ToDecimal(dgvDetails.Rows[i].Cells["weight"].Value);
                    db.invoiceDetails.Add(id);
                    db.SaveChanges();
                    dr += Convert.ToDecimal(dgvDetails.Rows[i].Cells["amount"].Value);
                }
                VoucherDetail vd = new VoucherDetail();
                var maxvd = db.VoucherDetails.OrderByDescending(r => r.code).FirstOrDefault();
                int ccode = New.companyCode;
                Customer cmp = db.Customers.SingleOrDefault(r => r.code == ccode);
                ChartOfAccount cao = db.ChartOfAccounts.SingleOrDefault(r => r.code == cmp.chartOfAccCode);
                vd.code = maxvd == null ? 1 : (maxvd.code + 1);
                vd.accountName = cao.name;
                vd.accountNo = cao.code;
                vd.credit = 0;
                vd.debit = dr;
                vd.Description = "Sales Recorded";
                vd.voucherNo = v.voucherNo;
                db.VoucherDetails.Add(vd);
                db.SaveChanges();
                dgvDetails.DataSource = null;
                btnPrint.Enabled = true;
            }
            else
            {
                int id = Convert.ToInt32(txtInvoiceNo.Text);
                var imDB = db.invoiceMasters.Single(r => r.invoiceNo == id);
                imDB.invoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
                imDB.invoiceDate = dtpInvoiceDate.Value;
                imDB.companyCode = Convert.ToInt32(cmbCompany.SelectedValue);
                imDB.companyName = cmbCompany.Text + " ," + txtAddress.Text;
                imDB.containers = dgvDetails.Rows.Count.ToString() + "*40'";
                for (int j = 0; j < dgvDetails.Rows.Count; j++)
                {
                    invoiceDetail idd = new invoiceDetail();
                    idd = db.invoiceDetails.Find(Convert.ToInt32(dgvDetails.Rows[j].Cells["code"].Value));
                    if (idd == null)
                    {
                        var max = db.invoiceDetails.OrderByDescending(r => r.code).FirstOrDefault();
                        invoiceDetail newdata = new invoiceDetail();
                        newdata.code = max == null ? 1 : (max.code + 1);
                        newdata.amount___ = Convert.ToDecimal(dgvDetails.Rows[j].Cells["amount"].Value);
                        newdata.comodity = dgvDetails.Rows[j].Cells["comodity"].Value.ToString();
                        newdata.Sr_No = Convert.ToInt32(dgvDetails.Rows[j].Cells["srNo"].Value);
                        newdata.containerNo = dgvDetails.Rows[j].Cells["containerNo"].Value.ToString();
                        newdata.invoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
                        newdata.quantity = Convert.ToDecimal(dgvDetails.Rows[j].Cells["quantity"].Value);
                        newdata.rate_Ton___ = Convert.ToDecimal(dgvDetails.Rows[j].Cells["rate"].Value);
                        newdata.weight_Ton = Convert.ToDecimal(dgvDetails.Rows[j].Cells["weight"].Value);
                        db.invoiceDetails.Add(newdata);
                        db.SaveChanges();
                    }
                    else
                    {
                        int code = Convert.ToInt32(dgvDetails.Rows[j].Cells["code"].Value);
                        var DB = db.invoiceDetails.Single(r => r.code == code);
                        DB.amount___ = Convert.ToDecimal(dgvDetails.Rows[j].Cells["amount"].Value);
                        DB.comodity = dgvDetails.Rows[j].Cells["comodity"].Value.ToString();
                        DB.Sr_No = Convert.ToInt32(dgvDetails.Rows[j].Cells["srNo"].Value);
                        DB.containerNo = dgvDetails.Rows[j].Cells["containerNo"].Value.ToString();
                        DB.quantity = Convert.ToDecimal(dgvDetails.Rows[j].Cells["quantity"].Value);
                        DB.rate_Ton___ = Convert.ToDecimal(dgvDetails.Rows[j].Cells["rate"].Value);
                        DB.weight_Ton = Convert.ToDecimal(dgvDetails.Rows[j].Cells["weight"].Value);
                    }
                }
                decimal drtot = 0;
                for (int k = 0; k < dgvDetails.Rows.Count; k++)
                {
                    drtot += Convert.ToDecimal(dgvDetails.Rows[k].Cells["amount"].Value);
                }
                int vcode = Convert.ToInt32(lblBound.Text);
                Voucher vUpdate = db.Vouchers.SingleOrDefault(r => r.voucherNo == vcode);
                vUpdate.voucherDate = imDB.invoiceDate;
                VoucherDetail vdUpadate = db.VoucherDetails.SingleOrDefault(r => r.voucherNo == vcode);
                Customer cmUpdate = db.Customers.SingleOrDefault(r => r.code == imDB.companyCode);
                ChartOfAccount coaUpdate = db.ChartOfAccounts.SingleOrDefault(r => r.code == cmUpdate.chartOfAccCode);
                vdUpadate.accountNo = coaUpdate.code;
                vdUpadate.accountName = coaUpdate.name;
                vdUpadate.debit = drtot;
                db.SaveChanges();
                dgvDetails.DataSource = null;
            }
            txtAddress.Text = "";
            txtComodity.Text = "";
            txtContainerNo.Text = "";
            txtSr.Text = "";
            lbTot.Text = "";
            lblContainer.Text = "";
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            onLoad();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int ino = Convert.ToInt32(txtInvoiceNo.Text) - 1;
            invoiceMaster im = db.invoiceMasters.SingleOrDefault(r => r.invoiceNo == ino);
            List<invoiceDetail> InvoiceDetails = db.invoiceDetails.Where(r => r.invoiceNo == ino).ToList();
            int sum = Convert.ToInt32(InvoiceDetails.Select(r => r.amount___).Sum());
            degitToWord dtw = new degitToWord();
            string amount = dtw.convertNumber(sum) + " Dollars Only.";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("invoiceNo" , im.invoiceNo.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("invoiceDate", im.invoiceDate.ToString("MM/dd/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("company", im.companyName.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("comodity", (InvoiceDetails.Select(r=>r.comodity).Distinct().First().ToString())),
                new Microsoft.Reporting.WinForms.ReportParameter("containers", (InvoiceDetails.ToList().Count())+ "*40'".ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("voucherNo", im.saleVoucherNo.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("amount", amount)
            };
            frmInvoice i = new frmInvoice();
            ReportDataSource rps = new ReportDataSource("bestMeAM", InvoiceDetails.ToList());
            i.rpvInvoice.LocalReport.DataSources.Add(rps);
            i.rpvInvoice.LocalReport.SetParameters(p);
            i.Show();
         }
    }
}