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
    public partial class Test : MetroFramework.Forms.MetroForm
    {
        bestMeAMEntities db = new bestMeAMEntities();
        public Test()
        {
            InitializeComponent();
        }
    }
}
