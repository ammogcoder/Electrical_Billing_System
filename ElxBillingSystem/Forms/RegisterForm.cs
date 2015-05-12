using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ElxBillingSystem.Forms;
using ElxBillingSystem.Database;

namespace ElxBillingSystem.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm logForm = new loginForm();
            logForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            first_name_textBox.Clear();
            last_name_textBox.Clear();
            address_textBox.Clear();
            city_textBox.Clear();
            postal_code_textBox.Clear();
            ssn_textBox.Clear();
            cell_phone_textBox.Clear();
            email_textBox.Clear();
            uname_textBox.Clear();
            password_textBox.Clear();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            Populate state_country_populate = new Populate();
            state_country_populate.populateStateCountry(state_comboBox, country_comboBox);
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            CustomerDB custDB = new CustomerDB();

            string firstName = first_name_textBox.Text;
            string lastName = last_name_textBox.Text;
            string address = address_textBox.Text;
            string city = city_textBox.Text;
            string state = state_comboBox.SelectedItem.ToString();
            int postalCode = Convert.ToInt32(postal_code_textBox.Text);
            string country = country_comboBox.SelectedItem.ToString();
            DateTime dob = dobPicker.Value;
            string ssn = ssn_textBox.Text;
            string phone = cell_phone_textBox.Text; 
            string email = email_textBox.Text;
            string username = uname_textBox.Text;
            string password = password_textBox.Text;

            if (custDB.insertData(firstName, lastName, address, city, state, postalCode, country, dob, ssn, phone, email, username, password))
            {
                MessageBox.Show("Data saved successfully");
            }
            else
            {
                MessageBox.Show("Data invalid");
            }
        }
    }
}
