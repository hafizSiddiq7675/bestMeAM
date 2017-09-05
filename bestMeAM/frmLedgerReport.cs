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
    public partial class frmLedgerReport : Form
    {
        public frmLedgerReport()
        {
            InitializeComponent();
        }

        private void frmLedgerReport_Load(object sender, EventArgs e)
        {

            this.rpvLedger.RefreshReport();
        }
    }
}
