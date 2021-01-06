using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapping.Main_Form_Last.Notification
{
    public partial class notification_main : UserControl
    {
        public notification_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get the order data and send it in the parameter

            frm_assign_deliver assign = new frm_assign_deliver();
            assign.Show();
        }
    }
}
