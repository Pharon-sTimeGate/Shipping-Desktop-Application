using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapping.Main_Form_Last.Clients_Last
{
    public partial class client_main_last : UserControl
    {
        public client_main_last()
        {
            InitializeComponent();
        }

        private void btn_add_clients_Click(object sender, EventArgs e)
        {
            frm_add_new_client_last form = new frm_add_new_client_last();
            form.Show();
        }

        private void btn_see_selected_Click(object sender, EventArgs e)
        {
            frm_see_selected_client_last frm = new frm_see_selected_client_last();
            frm.Show();
        }

    }
}
