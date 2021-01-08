using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Http;
using System.Net.Http.Formatting;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Shapping.Classes;

namespace Shapping.Main_Form_Last.Orders
{
    public partial class order_main_last : UserControl
    {
        public order_main_last()
        {
            InitializeComponent();
        }

        private async void order_main_last_Load(object sender, EventArgs e)
        {
            var responce = await Rest_Api.GetALL();
            MessageBox.Show(Rest_Api.spliting(responce));

            
        }

        private async void btn_see_orders_Click(object sender, EventArgs e)
        {
            var responce = await Rest_Api.GetALL();
            MessageBox.Show(Rest_Api.spliting(responce));
        }
    }
}
