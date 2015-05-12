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

namespace ElxBillingSystem.Database
{
    class BillingDB
    {
        private static string connString = System.Configuration.ConfigurationManager.ConnectionStrings["ElxData"].ConnectionString;
        private static SqlConnection connect = new SqlConnection();
        private static SqlCommand cmd, cmd1 = new SqlCommand();
        private static SqlDataAdapter sda = new SqlDataAdapter();
        private static SqlDataReader reader;
        private static DataTable dt = new DataTable();
        private static DataSet ds = new DataSet();

        public bool updatePay(int billingId, double amountPaid, string paid, DateTime? paidDate)
        {
            bool updateSuccessful = false;

            string update_pay_billing_Query = "update BILLING set amountToPay = "
                + amountPaid + ", paid = '"
                + paid + "', paidDate ='"
                + paidDate + "' where billingId = " + billingId;
            try
            {
                using (connect = new SqlConnection(connString))
                {
                    using (cmd = new SqlCommand(update_pay_billing_Query, connect))
                    {
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            updateSuccessful = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
            return updateSuccessful;
        }

        public double getAmountToBePaid(int billingId)
        {
            string selectQuery = "select amountToPay from BILLING where billingId = " + billingId;
            double amountToBePaid = 0;
            try
            {
                using (connect = new SqlConnection(connString))
                {
                    using (cmd = new SqlCommand(selectQuery, connect))
                    {
                        connect.Open();
                        var amount = cmd.ExecuteScalar();
                        if (amount != null)
                        {
                            amountToBePaid = Convert.ToDouble(amount);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
            return amountToBePaid;
        }

        public bool generateReport(int customerId, string month, int year, TextBox billingId, TextBox mailDate, TextBox meterNumber, TextBox meterReading, TextBox amtToPay, TextBox paid, TextBox paidDate)
        {
            bool generateSuccessful = false;

            string query_to_generate_report = "select * from BILLING where customerID = " +
                customerId + " and billingMonth = '" +
                month + "' and billingYear = " +
                year;
            try
            {
                using (connect = new SqlConnection(connString))
                {
                    using (cmd = new SqlCommand(query_to_generate_report, connect))
                    {
                        sda = new SqlDataAdapter(cmd);
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["billingId"] != DBNull.Value)
                            {
                                billingId.Text = row["billingId"].ToString();
                                mailDate.Text = row["mailDate"].ToString();
                                meterNumber.Text = row["meterNumber"].ToString();
                                meterReading.Text = row["meterReading"].ToString();
                                amtToPay.Text = row["amountToPay"].ToString();
                                paid.Text = row["paid"].ToString();
                                paidDate.Text = row["paidDate"].ToString();
                                generateSuccessful = true;
                            }   
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sda.Dispose();
                dt.Clear();
                dt.Dispose();
                connect.Close();
            }
            return generateSuccessful;
        }//end of generateReport

        public bool insertData(TextBox billingId_textBox, int customerId, string billingMonth, int billingYear, DateTime mailDate, int meterNumber, int meterReading, double amtToPay, string paid, DateTime? paidDate)
        {
            bool insertSuccessful = false;

            string insertQuery = "insert into BILLING values ("
                + customerId + ",'"
                + billingMonth + "',"
                + billingYear + ",'"
                + mailDate + "',"
                + meterNumber + ","
                + meterReading + ","
                + amtToPay + ",'"
                + paid + "','"
                + paidDate + "')";

            string select_BillId_Query = "select max(billingID) from BILLING";

            try
            {
                using (connect = new SqlConnection(connString))
                {
                    using (cmd = new SqlCommand(insertQuery, connect))
                    {
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            insertSuccessful = true;
                            using (cmd1 = new SqlCommand(select_BillId_Query, connect))
                            {
                                billingId_textBox.Text = cmd1.ExecuteScalar().ToString();
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
            return insertSuccessful;
        }//end of insertData

        public DataTable showBilling(int billingId)
        {
            string query_select = "select * from BILLING where billingId = '" + billingId + "'";

            try
            {
                using (connect = new SqlConnection(connString))
                {
                    connect.Open();
                    sda = new SqlDataAdapter(query_select, connect);
                    dt = new DataTable();
                    sda.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sda.Dispose();
                dt.Dispose();
                connect.Close();
            }
            return dt;
        }

        public bool updateBilling_Data(int billingId, int customerId, string billingMonth, int billingYear, DateTime mailDate, int meterNumber, int meterReading, double amountToPay, string paid, DateTime? paidDate)
        {
            bool updateSuccessful = false;

            string updateBilling_Query = "update BILLING set customerId = "
                + customerId + ", billingMonth = '"
                + billingMonth + "', billingYear = "
                + billingYear + ", mailDate = '"
                + mailDate + "', meterNumber = "
                + meterNumber + ", meterReading = "
                + meterReading + ", amountToPay = "
                + amountToPay + ", paid = '"
                + paid + "', paidDate ='"
                + paidDate + "' where billingId = " + billingId;

            try
            {
                using (connect = new SqlConnection(connString))
                {
                    using (cmd = new SqlCommand(updateBilling_Query, connect))
                    {
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            updateSuccessful = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
            return updateSuccessful;
        }//end of billingUpdate

        public bool selectBill(int billId)
        {
            bool selectSuccessful = false;

            string selectQuery = "select * from BILLING where billingId = " + billId;
            try
            {
                using (connect = new SqlConnection(connString))
                {
                    using (cmd = new SqlCommand(selectQuery, connect))
                    {
                        connect.Open();
                        var obj = cmd.ExecuteScalar();
                        if (obj != null)
                        {
                            selectSuccessful = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
            return selectSuccessful;
        }//end of selectBill

        public DataTable compareBilling(int customerId, string month1, int year1, string month2, int year2)
        {
            string query_select1 = "select * from BILLING where customerId = " + customerId + "and billingMonth = '" + month1 + "' and billingYear = " + year1;
            string query_select2 = "select * from BILLING where customerId = " + customerId + "and billingMonth = '" + month2 + "' and billingYear = " + year2;

            try
            {
                using (connect = new SqlConnection(connString))
                {
                    connect.Open();
                    dt = new DataTable();
                    sda = new SqlDataAdapter(query_select1, connect);
                    sda.Fill(dt);
                    sda = new SqlDataAdapter(query_select2, connect);
                    sda.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sda.Dispose();
                dt.Dispose();
                connect.Close();
            }
            return dt;
        }
    }
}
