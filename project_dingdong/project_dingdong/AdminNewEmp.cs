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
    public partial class AdminNewEmp : Form
    {
        public AdminNewEmp()
        {
            InitializeComponent();
        }

        private void txt_birthday_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void AdminNewEmp_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            AdminChooseEMP choose = new AdminChooseEMP();
            choose.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            Console.Clear();
            Console.WriteLine("logged out");
            this.Hide();
            l.Show();
        }
    }
}
