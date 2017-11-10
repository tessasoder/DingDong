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

        public Login()
        {
            InitializeComponent();

            //lalalalla i bims 1 kommentar
           
        }

        public static List<string> uname = new List<string>();
        public static List<string> pw = new List<string>();
        public static MySqlConnection con = new MySqlConnection("server=eduweb.kb.local;username=team09;password=T3amO9;database=team09;");
        //test login db in progress
        private  void button1_Click(object sender, EventArgs e)
        {
            
           
            MySqlCommand len = new MySqlCommand("select count(username) from Login;", con);
            
            if(tb_pass.Text == "" || tb_usern.Text == "")
            {
                MessageBox.Show("Bitte Username und Passwort eingeben!", "Achtung",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    Console.WriteLine("con success");
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
           


            //////////////////////////////////////////////////////////
            //login without db
            //if (tb_usern.Text == "admin" && tb_pass.Text == "123")
            //{
            //    AdminStart a = new AdminStart();
            //    Console.WriteLine("logged in as admin");
            //    this.Hide();
            //    a.Show();

            //}
            //else if(tb_usern.Text == "emp" && tb_pass.Text == "123")
            //{
            //    EmpStart em = new EmpStart();
            //    Console.WriteLine("logged in as emplyee");
            //    this.Hide();
            //    em.Show();

            //}
            //else
            //    MessageBox.Show("user not found");
            //////////////////////////////////////////////////////////
        }

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
    }
}
