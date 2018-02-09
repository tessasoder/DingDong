using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_dingdong
{
    public partial class AdminShowEmp : Form
    {
        public AdminShowEmp()
        {
            InitializeComponent();
        }

        DataSet ds;

        private void AdminShowEmp_Load(object sender, EventArgs e)
        {
            try
            {
                Login.con.Close();
                Login.con.Open();
                // MessageBox.Show("seawas");
                Datengrid_laden();
            }
            catch (SqlException)
            {
                MessageBox.Show("error");
            }
            finally
            {
                Login.con.Close();
            }
        }

        private void Datengrid_laden()
        {
            MySqlCommand command = new MySqlCommand("select * from Emp", Login.con);
            command.CommandType = CommandType.Text;
            DataTable data = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            ds = new System.Data.DataSet();
            adapter.Fill(data);
            daten_stock.DataSource = data;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            EmpStart emp_start = new EmpStart();
            emp_start.Show();
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
