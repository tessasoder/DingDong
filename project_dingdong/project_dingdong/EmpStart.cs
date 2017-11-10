using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_dingdong
{
    public partial class EmpStart : Form
    {
        public EmpStart()
        {
            InitializeComponent();
        }

        //logout
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            Console.Clear();
            Console.WriteLine("logged out");
            this.Hide();
            l.Show();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            Console.Clear();
            Console.WriteLine("logged out");
            this.Hide();
            l.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Order emp_order = new Order();
            emp_order.Show();
            this.Hide();
        }

        private void btn_stock_emp_Click(object sender, EventArgs e)
        {
            EmpStock emp_stock = new EmpStock();
            emp_stock.Show();
            this.Hide();
        }

        private void EmpStart_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Show();
            this.Hide();
        }
    }
}
