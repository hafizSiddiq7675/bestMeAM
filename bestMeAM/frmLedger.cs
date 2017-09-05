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
    public partial class frmLedger : MetroFramework.Forms.MetroForm
    {
        bestMeAMEntities db = new bestMeAMEntities();
        public frmLedger()
        {
            InitializeComponent();
            onLoad();
        }
        public void onLoad()
        {
            cmbAccount.DataSource = db.ChartOfAccounts.Where(f => f.isActive == true && f.isGroup == false).ToList();
            cmbAccount.ValueMember = "code";
            cmbAccount.DisplayMember = "name";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int acc = Convert.ToInt32(cmbAccount.SelectedValue);
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            List<ledger> data = (from v in db.Vouchers
                                join vd in db.VoucherDetails on v.voucherNo equals vd.voucherNo
                                where (vd.accountNo == acc) && (v.voucherDate >= startDate) && (v.voucherDate <= endDate)
                                select new ledger
                                {
                                    voucherDate = v.voucherDate,
                                    voucherNo = v.voucherNo,
                                    Description = vd.Description,
                                    debit = vd.debit,
                                    credit = vd.credit
                                }).ToList();
            ChartOfAccount coa = db.ChartOfAccounts.SingleOrDefault(a => a.code == acc);
            decimal openingBalance = coa.openingDebit - coa.openingCredit;
            if (Math.Abs(openingBalance) > 0)
            {
                data.Insert(0, new ledger
                {
                    voucherDate = startDate,
                    voucherNo = 0,
                    Description = "opening Balance",
                    debit = openingBalance >= 0 ? Math.Abs(openingBalance) : 0,
                    credit = openingBalance < 0 ? Math.Abs(openingBalance) : 0
                });
            }
            decimal preveousbalance = 0;
            List<ledger> pre = (from v in db.Vouchers
                                join vd in db.VoucherDetails on v.voucherNo equals vd.voucherNo
                                where (vd.accountNo == acc) && (v.voucherDate < startDate)
                                select new ledger
                                {
                                    voucherDate = v.voucherDate,
                                    voucherNo = v.voucherNo,
                                    Description = vd.Description,
                                    debit = vd.debit,
                                    credit = vd.credit
                                }).ToList();
            foreach (var i in pre)
            {
                preveousbalance += Math.Abs(i.debit - i.credit);
            }
            if (preveousbalance > 0)
            {
                data.Insert(1, new ledger
                {
                    voucherDate = startDate,
                    voucherNo = 0,
                    Description = "Preveous Balance",
                    debit = preveousbalance >= 0 ? preveousbalance : 0,
                    credit = preveousbalance < 0 ? preveousbalance : 0
                });
            }
            decimal currentTot = 0;
            List<ledger> item = data.OrderBy(i => i.voucherDate).Select(r =>
            {
                currentTot += (r.debit - r.credit);
                return new ledger { voucherDate = Convert.ToDateTime(String.Format("{0:dd/MM/yyyy}", r.voucherDate)), voucherNo = r.voucherNo, debit = r.debit, credit = r.credit, Description = r.Description, balance = currentTot };
            }).ToList();
            dgvDetails.DataSource = item;
            btnPrint.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string acc = cmbAccount.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("startDate", startDate.ToString("dd/MM/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("endDate", endDate.ToString("dd/MM/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("account", acc)
            };
            frmLedgerReport r = new frmLedgerReport();
            ReportDataSource rds = new ReportDataSource("bestMeAM", dgvDetails.DataSource);
            r.rpvLedger.LocalReport.DataSources.Add(rds);
            r.rpvLedger.LocalReport.SetParameters(p);
            r.rpvLedger.RefreshReport();
            r.Show();
        }
    }
}
