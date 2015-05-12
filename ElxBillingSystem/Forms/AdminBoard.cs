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
    public partial class AdminBoard : Form
    {
        private bool dataLoaded = false;
        Populate populate = new Populate();

        public AdminBoard()
        {
            InitializeComponent();
            editCustomerPanel.Show();
            populate.populateStateCountry(state_comboBox, country_comboBox);
        }


        private void cancel_button_Click(object sender, EventArgs e)
        {
            editCustomer_clearUp();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm logForm = new loginForm();
            logForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            CustomerDB custDB = new CustomerDB();
            DataTable dta = new DataTable();
            if (!string.IsNullOrWhiteSpace(custId_textBox.Text))
            {
                int custId = Convert.ToInt32(custId_textBox.Text);
                if (custDB.selectCustomer(custId))
                {
                    dataLoaded = true;
                    dta = custDB.showCustomer(Convert.ToInt32(custId_textBox.Text));
                    foreach (DataRow row in dta.Rows)
                    {
                        first_name_textBox.Text = row["firstName"].ToString();
                        last_name_textBox.Text = row["lastname"].ToString();
                        address_textBox.Text = row["address"].ToString();
                        city_textBox.Text = row["city"].ToString();
                        state_comboBox.SelectedItem = row["state"].ToString();
                        postal_code_textBox.Text = row["postalCode"].ToString();
                        country_comboBox.SelectedItem = row["country"].ToString();
                        dobPicker.Value = Convert.ToDateTime(row["dateOfBirth"].ToString());
                        ssn_textBox.Text = row["SSN"].ToString();
                        cell_phone_textBox.Text = row["phone"].ToString();
                        email_textBox.Text = row["email"].ToString();
                        uname_textBox.Text = row["username"].ToString();
                        password_textBox.Text = row["pword"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Customer ID");
                    editCustomer_clearUp();
                }
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            CustomerDB custDB = new CustomerDB();
            if (!string.IsNullOrWhiteSpace(custId_textBox.Text))
            {
                int custId = Convert.ToInt32(custId_textBox.Text);
                if (Convert.ToInt32(custId_textBox.Text) <= 0)
                {
                    if (dataLoaded)
                    {
                        if (custDB.selectCustomer(custId))
                        {
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

                            if (custDB.updateData(Convert.ToInt32(custId_textBox.Text), firstName, lastName, address, city, state, postalCode, country, dob, ssn, phone, email, username, password))
                            {
                                MessageBox.Show("Data updated successfully");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Customer ID");
                            editCustomer_clearUp();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter Customer ID");
                editCustomer_clearUp();
            }

        }

        private void adminTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adminTab.SelectedIndex == 0)
            {
                editCustomerPanel.Show();
                editCustomer_clearUp();

            }
            else if (adminTab.SelectedIndex == 1)
            {
                populate.populateYear(yearBilling_comboBox);
                populate.populateMonth(monthBilling_comboBox);
                editBillingPage_ClearUp();
            }
        }



        private void cancelBilling_Button_Click(object sender, EventArgs e)
        {
            editBillingPage_ClearUp();
        }



        private void insertBilling_button_Click(object sender, EventArgs e)
        {
            CustomerDB custDB = new CustomerDB();
            BillingDB billDB = new BillingDB();

            bool insertSuccess = false;

            int custId = Convert.ToInt32(custBilling_textBox.Text);
            string billingMonth = monthBilling_comboBox.SelectedItem.ToString();
            int billingYear = Convert.ToInt32(yearBilling_comboBox.SelectedItem.ToString());
            DateTime mailDate = mailDate_picker.Value;
            int meterNumber = Convert.ToInt32(meterNumber_textBox.Text);
            int meterReading = Convert.ToInt32(meterReading_textBox.Text);
            double amtToPay = Convert.ToDouble(amtToPay_textBox.Text);
            string paid = "no";
            DateTime? paidDate = null;
            if (paidYes_radioButton.Checked)
            {
                paid = "yes";
                paidDate = paidDate_picker.Value;
            }
            else if (paidNo_radioButton.Checked)
            {
                paid = "no";
                paidDate = null;
            }

            if (custDB.selectCustomer(custId))
            {
                if (billDB.insertData(billingId_textBox, custId, billingMonth, billingYear, mailDate, meterNumber, meterReading, amtToPay, paid, paidDate))
                {
                    MessageBox.Show("Data inserted successfully");
                }
            }
            else
            {
                MessageBox.Show("Invalid customer ID");
            }
        }

        private void editCustomer_clearUp()
        {
            populate.populateStateCountry(state_comboBox, country_comboBox);
            custId_textBox.Clear();
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
            dobPicker.Value = DateTime.Today;
        }

        public void editBillingPage_ClearUp()
        {
            billingId_textBox.Clear();
            custBilling_textBox.Clear();
            monthBilling_comboBox.SelectedIndex = 0;
            yearBilling_comboBox.SelectedIndex = 0;
            mailDate_picker.Value = DateTime.Today;
            meterNumber_textBox.Clear();
            meterReading_textBox.Clear();
            amtToPay_textBox.Clear();
            paidYes_radioButton.Checked = false;
            paidNo_radioButton.Checked = false;
            paidDate_picker.Value = DateTime.Today;
        }

        private void loadBilling_button_Click(object sender, EventArgs e)
        {
            CustomerDB custDB = new CustomerDB();
            BillingDB billDB = new BillingDB();
            DataTable dta = new DataTable();

            if (!string.IsNullOrWhiteSpace(billingId_textBox.Text))
            {
                int billId = Convert.ToInt32(billingId_textBox.Text);
                dataLoaded = true;
                dta = billDB.showBilling(billId);
                string paid = null;
                foreach (DataRow row in dta.Rows)
                {
                    custBilling_textBox.Text = row["customerId"].ToString();
                    monthBilling_comboBox.SelectedItem = row["billingMonth"].ToString();
                    yearBilling_comboBox.SelectedItem = row["billingYear"].ToString();
                    mailDate_picker.Value = Convert.ToDateTime(row["mailDate"].ToString());
                    meterNumber_textBox.Text = row["meterNumber"].ToString();
                    meterReading_textBox.Text = row["meterReading"].ToString();
                    amtToPay_textBox.Text = row["amountToPay"].ToString();
                    paid = row["paid"].ToString();
                    if (paid == "yes")
                    {
                        paidYes_radioButton.Checked = true;
                        paidDate_picker.Value = Convert.ToDateTime(row["paidDate"].ToString());

                    }
                    else
                    {
                        paidNo_radioButton.Checked = true;
                        paidDate_picker.Value = DateTime.Today;
                    }

                }
            }

            else
            {
                MessageBox.Show("Invalid Billing ID");
                editBillingPage_ClearUp();
            }
        }


        private void updBilling_button_Click(object sender, EventArgs e)
        {
            BillingDB billDB = new BillingDB();
            if (!string.IsNullOrWhiteSpace(billingId_textBox.Text))
            {
                int billId = Convert.ToInt32(billingId_textBox.Text);
                if (dataLoaded)
                {
                    if (billDB.selectBill(billId))
                    {
                        int customerId = Convert.ToInt32(custBilling_textBox.Text);
                        string billingMonth = monthBilling_comboBox.SelectedItem.ToString();
                        int billingYear = Convert.ToInt32(yearBilling_comboBox.SelectedItem.ToString());
                        DateTime mailDate = mailDate_picker.Value;
                        int meterNumber = Convert.ToInt32(meterNumber_textBox.Text);
                        int meterReading = Convert.ToInt32(meterReading_textBox.Text);
                        double amtToPay = Convert.ToDouble(amtToPay_textBox.Text);
                        string paid = "no";
                        DateTime? paidDate = null;
                        if (paidYes_radioButton.Checked)
                        {
                            paid = "yes";
                            paidDate = paidDate_picker.Value;
                        }
                        else if (paidNo_radioButton.Checked)
                        {
                            paid = "no";
                            paidDate = null;
                        }

                        if (billDB.updateBilling_Data(billId, customerId, billingMonth, billingYear, mailDate, meterNumber, meterReading, amtToPay, paid, paidDate))
                        {
                            MessageBox.Show("Data updated successfully");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Billing ID");
                        editCustomer_clearUp();
                    }
                }
                else
                {
                    MessageBox.Show("Please load the data first");
                    editCustomer_clearUp();
                }
            }
            else
            {
                MessageBox.Show("Please enter Billing ID");
                editCustomer_clearUp();
            }
        }

        private void editBilling_button_Click(object sender, EventArgs e)
        {
            adminTab.SelectedIndex = 1;
            editBilling_tabPage.Show();
            populate.populateMonth(monthBilling_comboBox);
            populate.populateYear(yearBilling_comboBox);
            editCustomer_clearUp();
        }

        private void editCustomer_button_Click(object sender, EventArgs e)
        {
            adminTab.SelectedIndex = 0;
            //editCustomer_tabPage.Show();
            populate.populateStateCountry(state_comboBox, country_comboBox);
        }





    }
}
