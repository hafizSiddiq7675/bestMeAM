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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            metroTabControl1.SelectedTab = metroTabPage1;
        }

        private void tCompanyReg_Click(object sender, EventArgs e)
        {
            frmCustomer cu = new frmCustomer();
            cu.Show();
        }

        private void tInvoice_Click(object sender, EventArgs e)
        {
            frmSale sale = new frmSale();
            sale.Show();
        }

        private void tAllSales_Click(object sender, EventArgs e)
        {
            frmAllSales allsales = new frmAllSales();
            allsales.Show();
        }

        private void tAccounts_Click(object sender, EventArgs e)
        {
            frmChartofAcc coa = new frmChartofAcc();
            coa.Show();
        }

        private void tVouchers_Click(object sender, EventArgs e)
        {
            frmVoucher v = new frmVoucher();
            v.Show();
        }

        private void tAllVouchers_Click(object sender, EventArgs e)
        {
            frmAllVouchers va = new frmAllVouchers();
            va.Show();
        }

        private void tLedger_Click(object sender, EventArgs e)
        {
            frmLedger l = new frmLedger();
            l.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
