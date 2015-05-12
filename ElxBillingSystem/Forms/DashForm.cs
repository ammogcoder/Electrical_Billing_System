using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElxBillingSystem.Forms;
using ElxBillingSystem.Database;

namespace ElxBillingSystem.Forms
{
    public partial class DashForm : Form
    {
        private static Populate populate = new Populate();
        private static int customerId = 0;
        public DashForm(int custId)
        {
            InitializeComponent();
            customerId = custId;
            showCustomer();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm logForm = new loginForm();
            logForm.Show();
        }

        private void showCustomer()
        {
            CustomerDB custDB = new CustomerDB();
            DataTable dta = new DataTable();
            dta = custDB.showCustomer(customerId);
            foreach (DataRow row in dta.Rows)
            {
                custId_mp_textBox.Text = row["customerId"].ToString();
                fname_mp_textBox.Text = row["firstName"].ToString();
                lname_mp_textBox.Text = row["lastname"].ToString();
                address_mp_textBox.Text = row["address"].ToString();
                city_mp_textBox.Text = row["city"].ToString();
                state_mp_textBox.Text = row["state"].ToString();
                postal_code_mp_textBox.Text = row["postalCode"].ToString();
                country_mp_textBox.Text = row["country"].ToString();
                dobPicker_mp.Value = Convert.ToDateTime(row["dateOfBirth"].ToString());
                ssn_mp_textBox.Text = row["SSN"].ToString();
                cell_phone_mp_textBox.Text = row["phone"].ToString();
                email_mp_textBox.Text = row["email"].ToString();
                uname_mp_textBox.Text = row["username"].ToString();
                password_mp_textBox.Text = row["pword"].ToString();
            }
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            dashBoard_tab.SelectedIndex = 0;
            showCustomer();
            
        }

        private void reportGenerateButton_Click(object sender, EventArgs e)
        {
            dashBoard_tab.SelectedIndex = 1;
            populate.populateMonth(month_rpg_comboBox);
            populate.populateYear(year_rpg_comboBox);
        }

        private void reportGen_rpg_button_Click(object sender, EventArgs e)
        {
            if (month_rpg_comboBox.SelectedIndex < 13 && year_rpg_comboBox.SelectedIndex <= 16)
            {
                BillingDB billDB = new BillingDB();
                string month = month_rpg_comboBox.SelectedItem.ToString();
                int year = Convert.ToInt32(year_rpg_comboBox.SelectedItem.ToString());
                if (!(billDB.generateReport(customerId, month, year, billingID_rpg_textBox, mailDate_rpg_textBox, meterNumber_rpg_textBox, meterReading_rpg_textBox, amtToPay_rpg_textBox, paid_rpg_textBox, paidDate_rpg_textBox)))
                {
                    reportGenTab_ClearUp();
                    MessageBox.Show("No item to be displayed");
                }
                
            }
        }

        private void dashBoard_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dashBoard_tab.SelectedIndex == 0)
            {
                showCustomer();
                reportGenTab_ClearUp();
            }
            else if (dashBoard_tab.SelectedIndex == 1)
            {
                populate.populateMonth(month_rpg_comboBox);
                populate.populateYear(year_rpg_comboBox);
                reportGenTab_ClearUp();
            }
            else if (dashBoard_tab.SelectedIndex == 2)
            {
                populate.populateMonth(month1_cmp_comboBox);
                populate.populateMonth(month2_cmp_comboBox);
                populate.populateYear(year1_cmp_comboBox);
                populate.populateYear(year2_cmp_comboBox);
                reportGenTab_ClearUp();
            }
            else if (dashBoard_tab.SelectedIndex == 3)
            {
                WriteTextToRichTextBox();
            }
        }

        private void pay_rpg_button_Click(object sender, EventArgs e)
        {
            int billingId = 0;
            double amountPaid = 0;

            if (((Convert.ToDouble(amtToPay_rpg_textBox.Text) > 0) && (Convert.ToDouble(amtToPay_rpg_textBox.Text) <= Convert.ToDouble(amtPaid_rpg_textBox.Text))))
            {
                billingId = Convert.ToInt32(billingID_rpg_textBox.Text);
                amountPaid = Convert.ToDouble(amtPaid_rpg_textBox.Text);
                ReportGenerator reportGen = new ReportGenerator();
                if (reportGen.calculatePay(billingId, amountPaid, paidDate_rpg_textBox))
                {
                    MessageBox.Show("Amount Updated");
                    reportGenTab_ClearUp();
                }
                else
                {
                    MessageBox.Show("Invalid Amount");
                    reportGenTab_ClearUp();
                }
            }
            else if (Convert.ToDouble(amtToPay_rpg_textBox.Text) == 0)
            {
                MessageBox.Show("Amount is already paid");
                reportGenTab_ClearUp();
            }
        }

        private void reportGenTab_ClearUp()
        {
            populate.populateMonth(month_rpg_comboBox);
            populate.populateYear(year_rpg_comboBox);
            billingID_rpg_textBox.Clear();
            mailDate_rpg_textBox.Clear();
            meterNumber_rpg_textBox.Clear();
            meterReading_rpg_textBox.Clear();
            amtToPay_rpg_textBox.Clear();
            amtPaid_rpg_textBox.Clear();
            paid_rpg_textBox.Clear();
            paidDate_rpg_textBox.Clear();
        }

        private void myProfile_ClearUp()
        {
            custId_mp_textBox.Clear();
            fname_mp_textBox.Clear();
            lname_mp_textBox.Clear();
            address_mp_textBox.Clear();
            city_mp_textBox.Clear();
            state_mp_textBox.Clear();
            postal_code_mp_textBox.Clear();
            country_mp_textBox.Clear();
            ssn_mp_textBox.Clear();
            cell_phone_mp_textBox.Clear();
            email_mp_textBox.Clear();
            uname_mp_textBox.Clear();
            password_mp_textBox.Clear();
            dobPicker_mp.Value = DateTime.Today;
        }

        private void compareReportButton_Click(object sender, EventArgs e)
        {
            dashBoard_tab.SelectedIndex = 2;
            reportGenTab_ClearUp();
            myProfile_ClearUp();
            populate.populateMonth(month1_cmp_comboBox);
            populate.populateMonth(month2_cmp_comboBox);
            populate.populateYear(year1_cmp_comboBox);
            populate.populateYear(year2_cmp_comboBox);
        }

        private void compare_cmp_button_Click(object sender, EventArgs e)
        {
            BillingDB billDB = new BillingDB();
            DataTable dta = new DataTable();
            string month1 = month1_cmp_comboBox.SelectedItem.ToString();
            int year1 = Convert.ToInt32(year1_cmp_comboBox.SelectedItem.ToString());

            string month2 = month2_cmp_comboBox.SelectedItem.ToString();
            int year2 = Convert.ToInt32(year2_cmp_comboBox.SelectedItem.ToString());

            dta = billDB.compareBilling(customerId, month1, year1, month2, year2);
            CompareView.DataSource = dta;
        }

        private void energySaving_button_Click(object sender, EventArgs e)
        {
            dashBoard_tab.SelectedIndex = 3;
            WriteTextToRichTextBox();
        }

        private void WriteTextToRichTextBox()
        {
            energySaving_TextBox.Clear();
            energySaving_TextBox.SelectionFont = new Font("Arial", 11);
            energySaving_TextBox.SelectionBullet = true;
            energySaving_TextBox.SelectedText = "Avoid using the oven on hot days. Instead, cook on the stove, use a microwave oven, or grill outside." + "\n";
            energySaving_TextBox.SelectedText = "Clear the area around where your air conditioner vents to the outside to ensure the best possible ventilation." + "\n";
            energySaving_TextBox.SelectedText = "Save on cooling costs by setting your thermostat to 75-78°F when you're at home, health permitting. Set it to 85°F when you're away for more than a few hours." + "\n";
            energySaving_TextBox.SelectedText = "If possible, enjoy an afternoon out at the pool, park, or local library." + "\n";
            energySaving_TextBox.SelectedText = "Wait until cooler times of the day to do tasks that make your house warmer, like laundry and cooking. " + "\n";
            energySaving_TextBox.SelectedText = "If you turn your ceiling fan on when using the air conditioner, you can raise your thermostat about 4°F to save on cooling costs with no reduction in comfort." + "\n";
            energySaving_TextBox.SelectedText = "Make sure your air conditioner's fresh air vent is closed so you're not spending extra money cooling outside air." + "\n";
            energySaving_TextBox.SelectedText = "Hang laundry outside. Take advantage of late sunsets and warm evenings to bypass your dryer and let your clothes air dry." + "\n";
            energySaving_TextBox.SelectedText = "Make sure your air conditioner's fresh air vent is closed so you're not spending extra money cooling outside air." + "\n";
            energySaving_TextBox.SelectedText = "Turn off lights. In addition to switching off lights when you’re not using rooms, consider a summer tradition of candlelit dinners or dimly lit game nights. During the day, rely on natural light alone. " + "\n";
            energySaving_TextBox.SelectedText = "Clear the area around where your air conditioner vents to the outside to ensure the best possible ventilation. Make sure the outside part of your air conditioner can easily ventilate by clearing any debris or other items from the area.";

            
           
        }
    }
}
