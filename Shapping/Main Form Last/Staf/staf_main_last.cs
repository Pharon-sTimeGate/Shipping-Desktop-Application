using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapping.Main_Form_Last.Staf
{
    public partial class staf_main_last : UserControl
    {
        public staf_main_last()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_add_new_mem_staf_last new_staf =new frm_add_new_mem_staf_last();
            new_staf.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_edit_new_mem_staf_last edit_staf =new frm_edit_new_mem_staf_last();
            edit_staf.Show();

        }
    }
}
