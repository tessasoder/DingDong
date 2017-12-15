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
using MySql.Data.MySqlClient;

namespace project_dingdong
{
    public partial class Login : Form
    {

        //connection string
        public static MySqlConnection con = new MySqlConnection("server=eduweb.kb.local;username=team09;password=T3amO9;database=team09;");
        int i;
        public Login()
        {
            InitializeComponent();

            this.ActiveControl = tb_usern;
            tb_usern.Focus();
        }

        #region login
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Login where username = '" + tb_usern.Text + "' and password= '" + tb_pass.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                Console.WriteLine(i);

                //login
                if (i == 0)
                {
                    MessageBox.Show("fail");
                    Console.WriteLine("login failed: " + tb_usern.Text + ";" + tb_pass.Text + "");
                }
                //admin login
                else if (i != 0 && tb_usern.Text == "admin")
                {
                    AdminStart a = new AdminStart();
                    Console.WriteLine("logged in as admin");
                    this.Hide();
                    a.Show();
                }
                //emp login
                else
                {
                    EmpStart em = new EmpStart();
                    Console.WriteLine("logged in as emplyee");
                    this.Hide();
                    em.Show();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        #endregion


        #region usability

        #endregion

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tb_usern_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tb_pass.Focus();
        }

        private void tb_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
        }

        private void tb_usern_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tb_pass.Focus();


        }

        private void tb_pass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
        }
    }
}

