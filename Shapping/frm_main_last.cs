using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapping
{
    public partial class frm_main_last : Form
    {
        public frm_main_last()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            client_main_last1.Hide();
            deliver_main_last1.Hide();
            report_main_last1.Hide();
            staf_main_last1.Hide();
            order_main_last1.Hide();
            home_main_last1.Show();


        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            home_main_last1.Hide();
            client_main_last1.Hide();
            deliver_main_last1.Hide();
            report_main_last1.Hide();
            staf_main_last1.Hide();
            order_main_last1.Show();

        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            home_main_last1.Hide();
            deliver_main_last1.Hide();
            report_main_last1.Hide();
            staf_main_last1.Hide();
            order_main_last1.Hide();
            client_main_last1.Show();

        }

        private void btn_deliver_Click(object sender, EventArgs e)
        {
            home_main_last1.Hide();
            client_main_last1.Hide();
            report_main_last1.Hide();
            staf_main_last1.Hide();
            order_main_last1.Hide();
            deliver_main_last1.Show();



        }

        private void btn_staf_Click(object sender, EventArgs e)
        {
            home_main_last1.Hide();
            client_main_last1.Hide();
            deliver_main_last1.Hide();
            report_main_last1.Hide();
            order_main_last1.Hide();
            staf_main_last1.Show();


        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            home_main_last1.Hide();
            client_main_last1.Hide();
            deliver_main_last1.Hide();
            staf_main_last1.Hide();
            order_main_last1.Hide();
            report_main_last1.Show();

        }

        private void frm_main_last_Load(object sender, EventArgs e)
        {
            home_main_last1.Hide();
            client_main_last1.Hide();
            deliver_main_last1.Hide();
            report_main_last1.Hide();
            staf_main_last1.Hide();
            order_main_last1.Hide();
        }

        private void lab_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
