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

        #region stuff
        MySqlCommand genbtns = Login.con.CreateCommand();
        MySqlCommand getdrink = Login.con.CreateCommand();
        string cat = "";
        int num = 0;
        string[] cats = { "beer", "wine", "non_a", "shots", "mixed", "special" };

        //lists
        List<string> beer = new List<string>();
        List<string> wine = new List<string>();
        List<string> non_a = new List<string>();
        List<string> shots = new List<string>();
        List<string> mixed = new List<string>();
        List<string> special = new List<string>();
        #endregion

        public Order()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            EmpStart emp_start = new EmpStart();
            emp_start.Show();
            this.Hide();

        }


        private void Order_Load(object sender, EventArgs e)
        {

            //WIP Nu nid fertig
            //loadLists(cats);
            try
            {
                Login.con.Open();
                Console.WriteLine("loadlist");
                
                


                for (int i = 0; i < cats.Length; i++)
                {
                    //Console.WriteLine(cats[i]);

                    cat = cats[i];
                    //count the number of drinks in the category
                    num = count(cat);

                    //create buttons
                    createbtns(cat, num);

                }


                Login.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            #region generate buttons
            //generate buttons here and not while runtime


            //Console.WriteLine(cats.Length);

            //for loop loops for each button category and creats all the buttons
            
            #endregion 

            
        }

        

        #region drinkbuttons
        //beer
        private void btn_beer_Click(object sender, EventArgs e)
        {
            cat = getcat(sender);

            vsbltyHandler(cat);

        }

        //wine
        private void btn_wine_Click(object sender, EventArgs e)
        {
            cat = getcat(sender);

            vsbltyHandler(cat);
        }

        //shots
        private void btn_shots_Click(object sender, EventArgs e)
        {
            cat = getcat(sender);

            vsbltyHandler(cat);
        }

        //special
        private void btn_special_Click(object sender, EventArgs e)
        {
            cat = getcat(sender);

            vsbltyHandler(cat);
        }

        //mixed
        private void btn_mixed_Click(object sender, EventArgs e)
        {
            cat = getcat(sender);

            vsbltyHandler(cat);
        }

        //non_a
        private void btn_non_a_Click(object sender, EventArgs e)
        {
            cat = getcat(sender);

            vsbltyHandler(cat);
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


        ////delete buttons
        //private void delotherbtns()
        //{
        //    foreach (Control btn in this.Controls)
        //    {
        //        if (btn.Name.Contains("$"))
        //        {
        //            this.Controls.Remove(btn);
        //            Console.WriteLine("del "+ btn.Name);
        //        }
                    
        //    }
        //}

        //count objects in category
        private int count(string cat)
        {
            genbtns.CommandText = "select count(name) from Drinks where category='" + cat + "'";
            num = Convert.ToInt32(genbtns.ExecuteScalar());
            //Console.WriteLine(num);
            return num;
        }

        //create buttons for category
        private void createbtns(string cat, int num)
        {


            Console.WriteLine("\nCategory: "+ cat);
            
            getdrink.CommandText = "SELECT * FROM `Drinks` WHERE category = '" + cat + "'";

            MySqlDataReader reader = getdrink.ExecuteReader();
            DataTable table = reader.GetSchemaTable();

           while (reader.Read())
           {
                
                Console.WriteLine("{0}\n{1}", reader.GetString(0),reader.GetDecimal(1));

            }
           reader.Close();







            int top = 400;
            for (int i = 0; i < num; i++)
            {

                //Console.WriteLine(i);
                Button btn = new Button();

                btn.Text = cat;
                btn.Name = "$" + cat + "_" + i;
                btn.Left = 50;
                btn.Top = top;
                btn.Click += (s, e) =>
                {  //delgation
                    MessageBox.Show(btn.Name);

                };

                top += btn.Height + 2;
                //Console.WriteLine(btn.Name);
                btn.Visible = false;

                this.Controls.Add(btn);

            }
    }

        //handle visible buttons
        private void vsbltyHandler(string cat)
        {
            foreach (Control btn in this.Controls)
            {
                if (btn.Name.Contains(cat) && btn.Name.Contains("$"))
                {
                    btn.Visible = true;
                }
                else if(btn.Name.Contains("$"))
                {
                    btn.Visible = false;
                }

            }
        }

        private void loadLists(string[] cats)
        {
            
        }
        #endregion



    }
}
