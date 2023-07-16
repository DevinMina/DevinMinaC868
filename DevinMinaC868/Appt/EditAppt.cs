using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DevinMinaC868.Appt
{
    public partial class EditAppt : Form
    {
        public static List<KeyValuePair<string, object>> appointmentList;
        public void setAppointList(List<KeyValuePair<string, object>> list)
        {
            appointmentList = list;
        }
        public static List<KeyValuePair<string, object>> getAppointList()
        {
            return appointmentList;
        }
        public EditAppt()
        {
            InitializeComponent();
            populateCustomerList();
            comboBoxDefaultSettings();
        }

        public void comboBoxDefaultSettings()
        {
            customerComboBox.SelectedItem = null;
            customerComboBox.Text = "--Select--";
            appointmentComboBox.Enabled = false;
            appointmentText.Enabled = false;
            descriptionText.Enabled = false;
            locationText.Enabled = false;
            contactText.Enabled = false;
            typeComboBox.Enabled = false;
            startDateValue.Enabled = false;
            endDateValue.Enabled = false;
            updateButton.Enabled = false;
        }
        public void populateCustomerList()
        {
            MySqlConnection conn = new MySqlConnection(dbHelp.getConnectionString());

            try
            {
                string query = "SELECT customerId, concat(customerName, ' --ID: ', customerId) as Display FROM customer;";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet, "Cust");
                customerComboBox.DisplayMember = "Display";
                customerComboBox.ValueMember = "customerId";
                customerComboBox.DataSource = dataSet.Tables["Cust"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
            }
        }


        public void populateAppointmentList()
        {
            MySqlConnection conn = new MySqlConnection(dbHelp.getConnectionString());
            string utcOffset = (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).ToString().Substring(0, 6));
            try
            {
                string query = $"SELECT appointmentId, concat(type, ' --Time: ', DATE_FORMAT(CONVERT_TZ(start, '+00:00', '{utcOffset}'), '%M %D %Y %r')) as Display FROM appointment WHERE customerId = '{customerComboBox.SelectedValue}';";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet, "Appoint");
                appointmentComboBox.DisplayMember = "Display";
                appointmentComboBox.ValueMember = "appointmentId";
                appointmentComboBox.DataSource = dataSet.Tables["Appoint"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
            }
        }

        private void CustomerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        public void populateFields(List<KeyValuePair<string, object>> appointmentList)
        {
            //lambda expressions used to retrieve values from appointmentList
            appointmentText.Text = appointmentList.First(kvp => kvp.Key == "title").Value.ToString();
            descriptionText.Text = appointmentList.First(kvp => kvp.Key == "description").Value.ToString();
            locationText.Text = appointmentList.First(kvp => kvp.Key == "location").Value.ToString();
            contactText.Text = appointmentList.First(kvp => kvp.Key == "contact").Value.ToString();
            typeComboBox.SelectedIndex = typeComboBox.FindStringExact(appointmentList.First(kvp => kvp.Key == "type").Value.ToString());
            string start = appointmentList.Find(kvp => kvp.Key == "start").Value.ToString();
            string end = appointmentList.Find(kvp => kvp.Key == "end").Value.ToString();
            startDateValue.Value = Convert.ToDateTime(start).ToLocalTime();
            endDateValue.Value = Convert.ToDateTime(end).ToLocalTime();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private bool emptyCheck()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int appointmentAllowed(DateTime start, DateTime end)
        {

            DateTime systemStart = start.ToLocalTime();
            DateTime systemEnd = end.ToLocalTime();
            DateTime businessStart = DateTime.Today.AddHours(8);
            DateTime businessEnd = DateTime.Today.AddHours(17);

            if (systemStart.TimeOfDay < businessStart.TimeOfDay || systemEnd.TimeOfDay > businessEnd.TimeOfDay)
            {
                return 1;
            }
            if (dbHelp.appointmentOverlaps(start, end) == true)
            {
                return 2;
            }
            if (systemStart.TimeOfDay > systemEnd.TimeOfDay)
            {
                return 3;
            }
            if (systemStart.Date != systemEnd.Date)
            {
                return 4;
            }

            return 0;
        }
    }
}
