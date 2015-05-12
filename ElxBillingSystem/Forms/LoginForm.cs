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
using ElxBillingSystem.Forms;
using ElxBillingSystem.Database;

namespace ElxBillingSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm regForm = new RegisterForm();
            regForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            regForm.Show();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            CustomerDB customer = new CustomerDB();
            if (uname_txtBox.Text == "admin" && password_txtBox.Text == "admin123"){
                this.Hide();
                AdminBoard adminBoard = new AdminBoard();
                adminBoard.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                adminBoard.Show();
            }
            else
            {
                int custId = customer.loginCheck(uname_txtBox.Text, password_txtBox.Text);
                if (custId > 0)
                {
                    this.Hide();
                    DashForm dashboard = new DashForm(custId);
                    dashboard.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username and password");
                }
            }
        }
    }
}
