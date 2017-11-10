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
        }

        private void btn_edit_delete_Click(object sender, EventArgs e)
        {
            AdminEditEmp admin_edit_delete = new AdminEditEmp();
            admin_edit_delete.Show();
        }
    }
}
