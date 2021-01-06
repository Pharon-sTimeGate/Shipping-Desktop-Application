using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapping.Main_Form_Last.Deliver_Last
{
    public partial class deliver_main_last : UserControl
    {
        public deliver_main_last()
        {
            InitializeComponent();
        }

        private void btn_add_deliver_Click(object sender, EventArgs e)
        {
            frm_add_new_deliver_last f = new frm_add_new_deliver_last();
            f.Show();
        }

        private void btn_edit_deliver_data_Click(object sender, EventArgs e)
        {
            frm_edit_deliver_info_last edit = new frm_edit_deliver_info_last();
            edit.Show();

        }
    }
}
