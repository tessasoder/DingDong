using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace project_dingdong
{
    public partial class AdminEditEmp : Form
    {
        string wert;
        string feld; 
        public AdminEditEmp()
        {
            InitializeComponent();
            Login.con.Open();
            
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {


            
        }

        private void txt_birthday_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void AdminEditEmp_Load(object sender, EventArgs e)
        {
            //WIP nu nid feritg
            txt_name.Enabled = false;
            txt_surname.Enabled = false;
            txt_persid.Enabled = false;
            txt_birthday.Enabled = false;
            txt_location.Enabled = false;
            txt_adress.Enabled = false;
            txt_position.Enabled = false;
            txt_wage.Enabled = false;
            txt_time.Enabled = false;
            txt_status.Enabled = false;
            cb_geschlecht.Enabled = false;
            btn_search.Enabled = false;



        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_delete.Hide();
            btn_edit.Hide();

            txt_name.Enabled = true;
            txt_surname.Enabled = true;
            txt_persid.Enabled = true;
            txt_birthday.Enabled = true;
            txt_location.Enabled = true;
            txt_adress.Enabled = true;
            txt_position.Enabled = true;
            txt_wage.Enabled = true;
            txt_time.Enabled = true;
            txt_status.Enabled = true;
            cb_geschlecht.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
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

        private void cb_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
           
            switch(cb_searchby.Text)
            {
                case "Name":
                    txt_name.Enabled = true;
                    wert = txt_name.Text;
                    feld = "name";
                    break;
                case "Surname":
                    txt_surname.Enabled = true;
                    wert = txt_surname.Text;
                    feld = "surname";
                    break;
                case "Person ID":
                    txt_persid.Enabled = true;
                    wert = txt_persid.Text;
                    feld = "persid";
                    break;
                case "Date of birth":
                    txt_birthday.Enabled = true;
                    wert = txt_birthday.Text;
                    feld = "birthday";
                    break;
                case "Adress":
                    txt_adress.Enabled = true;
                    wert = txt_adress.Text;
                    feld = "address";
                    break;
                case "Location":
                    txt_location.Enabled = true;
                    wert = txt_location.Text;
                    feld = "location";
                    break;
                case "Position":
                    txt_position.Enabled = true;
                    wert = txt_position.Text;
                    feld = "position";
                    break;
                case "Wage":
                    txt_wage.Enabled = true;
                    wert = txt_wage.Text;
                    feld = "wage";
                    break;
                case "Relationshipstatus":
                    txt_status.Enabled = true;
                    wert = txt_status.Text;
                    feld = "status";
                    break;
                case "Full-/Parttime":
                    txt_time.Enabled = true;
                    wert = txt_time.Text;
                    feld = "employment";
                    break;
                case "Gender":
                    cb_geschlecht.Enabled = true;
                    wert = cb_geschlecht.Text;
                    feld = "dingdong";
                    break;
                default:
                    break;
            }
            
        }

        private void Dateneinfügen(string feld, string wert)
        {


            //In de einzelnen Felder einfügen       
             
            //name
            MySqlCommand search = new MySqlCommand("select name from Emp where " + feld+ " = '"+wert+"'", Login.con);
            MySqlDataReader reader = search.ExecuteReader();
                        
                while (reader.Read())
                {
                    txt_name.Text = Convert.ToString(reader.GetString(0));
                }
            reader.Close();

            //surname
             
            MySqlCommand search_surname = new MySqlCommand("select surname from Emp where " + feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_surname = search_surname.ExecuteReader();

            while (reader_surname.Read())
            {
                txt_surname.Text = Convert.ToString(reader_surname.GetString(0));
            }
            reader_surname.Close();

            //persid
             
            MySqlCommand search_persid = new MySqlCommand("select persid from Emp where " + feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_persid = search_persid.ExecuteReader();

            while (reader_persid.Read())
            {
                txt_persid.Text = Convert.ToString(reader_persid.GetString(0));
            }
            reader_persid.Close();

            //birthday

            MySqlCommand search_birthday = new MySqlCommand("select birthday from Emp where " +feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_birthday = search_birthday.ExecuteReader();

            while (reader_birthday.Read())
            {
                txt_birthday.Text = Convert.ToString(reader_birthday.GetString(0));
            }
            reader_birthday.Close();

            //address

            MySqlCommand search_adress = new MySqlCommand("select address from Emp where " + feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_address = search_adress.ExecuteReader();

            while (reader_address.Read())
            {
                txt_adress.Text = Convert.ToString(reader_address.GetString(0));
            }
            reader_address.Close();

            //location

            MySqlCommand search_location = new MySqlCommand("select location from Emp where " + feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_location = search_location.ExecuteReader();

            while (reader_location.Read())
            {
                txt_location.Text = Convert.ToString(reader_location.GetString(0));
            }
            reader_location.Close();

            //position 

            MySqlCommand search_position = new MySqlCommand("select persid from Emp where " + feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_position = search_position.ExecuteReader();

            while (reader_position.Read())
            {
                txt_position.Text = Convert.ToString(reader_position.GetString(0));
            }
            reader_position.Close();

            //wage

            MySqlCommand search_wage = new MySqlCommand("select wage from Emp where " + feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_wage = search_wage.ExecuteReader();

            while (reader_wage.Read())
            {
                txt_wage.Text = Convert.ToString(reader_wage.GetString(0));
            }
            reader_wage.Close();

            //relationship

            MySqlCommand search_relationship = new MySqlCommand("select relationship from Emp where " + feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_relationship = search_relationship.ExecuteReader();

            while (reader_relationship.Read())
            {
                txt_status.Text = Convert.ToString(reader_relationship.GetString(0));
            }
            reader_relationship.Close();

            //employment

            MySqlCommand search_employment = new MySqlCommand("select employment from Emp where " + feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_employment = search_employment.ExecuteReader();

            while (reader_employment.Read())
            {
                txt_time.Text = Convert.ToString(reader_employment.GetString(0));
            }
            reader_employment.Close();

            //dingdong 

            MySqlCommand search_dingdong = new MySqlCommand("select dingdong from Emp where " + feld + "= '" + wert + "'", Login.con);
            MySqlDataReader reader_dingdong = search_dingdong.ExecuteReader();
            

            while (reader_dingdong.Read())
            {
                string geschlecht = Convert.ToString(reader_dingdong.GetString(0));
                if (geschlecht == "0")
                {
                    cb_geschlecht.Text = "Ding";
                }
                else
                {
                    cb_geschlecht.Text = "Dong";
                }                    
            }
            reader_dingdong.Close();

        }

        private void Datenerneuern()
        {

        }

        private void btn_search_daten_Click(object sender, EventArgs e)
        {                                 
                Dateneinfügen(feld, wert);
         }

        
    }
}
