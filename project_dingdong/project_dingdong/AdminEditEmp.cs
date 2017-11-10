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
    public partial class AdminEditEmp : Form
    {
        public AdminEditEmp()
        {
            InitializeComponent();

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
            groupBox1.Enabled = false;
            btn_search.Enabled = false;



        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            switch(listbox_sort_by.Text)
            {
                case "name":
                    txt_name.Enabled = true;                    
                    break;

                case "surname":
                    txt_surname.Enabled = true;
                    break;

                case "Person ID":
                    txt_persid.Enabled = true;
                    break;

                case "Birthday":
                    txt_birthday.Enabled = true;
                    break;

                case "Location":
                    txt_location.Enabled = true;
                    break;

                case "Adress":
                    txt_adress.Enabled = true;
                    break;

                case "Position":
                    txt_position.Enabled = true;
                    break;

                case "Wage":
                    txt_wage.Enabled = true;
                    break;

                case "Full-/Parttime":
                    txt_status.Enabled = true;
                    break;

                case "Relationshipstatus":
                    txt_status.Enabled = true;
                    break;

                case "Gender":
                    groupBox1.Enabled = true;
                    break;

                //default:
                //    MessageBox.Show("Etwas ist falsch gelaufen.");                    
            }
            btn_search.Enabled = true;
                 

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
            groupBox1.Enabled = true;
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
    }
}
