using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bestMeAM
{
    public partial class frmAllVouchers : MetroFramework.Forms.MetroForm
    {
        bestMeAMEntities db = new bestMeAMEntities();
        public frmAllVouchers()
        {
            InitializeComponent();
            onLoad();
        }
        public void onLoad()
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnPrint.Enabled = false;
            dgvVouchers.AutoGenerateColumns = false;
            dgvVouchers.DataSource = db.Vouchers.ToList();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            dgvVouchers.DataSource = db.Vouchers.Where(t => t.voucherType.Contains(search)).ToList();
        }

        private void dgvVouchers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
            {
                return;
            }
            if (dgv.CurrentRow.Selected)
            {
                lblFind.Text = dgv.Rows[e.RowIndex].Cells["voucherNo"].Value.ToString();
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
                int vno = Convert.ToInt32(lblFind.Text);
                Voucher v = db.Vouchers.Find(vno);
                if (v != null)
                {
                    var vd = db.VoucherDetails.Where(r => r.voucherNo == v.voucherNo);
                    var confirm = MessageBox.Show("Are You Sure To Delete This Item ?? This Item and Its Details Will be Deleted ", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        db.Vouchers.Remove(v);
                        db.VoucherDetails.RemoveRange(vd);
                        db.SaveChanges();
                        onLoad();
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int vno = Convert.ToInt32(lblFind.Text);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int vno = Convert.ToInt32(lblFind.Text);
            Voucher v = db.Vouchers.SingleOrDefault(r => r.voucherNo == vno);
            frmVoucher vf = new frmVoucher();
            vf.txtVoucherNo.Text = v.voucherNo.ToString();
            vf.dtpVoucherDate.Value = v.voucherDate;
            vf.cmbVtype.Text = v.voucherType.ToString();
            vf.dgvDetails.AutoGenerateColumns = false;
            vf.dgvDetails.DataSource = db.VoucherDetails.Where(r => r.voucherNo == vno).ToList();
            vf.Show();
        }
    }
}
