using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_dingdong
{
    public partial class AdminStock : Form
    {
        public AdminStock()
        {
            InitializeComponent();
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

        public void AdminStock_Load(object sender, EventArgs e)
        {
            try
            {
                Login.con.Open();
                MessageBox.Show("seawas");
                MySqlCommand command = new MySqlCommand("select * from Stock", Login.con);
                command.CommandType = CommandType.Text; 
                DataTable data = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(data);
                daten_stock.DataSource = data;
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
            finally
            {
                Login.con.Close();
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                Login.con.Open();
                MySqlDataAdapter
                MySqlCommandBuilder cmbl = new MySqlCommandBuilder();

            }
            catch
            {
            }
            finally
            {
                Login.con.Close();
            }
        }
    }
}
