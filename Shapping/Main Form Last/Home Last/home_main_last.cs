using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapping.Main_Form_Last.Home_Last
{
    public partial class home_main_last : UserControl
    {
        public home_main_last()
        {
            InitializeComponent();
        }

        private void pan_bickup_DoubleClick(object sender, EventArgs e)
        {
            frm_bickup bic = new frm_bickup();
            bic.Show();
        }
    }
}
