﻿using System;
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
    public partial class AdminStart : Form
    {
        public AdminStart()
        {
            InitializeComponent();
        }

        //logout
        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            Console.Clear();
            Console.WriteLine("logged out");
            this.Hide();
            l.Show();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            AdminChooseEMP admin_choose_emp = new AdminChooseEMP();
            admin_choose_emp.Show();
            this.Hide();
        }

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            AdminDrink admin_drinks = new AdminDrink();
            admin_drinks.Show();
            this.Hide();

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            AdminStock admin_stock = new AdminStock();
            admin_stock.Show();
            this.Hide();
        }

        private void AdminStart_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Show();
            this.Hide();
        }
    }
}
