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
    public partial class frmPrintVoucher : Form
    {
        public frmPrintVoucher()
        {
            InitializeComponent();
        }

        private void frmPrintVoucher_Load(object sender, EventArgs e)
        {

            this.rpvVoucher.RefreshReport();
        }
    }
}
