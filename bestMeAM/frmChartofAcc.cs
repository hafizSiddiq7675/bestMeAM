using System;
using System.Linq;
using System.Windows.Forms;

namespace bestMeAM
{
    public partial class frmChartofAcc : MetroFramework.Forms.MetroForm
    {
        bestMeAMEntities db = new bestMeAMEntities();
        public frmChartofAcc()
        {
            InitializeComponent();
            onLoad();
        }
        private void onLoad()
        {
            var max = db.ChartOfAccounts.OrderByDescending(r => r.code).FirstOrDefault();
            txtcode.Text = (max == null ? 1 : (max.code + 1)).ToString();
            txtOd.Text = 0.ToString();
            txtOc.Text = 0.ToString();
            txtname.Text = "";
            txtDescription.Text = "";
            cmbPacc.DataSource = db.ChartOfAccounts.Where(r => r.isActive == true && r.isGroup == true).ToList();
            cmbPacc.ValueMember = "code";
            cmbPacc.DisplayMember = "name";
            dgvAccounts.AutoGenerateColumns = false;
            dgvAccounts.DataSource = db.ChartOfAccounts.ToList();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(txtcode.Text);
            var chk = db.ChartOfAccounts.SingleOrDefault(r => r.code == code);
            ChartOfAccount ca = new ChartOfAccount();
            if (chk == null)
            {
                ca.accountType = cmbAccType.Text;
                ca.parentCode = Convert.ToInt32(cmbPacc.SelectedValue);
                ca.code = code;
                ca.name = txtname.Text;
                ca.description = txtDescription.Text;
                ca.isActive = true;
                ca.isGroup = chkIsGroup.Checked;
                ca.openingDebit = Convert.ToDecimal(txtOd.Text);
                ca.openingCredit = Convert.ToDecimal(txtOc.Text);
                db.ChartOfAccounts.Add(ca);
                db.SaveChanges();
            }
            else
            {
                chk.accountType = cmbAccType.Text;
                chk.parentCode = Convert.ToInt32(cmbPacc.SelectedValue);
                chk.code = code;
                chk.name = txtname.Text;
                chk.description = txtDescription.Text;
                chk.isActive = true;
                chk.isGroup = chkIsGroup.Checked;
                chk.openingDebit = Convert.ToDecimal(txtOd.Text);
                chk.openingCredit = Convert.ToDecimal(txtOc.Text);
                Customer c = db.Customers.Single(r => r.chartOfAccCode == chk.code);
                c.name = chk.name;
                db.SaveChanges();
                btnSave.Text = "&Save";
                btnDelete.Enabled = false;
            }
            onLoad();
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
            {
                return;
            }
            if (dgv.CurrentRow.Selected)
            {
                cmbAccType.SelectedItem = dgv.Rows[e.RowIndex].Cells["accountType"].Value.ToString();
                cmbPacc.SelectedItem = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["parentCode"].Value);
                txtcode.Text = dgv.Rows[e.RowIndex].Cells["code"].Value.ToString();
                txtname.Text = dgv.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtDescription.Text = dgv.Rows[e.RowIndex].Cells["description"].Value.ToString();
                txtOd.Text = dgv.Rows[e.RowIndex].Cells["openingDebit"].Value.ToString();
                txtOc.Text = dgv.Rows[e.RowIndex].Cells["openingCredit"].Value.ToString();
                btnSave.Text = "&Edit";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(txtcode.Text);
            ChartOfAccount ca = db.ChartOfAccounts.SingleOrDefault(r => r.code == code);
            Customer c = db.Customers.Single(r => r.chartOfAccCode == ca.code);
            if (ca != null)
            {
                db.ChartOfAccounts.Remove(ca);
                db.Customers.Remove(c);
                db.SaveChanges();
                btnDelete.Enabled = false;
                btnSave.Text = "&Save";
                onLoad();
            }
        }

        private void txtAccSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtAccSearch.Text;
            dgvAccounts.DataSource = db.ChartOfAccounts.Where(t => t.name.Contains(search) || t.accountType.Contains(search) || t.description.Contains(search)).ToList();
        }
    }
}
