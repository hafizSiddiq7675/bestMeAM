using System;
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
                int i = dgvDetails.Rows.Count;
                decimal amt = (Convert.ToDecimal(txtWeight.Text) * Convert.ToDecimal(txtRate.Text));
                dgvDetails.Rows.Add(txtSr.Text, txtComodity.Text, txtContainerNo.Text, Convert.ToDecimal(txtQuantity.Text), Convert.ToDecimal(txtWeight.Text), Convert.ToDecimal(txtRate.Text), amt);
                decimal sum = 0;
                for (int j = 0; j < dgvDetails.Rows.Count; j++)
                {
                    sum += Convert.ToDecimal(dgvDetails.Rows[j].Cells["amount"].Value);
                }
                lbTot.Text = "$ " + sum.ToString();
                lblContainer.Text = (i + 1) + "*40'";
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
            btnPrint.Enabled = true;
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
            int j = Convert.ToInt32(lblSearch.Text)-1;
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            invoiceMaster im = new invoiceMaster();
            im.invoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
            im.invoiceDate = dtpInvoiceDate.Value;
            im.companyCode = Convert.ToInt32(cmbCompany.SelectedValue);
            im.companyName = cmbCompany.Text + " " + txtAddress.Text;
            MessageBox.Show("Salam " + im.companyName);
            db.invoiceMasters.Add(im);
            db.SaveChanges();
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                invoiceDetail id = new invoiceDetail();
                id.amount = Convert.ToDecimal(dgvDetails.Rows[i].Cells["amount"].Value);
                id.comodity = dgvDetails.Rows[i].Cells["comodity"].Value.ToString();
                id.Sr_No = Convert.ToInt32(dgvDetails.Rows[i].Cells["srNo"].Value);
                id.containerNo = dgvDetails.Rows[i].Cells["containerNo"].Value.ToString();
                id.invoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
                id.quantity = Convert.ToDecimal(dgvDetails.Rows[i].Cells["quantity"].Value);
                id.rate_Ton___ = Convert.ToDecimal(dgvDetails.Rows[i].Cells["rate"].Value);
                id.weight_Ton___ = Convert.ToDecimal(dgvDetails.Rows[i].Cells["weight"].Value);
                db.invoiceDetails.Add(id);
                db.SaveChanges();
            }
            dgvDetails.Rows.Clear();
            dgvDetails.Refresh();
            txtAddress.Text = "";
            txtComodity.Text = "";
            txtContainerNo.Text = "";
            lbTot.Text = "";
            lblContainer.Text = "";
            btnSave.Enabled = false;
            onLoad();
        }
    }
}