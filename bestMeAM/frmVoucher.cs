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
    public partial class frmVoucher : MetroFramework.Forms.MetroForm
    {
        bestMeAMEntities db = new bestMeAMEntities();
        public frmVoucher()
        {
            InitializeComponent();
            onLoad();
        }
        public void onLoad()
        {
            var max = db.Vouchers.OrderByDescending(r => r.voucherNo).FirstOrDefault();
            txtVoucherNo.Text = (max == null ? 1 : (max.voucherNo + 1)).ToString();
            cmbAccount.DataSource = db.ChartOfAccounts.Where(r=>r.isActive==true && r.isGroup==false).ToList();
            cmbAccount.ValueMember = "code";
            cmbAccount.DisplayMember = "name";
            txtAmt.Text = 0.ToString();
        }
        private void btnDr_Click(object sender, EventArgs e)
        {
            if (lblSearch.Text == "")
            {
                BindingList<VoucherDetail> vd = new BindingList<VoucherDetail>();
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    vd.Add(new VoucherDetail
                    {
                        code = Convert.ToInt32(dgvDetails.Rows[i].Cells["code"].Value),
                        accountNo = Convert.ToInt32(dgvDetails.Rows[i].Cells["accountNo"].Value),
                        accountName = dgvDetails.Rows[i].Cells["accountName"].Value.ToString(),
                        Description = dgvDetails.Rows[i].Cells["Description"].Value.ToString(),
                        debit = Convert.ToDecimal(dgvDetails.Rows[i].Cells["debit"].Value),
                        credit = Convert.ToDecimal(dgvDetails.Rows[i].Cells["credit"].Value)
                    });
                }
                vd.Add(new VoucherDetail
                {
                    accountNo = Convert.ToInt32(cmbAccount.SelectedValue),
                    accountName = cmbAccount.Text,
                    Description = txtDesc.Text,
                    debit = Convert.ToDecimal(txtAmt.Text),
                    credit = 0
                });
                dgvDetails.AutoGenerateColumns = false;
                dgvDetails.DataSource = vd;
                decimal drtot = 0;
                decimal crtot = 0;
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    drtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["debit"].Value);
                    crtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["credit"].Value);
                }
                lblDr.Text = drtot.ToString();
                lblCr.Text = crtot.ToString();
            }
            else
            {
                int j = Convert.ToInt32(lblSearch.Text);
                dgvDetails.Rows[j].Cells["accountNo"].Value = cmbAccount.SelectedValue;
                dgvDetails.Rows[j].Cells["accountName"].Value = cmbAccount.Text;
                dgvDetails.Rows[j].Cells["Description"].Value = txtDesc.Text;
                dgvDetails.Rows[j].Cells["debit"].Value = txtAmt.Text;
                dgvDetails.Rows[j].Cells["credit"].Value = "0";
                decimal drtot = 0;
                decimal crtot = 0;
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    drtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["debit"].Value);
                    crtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["credit"].Value);
                }
                lblDr.Text = drtot.ToString();
                lblCr.Text = crtot.ToString();
                lblSearch.Text = "";
            }
            btnSave.Enabled = true; ;
        }

        private void btnCr_Click(object sender, EventArgs e)
        {
            if (lblSearch.Text == "")
            {
                BindingList<VoucherDetail> vd = new BindingList<VoucherDetail>();
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    vd.Add(new VoucherDetail
                    {
                        code = Convert.ToInt32(dgvDetails.Rows[i].Cells["code"].Value),
                        accountNo = Convert.ToInt32(dgvDetails.Rows[i].Cells["accountNo"].Value),
                        accountName = dgvDetails.Rows[i].Cells["accountName"].Value.ToString(),
                        Description = dgvDetails.Rows[i].Cells["Description"].Value.ToString(),
                        debit = Convert.ToDecimal(dgvDetails.Rows[i].Cells["debit"].Value),
                        credit = Convert.ToDecimal(dgvDetails.Rows[i].Cells["credit"].Value)
                    });
                }
                vd.Add(new VoucherDetail
                {
                    accountNo = Convert.ToInt32(cmbAccount.SelectedValue),
                    accountName = cmbAccount.Text,
                    Description = txtDesc.Text,
                    debit = 0,
                    credit = Convert.ToDecimal(txtAmt.Text)
                });
                dgvDetails.AutoGenerateColumns = false;
                dgvDetails.DataSource = vd;
                decimal drtot = 0;
                decimal crtot = 0;
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    drtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["debit"].Value);
                    crtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["credit"].Value);
                }
                lblDr.Text = drtot.ToString();
                lblCr.Text = crtot.ToString();
            }
            else
            {
                int j = Convert.ToInt32(lblSearch.Text);
                dgvDetails.Rows[j].Cells["accountNo"].Value = cmbAccount.SelectedValue;
                dgvDetails.Rows[j].Cells["accountName"].Value = cmbAccount.Text;
                dgvDetails.Rows[j].Cells["Description"].Value = txtDesc.Text;
                dgvDetails.Rows[j].Cells["debit"].Value = "0";
                dgvDetails.Rows[j].Cells["credit"].Value = Convert.ToDecimal(txtAmt.Text);
                decimal drtot = 0;
                decimal crtot = 0;
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    drtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["debit"].Value);
                    crtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["credit"].Value);
                }
                lblDr.Text = drtot.ToString();
                lblCr.Text = crtot.ToString();
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
                cmbAccount.Text = dgv.Rows[e.RowIndex].Cells["accountName"].Value.ToString();
                txtDesc.Text = dgv.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                txtAmt.Text = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells["debit"].Value) > 0 ? dgv.Rows[e.RowIndex].Cells["debit"].Value.ToString() : dgv.Rows[e.RowIndex].Cells["credit"].Value.ToString();
                lblSearch.Text = (dgv.CurrentCell.RowIndex).ToString();
                lblSearch.Hide();
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(lblSearch.Text);
            dgvDetails.Rows.RemoveAt(j);
            dgvDetails.Refresh();
            decimal drtot = 0;
            decimal crtot = 0;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                drtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["debit"].Value);
                crtot += Convert.ToDecimal(dgvDetails.Rows[i].Cells["credit"].Value);
            }
            lblDr.Text = drtot.ToString();
            lblCr.Text = crtot.ToString();
            txtDesc.Text = "";
            txtAmt.Text = 0.ToString();
            btnDelete.Enabled = false;
            if (!(dgvDetails.Rows.Count > 0))
            {
                btnSave.Enabled = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Voucher v = new Voucher();
            v = db.Vouchers.Find(Convert.ToInt32(txtVoucherNo.Text));
            if (v == null)
            {
                Voucher vNEW = new Voucher();
                vNEW.voucherNo = Convert.ToInt32(txtVoucherNo.Text);
                vNEW.voucherDate = dtpVoucherDate.Value;
                vNEW.voucherType = cmbVtype.Text;
                db.Vouchers.Add(vNEW);
                db.SaveChanges();
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    VoucherDetail vd = new VoucherDetail();
                    var max = db.VoucherDetails.OrderByDescending(r => r.code).FirstOrDefault();
                    vd.code = max == null ? 1 : (max.code + 1);
                    vd.accountNo = Convert.ToInt32(dgvDetails.Rows[i].Cells["accountNo"].Value);
                    vd.accountName = dgvDetails.Rows[i].Cells["accountName"].Value.ToString();
                    vd.Description = dgvDetails.Rows[i].Cells["Description"].Value.ToString();
                    vd.debit = Convert.ToDecimal(dgvDetails.Rows[i].Cells["debit"].Value);
                    vd.credit = Convert.ToDecimal(dgvDetails.Rows[i].Cells["credit"].Value);
                    vd.voucherNo = Convert.ToInt32(txtVoucherNo.Text);
                    db.VoucherDetails.Add(vd);
                    db.SaveChanges();
                }
                dgvDetails.DataSource = null;
                btnPrint.Enabled = true;
            }
            else
            {
                int voucherNo = Convert.ToInt32(txtVoucherNo.Text);
                var vDB = db.Vouchers.SingleOrDefault(r => r.voucherNo == voucherNo);
                vDB.voucherNo = voucherNo;
                vDB.voucherDate = dtpVoucherDate.Value;
                vDB.voucherType = cmbVtype.Text;
                for (int j = 0; j < dgvDetails.Rows.Count; j++)
                {
                    VoucherDetail voucherDetail = new VoucherDetail();
                    voucherDetail = db.VoucherDetails.Find(Convert.ToInt32(dgvDetails.Rows[j].Cells["code"].Value));
                    if (voucherDetail == null)
                    {
                        VoucherDetail vdNew = new VoucherDetail();
                        var max = db.VoucherDetails.OrderByDescending(r => r.code).FirstOrDefault();
                        vdNew.code = max == null ? 1 : (max.code + 1);
                        vdNew.accountNo = Convert.ToInt32(dgvDetails.Rows[j].Cells["accountNo"].Value);
                        vdNew.accountName = dgvDetails.Rows[j].Cells["accountName"].Value.ToString();
                        vdNew.Description = dgvDetails.Rows[j].Cells["Description"].Value.ToString();
                        vdNew.debit = Convert.ToDecimal(dgvDetails.Rows[j].Cells["debit"].Value);
                        vdNew.credit = Convert.ToDecimal(dgvDetails.Rows[j].Cells["credit"].Value);
                        vdNew.voucherNo = Convert.ToInt32(txtVoucherNo.Text);
                        db.VoucherDetails.Add(vdNew);
                        db.SaveChanges();
                    }
                    else
                    {
                        int code = Convert.ToInt32(dgvDetails.Rows[j].Cells["code"].Value);
                        var vdDB = db.VoucherDetails.Single(r => r.code == code);
                        vdDB.accountNo = Convert.ToInt32(dgvDetails.Rows[j].Cells["accountNo"].Value);
                        vdDB.accountName = dgvDetails.Rows[j].Cells["accountName"].Value.ToString();
                        vdDB.Description = dgvDetails.Rows[j].Cells["Description"].Value.ToString();
                        vdDB.debit = Convert.ToDecimal(dgvDetails.Rows[j].Cells["debit"].Value);
                        vdDB.credit = Convert.ToDecimal(dgvDetails.Rows[j].Cells["credit"].Value);
                    }
                }
                db.SaveChanges();
                dgvDetails.DataSource = null;
            }
            txtDesc.Text = "";
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            onLoad();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int vno = Convert.ToInt32(txtVoucherNo.Text)-1;
            Voucher v = db.Vouchers.SingleOrDefault(r => r.voucherNo == vno);
            List<VoucherDetail> vd = db.VoucherDetails.Where(r => r.voucherNo == vno).ToList();
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("voucherNo", v.voucherNo.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("voucherDate", v.voucherDate.ToString("dd/MM/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("voucherType", v.voucherType.ToString())
            };
            frmPrintVoucher pv = new frmPrintVoucher();
            ReportDataSource rds = new ReportDataSource("hafiz", vd.ToList());
            pv.rpvVoucher.LocalReport.DataSources.Add(rds);
            pv.rpvVoucher.LocalReport.SetParameters(p);
            pv.rpvVoucher.RefreshReport();
            pv.Show();
        }
    }
}
