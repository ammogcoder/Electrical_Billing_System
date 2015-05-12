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
    class CustomerDB
    {
        private static string connString = System.Configuration.ConfigurationManager.ConnectionStrings["ElxData"].ConnectionString;
        private static SqlConnection connect = new SqlConnection();
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter sda;
        private static DataTable dt;

        public int loginCheck(string username, string password)
        {
            int custId = 0;
            string query_select = "select customerId from CUSTOMER where username = '" + username + "' and pword = '" + password + "'";

            try
            {
                using (connect = new SqlConnection(connString))
                {
                    connect.Open();
                    using (cmd = new SqlCommand(query_select, connect))
                        {
                            var obj = cmd.ExecuteScalar();
                            if (obj != null)
                            {
                                custId = Convert.ToInt32(obj);
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
            return custId;
        }

        public bool insertData(string firstName, string lastName, string address, string city, string state, int postalCode, string country, DateTime dob, string ssn, string phone, string email, string username, string password)
        {
            bool insertSuccessful = false;
            string insertQuery = "insert into CUSTOMER values ('"
                + firstName + "','"
                + lastName + "','"
                + address + "','"
                + city + "','"
                + state + "',"
                + postalCode + ",'"
                + country + "','"
                + dob + "','"
                + ssn + "','"
                + phone + "','"
                + email + "','"
                + username + "','" +
                password + "', DEFAULT)";

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
        }

        public DataTable showCustomer(int customerId)
        {
            string query_select = "select * from CUSTOMER where customerId = '" + customerId + "'";

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

        public bool updateData(int customerId, string firstName, string lastName, string address, string city, string state, int postalCode, string country, DateTime dob, string ssn, string phone, string email, string username, string password)
        {
            bool updateSuccessful = false;

            string updateQuery = "update CUSTOMER set firstName = '"
                + firstName + "', lastName = '"
                + lastName + "', address = '"
                + address + "', city = '"
                + city + "', state = '"
                + state + "', postalCode = "
                + postalCode + ", country = '"
                + country + "', dateOfBirth ='"
                + dob + "', ssn = '"
                + ssn + "', phone ='"
                + phone + "', email ='"
                + email + "', username ='"
                + username + "', pword ='" +
                password + "' where customerId = " + customerId;

            try
            {
                using (connect = new SqlConnection(connString))
                {
                    using (cmd = new SqlCommand(updateQuery, connect))
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

        public bool selectCustomer(int customerId)
        {
            bool selectSuccessful = false;

            string selectQuery = "select * from CUSTOMER where customerId = " + customerId;
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
        }
    }
}
