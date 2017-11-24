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
    public partial class Order : Form
    {


        public Order()
        {
            InitializeComponent();

            try
            {
                Login.con.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            EmpStart emp_start = new EmpStart();
            emp_start.Show();
            this.Hide();
        }


        private void Order_Load(object sender, EventArgs e)
        {

        }
    }
}
