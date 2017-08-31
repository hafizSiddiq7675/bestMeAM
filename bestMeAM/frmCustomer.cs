using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace bestMeAM
{
    public partial class frmCustomer : MetroFramework.Forms.MetroForm
    {
        bestMeAMEntities db = new bestMeAMEntities();
        public frmCustomer()
        {
            InitializeComponent();
            onLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(txtcode.Text);
            var chk = db.Customers.SingleOrDefault(r => r.code ==code);
            Customer c = new Customer();
            ChartOfAccount ca = new ChartOfAccount();
            if (chk == null)
            {
                var maxcode = db.ChartOfAccounts.OrderByDescending(r => r.code).FirstOrDefault();
                ca.code = maxcode == null ? 1 : (maxcode.code + 1);
                ca.accountType = "Assets";
                ca.parentCode = 1;
                ca.isGroup = false;
                ca.isActive = true;
                ca.description = "Customer Account";
                ca.name = txtname.Text;
                ca.openingCredit = 0;
                ca.openingDebit = Convert.ToDecimal(txtod.Text);
                db.ChartOfAccounts.Add(ca);
                db.SaveChanges();
                c.code = Convert.ToInt32(txtcode.Text);
                c.name = txtname.Text;
                c.address = txtAddress.Text;
                c.contact = txtcontact.Text;
                c.creditLimit = Convert.ToDecimal(txtcl.Text);
                c.email = txtemail.Text;
                c.chartOfAccCode = ca.code;
                db.Customers.Add(c);
                db.SaveChanges();
            }
            else
            {
                ChartOfAccount caDb = db.ChartOfAccounts.Single(r => r.code == chk.chartOfAccCode);
                chk.code = Convert.ToInt32(txtcode.Text);
                chk.name = txtname.Text;
                chk.contact = txtcontact.Text;
                chk.address = txtAddress.Text;
                chk.creditLimit = Convert.ToDecimal(txtcl.Text);
                chk.email = txtemail.Text;
                caDb.name = txtname.Text;
                caDb.openingDebit = Convert.ToDecimal(txtod.Text);
                db.SaveChanges();
                btnSave.Text = "&Save";
                btnDelete.Enabled = false;
            }
            onLoad();
        }
        private void onLoad()
        {
            var max = db.Customers.OrderByDescending(r => r.code).FirstOrDefault();
            txtcode.Text = (max == null ? 1 : max.code + 1).ToString();
            txtcl.Text = 0.ToString();
            txtod.Text = 0.ToString();
            txtemail.Text = "";
            txtname.Text = "";
            txtAddress.Text = "";
            txtcontact.Text = "";
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = db.Customers.ToList();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
            {
                return;
            }
            if (dgv.CurrentRow.Selected)
            {
                txtcode.Text = dgv.Rows[e.RowIndex].Cells["code"].Value.ToString();
                txtname.Text = dgv.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtcontact.Text = dgv.Rows[e.RowIndex].Cells["contact"].Value.ToString();
                txtAddress.Text = dgv.Rows[e.RowIndex].Cells["address"].Value.ToString();
                txtemail.Text = dgv.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtcl.Text = dgv.Rows[e.RowIndex].Cells["creditLimit"].Value.ToString();
                int code = Convert.ToInt32(txtcode.Text);
                var c = db.Customers.Single(r => r.code == code);
                var ca = db.ChartOfAccounts.Single(r => r.code == c.chartOfAccCode);
                txtod.Text = (ca.openingDebit).ToString();
                btnSave.Text = "&Edit";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(txtcode.Text);
            Customer c = db.Customers.SingleOrDefault(r => r.code == code);
            ChartOfAccount ca = db.ChartOfAccounts.Single(r => r.code == c.chartOfAccCode);
            if (c != null)
            {
                db.Customers.Remove(c);
                db.ChartOfAccounts.Remove(ca);
                db.SaveChanges();
                onLoad();
                btnDelete.Enabled = false;
                btnSave.Text = "&Save";
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            dgvCustomer.DataSource = db.Customers.Where(t => t.name.Contains(search) || t.address.Contains(search)).ToList();
        }
    }
}
