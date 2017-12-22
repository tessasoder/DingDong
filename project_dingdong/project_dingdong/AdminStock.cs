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

        private void AdminStock_Load(object sender, EventArgs e)
        {
            //TODO: Diese Codezeile lädt Daten in die Tabelle "team09DataSet.Stock". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.stockTableAdapter.Fill(this.team09DataSet.Stock);

        }

        private void label1_Click(object sender, EventArgs e)
        {
           //label1.Text =  
        }
    }
}
