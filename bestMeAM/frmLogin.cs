using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace bestMeAM
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUname.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Your Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUname.Focus();
                return;
            }
            try
            {
                using (bestMeAMEntities db = new bestMeAMEntities())
                {
                    Login user = db.Logins.SingleOrDefault(r => r.userName == txtUname.Text && r.password == txtPass.Text);
                    if (user != null)
                    {
                        frmMain main = new frmMain();
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your Username or Password is Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
