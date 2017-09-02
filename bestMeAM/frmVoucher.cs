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
                dgvDetails.Rows.Add("Code", cmbAccount.SelectedValue, cmbAccount.Text, txtDesc.Text, txtAmt.Text, "0");
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
                //dgvDetails.Rows[j].Cells["code"].Value = "Code";
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
            }
            btnSave.Enabled = true; ;
        }

        private void btnCr_Click(object sender, EventArgs e)
        {
            if (lblSearch.Text == "")
            {
                dgvDetails.Rows.Add("Code", cmbAccount.SelectedValue, cmbAccount.Text, txtDesc.Text, "0",Convert.ToDecimal(txtAmt.Text));
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
                //dgvDetails.Rows[j].Cells["code"].Value = "Code";
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
            v.voucherNo = Convert.ToInt32(txtVoucherNo.Text);
            v.voucherDate = dtpVoucherDate.Value;
            v.voucherType = cmbVtype.Text;
            db.Vouchers.Add(v);
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
                vd.voucherNo = v.voucherNo;
                db.VoucherDetails.Add(vd);
                db.SaveChanges();
            }
            dgvDetails.Rows.Clear();
            dgvDetails.Refresh();
            txtDesc.Text = "";
            btnSave.Enabled = false;
            btnPrint.Enabled = true;
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
                new Microsoft.Reporting.WinForms.ReportParameter("voucherDate", v.voucherDate.ToString("MM/dd/yyyy")),
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
