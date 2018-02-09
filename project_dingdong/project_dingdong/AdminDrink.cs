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
    public partial class AdminDrink : Form
    {
        DataSet ds;

        public AdminDrink()
        {
            InitializeComponent();
        }

        private void AdminDrink_Load(object sender, EventArgs e)
        {
            //combobox_auffüllen();
            try
            {

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
            Login.con.Close();
            Login.con.Open();

            MySqlCommand command = new MySqlCommand("select * from Drinks", Login.con);
            command.CommandType = CommandType.Text;
            DataTable data = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            ds = new System.Data.DataSet();
            adapter.Fill(data);
            daten_drinks.DataSource = data;


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login.con.Close();
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

        private void rdb_new_CheckedChanged(object sender, EventArgs e)
        {
            lbl_id.Visible = false;
            txt_id.Visible = false;
            btn_search.Visible = false;
            txt_price.Enabled = true;
            txt_drink.Enabled = true;
            txt_category.Enabled = true;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            //Umschreiben zu drinks statt stock tabel
            //    Login.con.Open();
            //    if (rdb_edit.Checked)
            //    {
            //        MySqlCommand updaten = new MySqlCommand("update Stock set Liquid = '" + txt_drink.Text + "', Centiliter ='" + txt_centi.Text + "' where drink_id = " + txt_id.Text, Login.con);
            //        updaten.ExecuteNonQuery();
            //        Datengrid_laden();
            //        Textboxen_leeren();
            //    }
            //    else if (rdb_new.Checked)
            //    {
            //        MySqlCommand fortlaufende_id = new MySqlCommand("select max(drink_id) from Stock", Login.con);
            //        MySqlDataReader reader_fid = fortlaufende_id.ExecuteReader();
            //        while (reader_fid.Read())
            //        {
            //            fid = Convert.ToInt16(reader_fid.GetString(0));
            //            fid++;
            //        }
            //        reader_fid.Close();


            //        MySqlCommand new_drink = new MySqlCommand("insert into Drinks (drink_id, Liquid, Centiliter) values (" + fid + ", '" + txt_drink.Text + "', " + txt_centi.Text + ")", Login.con);
            //        new_drink.ExecuteNonQuery();
            //        Datengrid_laden();
            //        Textboxen_leeren();
            //    }
            //    else if (rdb_delete.Checked)
            //    {
            //        MySqlCommand delete = new MySqlCommand("delete from Stock where drink_id = " + txt_id.Text, Login.con);
            //        delete.ExecuteNonQuery();
            //        Datengrid_laden();
            //        Textboxen_leeren();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wählen Sie etwas aus!");
            //    }
            //    Login.con.Close();
            //}

            //private void combobox_auffüllen()
            ////{
            ////    MySqlCommand combobox_daten = new MySqlCommand("select drinks_id from Drinks", Login.con);
            ////    MySqlDataReader reader;
            ////    string x;
            ////    comboBox1.Items.Clear();

            ////    try
            ////    {
            ////        Login.con.Open();
            ////        reader = combobox_daten.ExecuteReader();

            ////        while (reader.Read())
            ////        {

            ////            comboBox1.Items.Add(reader.GetString(0));
            ////        }
            ////        reader.Close();
            ////        Login.con.Close();

            ////    }


            ////    catch
            ////    {


            ////    }


            //}










            //private void btn_search_Click(object sender, EventArgs e)
            //{
            //    Login.con.Open();

            //    //drink befüllen
            //    MySqlCommand drink = new MySqlCommand("select Liquid from Stock where drink_id = " + txt_id.Text, Login.con);
            //    MySqlDataReader reader_drink = drink.ExecuteReader();

            //    while (reader_drink.Read())
            //    {
            //        txt_drink.Text = Convert.ToString(reader_drink.GetString(0));
            //    }
            //    reader_drink.Close();

            //    //Centi befüllen
            //    MySqlCommand centi = new MySqlCommand("select Centiliter from Stock where drink_id = " + txt_id.Text, Login.con);
            //    MySqlDataReader reader_centi = centi.ExecuteReader();

            //    while (reader_centi.Read())
            //    {
            //        txt_centi.Text = Convert.ToString(reader_centi.GetString(0));
            //    }
            //    reader_centi.Close();

            //    if (rdb_delete.Checked)
            //    {
            //        txt_centi.Enabled = false;
            //        txt_drink.Enabled = false;
            //        txt_id.Enabled = false;
            //    }
            //    else
            //    {
            //        txt_centi.Enabled = true;
            //        txt_drink.Enabled = true;
            //        txt_id.Enabled = false;
            //    }

            //    Login.con.Close();
            //}




        }
    }
}

