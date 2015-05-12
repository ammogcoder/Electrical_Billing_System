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
using System.Configuration;
using ElxBillingSystem.Forms;


namespace ElxBillingSystem.Database
{
    class Populate
    {
        public void populateStateCountry(ComboBox state_comboBox, ComboBox country_comboBox)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ElxData"].ConnectionString;
            string query_for_state = "select stateId,state_abbr from TBL_STATE";
            string query_for_country = "select id,name from country";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                cmd = new SqlCommand(query_for_state, conn);
                sda.SelectCommand = cmd;
                sda.Fill(ds);
                state_comboBox.DataSource = ds.Tables[0];
                state_comboBox.ValueMember = "stateId";
                state_comboBox.DisplayMember = "state_abbr";
                state_comboBox.SelectedIndex = 43;
                sda.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new SqlCommand(query_for_country, conn);
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                country_comboBox.DataSource = dt;
                country_comboBox.ValueMember = "id";
                country_comboBox.DisplayMember = "name";
                country_comboBox.SelectedIndex = 243;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void populateYear(ComboBox year_combo)
        {
            year_combo.Items.Clear();
            for (int year = 2000; year <= DateTime.UtcNow.Year; ++year)
            {
                year_combo.DisplayMember = year.ToString();
                year_combo.Items.Add(year);
            }
            year_combo.SelectedIndex = 0;
        }

        public void populateMonth(ComboBox month_combo)
        {
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            month_combo.DataSource = months;
        }

    }
}
