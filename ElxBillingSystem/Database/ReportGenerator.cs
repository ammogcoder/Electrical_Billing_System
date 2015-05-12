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

namespace ElxBillingSystem.Database
{
    class ReportGenerator
    {
        Populate populate = new Populate();

        public bool calculatePay(int billingId, double amountFromForm, TextBox paidDate_textBox)
        {
            bool updateSuccessful = false;
            BillingDB billDB = new BillingDB();
            string paid = "no";
            DateTime? paidDate = null;
            double amountToBePaid = billDB.getAmountToBePaid(billingId);

            double amountToUpdate = amountToBePaid - amountFromForm;
            if (amountToUpdate > 0)
            {
                paid = "no";
                paidDate = null;
                paidDate_textBox.Text = "";
            }
            else
            {
                amountToUpdate = 0;
                paid = "yes";
                paidDate = DateTime.Today;
                paidDate_textBox.Text = paidDate.ToString();
            }

            if (billDB.updatePay(billingId, amountToUpdate, paid, paidDate))
            {
                updateSuccessful = true;
            }
            return updateSuccessful;
        }

        
    }
}
