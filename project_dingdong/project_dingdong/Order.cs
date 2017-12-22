using MySql.Data.MySqlClient;
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

        MySqlCommand genbtns = Login.con.CreateCommand();
        string cat = "";
        int num = 0;
        public Order()
        {
            InitializeComponent();

            #region generate buttons
            //generate buttons here and not while runtime
            String[] cats = new string[] {"beer", "wine", "non_a", "shots","mixed","special" };
            for(int i = 0; i < cat.Length;i++)
            {
                Console.WriteLine(cats[i]);
            }

            #endregion 

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


        #region generate buttons

        #region drinkbuttons
        //beer
        private void btn_beer_Click(object sender, EventArgs e)
        {
            try
            {
                Login.con.Open();
                cat = getcat(sender);
                Console.WriteLine(cat);
                
                delotherbtns();
                
                num = count(cat);

                createbtns(cat, num);

                Login.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }

        }

        

        //wine
        private void btn_wine_Click(object sender, EventArgs e)
        {
            try
            {
                Login.con.Open();
                cat = getcat(sender);
                Console.WriteLine(cat);

                delotherbtns();

                num = count(cat);

                createbtns(cat, num);

                Login.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }


        #endregion

        #region methods
        //get category
        private string getcat(object sender)
        {
            StringBuilder sb = new StringBuilder();
            string name = (sender as Button).Name;
            for(int i = 4; i < name.Length; i++)
            {
                sb.Append(name[i]);
            }


            return sb.ToString();
        }


        //delete buttons
        private void delotherbtns()
        {
            foreach (Control btn in this.Controls)
            {
                if (btn.Name.Contains("$"))
                {
                    this.Controls.Remove(btn);
                    Console.WriteLine("del "+ btn.Name);
                }
                    
            }
        }

        //count objects in category
        private int count(string cat)
        {
            genbtns.CommandText = "select count(name) from Drinks where category='" + cat + "'";
            num = Convert.ToInt32(genbtns.ExecuteScalar());
            Console.WriteLine(num);
            return num;
        }

        //create buttons for category
        private void createbtns(string cat, int num)
        {
            int top = 400;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
                Button btn = new Button();
                btn.Text = cat + "_" + i;
                btn.Name = "$" + cat + "_" + i;
                btn.Left = 50;
                btn.Top = top;
                this.Controls.Add(btn);
                top += btn.Height + 2;
                Console.WriteLine(btn.Name);
            }
        }
        #endregion
        #endregion


    }
}
