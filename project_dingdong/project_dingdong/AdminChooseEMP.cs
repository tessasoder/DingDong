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
    public partial class AdminChooseEMP : Form
    {
        public AdminChooseEMP()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AdminNewEmp admin_new = new AdminNewEmp();
            admin_new.Show();
            this.Hide();
        }

        private void btn_edit_delete_Click(object sender, EventArgs e)
        {
            AdminEditEmp admin_edit_delete = new AdminEditEmp();
            admin_edit_delete.Show();
            this.Hide();
        }

        private void AdminChooseEMP_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            AdminStart start = new AdminStart();
            start.Show();
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
