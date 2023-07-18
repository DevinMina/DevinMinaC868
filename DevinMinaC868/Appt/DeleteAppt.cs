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
    public partial class DeleteAppt : Form
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
        public DeleteAppt()
        {
            InitializeComponent();
            populateCustomerList();
            comboBoxDefaultSettings();
        }

        //public void comboBoxDefaultSettings()
        //{
        //    customerComboBox.SelectedItem = null;
        //    customerComboBox.Text = "--Select--";
        //    appointmentComboBox.Enabled = false;
        //    appointmentText.Enabled = false;
        //    descriptionText.Enabled = false;
        //    locationText.Enabled = false;
        //    contactText.Enabled = false;
        //    typeComboBox.Enabled = false;
        //    startDateValue.Enabled = false;
        //    endDateValue.Enabled = false;
        //    deleteButton.Enabled = false;
        //}
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
            deleteButton.Enabled = false;
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
        //public void populateAppointmentList()
        //{
        //    MySqlConnection conn = new MySqlConnection(dbHelp.getConnectionString());
        //    string utcOffset = (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).ToString().Substring(0, 6));
        //    try
        //    {
        //        string query = $"SELECT a" +
        //            $"ppointmentId, concat(type, ' --Time: ', DATE_FORMAT(CONVERT_TZ(start, '+00:00', '{utcOffset}'), '%M %D %Y %r')) as Display FROM appointment WHERE customerId = '{customerComboBox.SelectedValue}';";
        //        MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, conn);
        //        conn.Open();
        //        DataSet dataSet = new DataSet();
        //        mySqlDataAdapter.Fill(dataSet, "Appoint");
        //        appointmentComboBox.DisplayMember = "Display";
        //        appointmentComboBox.ValueMember = "appointmentId";
        //        appointmentComboBox.DataSource = dataSet.Tables["Appoint"];

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error occured! " + ex);
        //    }
        //}
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
        //public void populateFields(List<KeyValuePair<string, object>> appointmentList)
        //{
        //    //lambda expression to retrieve values from given appointmentList
        //    appointmentText.Text = appointmentList.First(kvp => kvp.Key == "title").Value.ToString();
        //    descriptionText.Text = appointmentList.First(kvp => kvp.Key == "description").Value.ToString();
        //    locationText.Text = appointmentList.First(kvp => kvp.Key == "location").Value.ToString();
        //    contactText.Text = appointmentList.First(kvp => kvp.Key == "contact").Value.ToString();
        //    typeComboBox.SelectedIndex = typeComboBox.FindStringExact(appointmentList.First(kvp => kvp.Key == "type").Value.ToString());
        //    string start = appointmentList.Find(kvp => kvp.Key == "start").Value.ToString();
        //    string end = appointmentList.Find(kvp => kvp.Key == "end").Value.ToString();
        //    startDateValue.Value = Convert.ToDateTime(start).ToLocalTime();
        //    endDateValue.Value = Convert.ToDateTime(end).ToLocalTime();
        //}

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

        //private void CustomerComboBox_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    populateAppointmentList();
        //    appointmentComboBox.Enabled = true;
        //    appointmentText.Enabled = false;
        //    descriptionText.Enabled = false;
        //    locationText.Enabled = false;
        //    contactText.Enabled = false;
        //    typeComboBox.Enabled = false;
        //    startDateValue.Enabled = false;
        //    endDateValue.Enabled = false;
        //    deleteButton.Enabled = false;
        //    appointmentText.Text = null;
        //    descriptionText.Text = null;
        //    locationText.Text = null;
        //    contactText.Text = null;
        //    typeComboBox.SelectedItem = null;
        //}

        private void CustomerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            populateAppointmentList();
            appointmentComboBox.Enabled = true;
            appointmentText.Enabled = false;
            descriptionText.Enabled = false;
            locationText.Enabled = false;
            contactText.Enabled = false;
            typeComboBox.Enabled = false;
            startDateValue.Enabled = false;
            endDateValue.Enabled = false;
            deleteButton.Enabled = false;
            appointmentText.Text = null;
            descriptionText.Text = null;
            locationText.Text = null;
            contactText.Text = null;
            typeComboBox.SelectedItem = null;
        }
        //private void AppointmentComboBox_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    DataRowView dataRowView = appointmentComboBox.SelectedItem as DataRowView;
        //    int id = Convert.ToInt32(appointmentComboBox.SelectedValue);
        //    var apptList = dbHelp.getApptList(id);
        //    setAppointList(apptList);

        //    if (appointmentComboBox.SelectedIndex != -1)
        //    {
        //        deleteButton.Enabled = true;
        //        populateFields(apptList);
        //    }
        //}
        //private void AppointmentComboBox_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    DataRowView dataRowView = appointmentComboBox.SelectedItem as DataRowView;
        //    int id = Convert.ToInt32(appointmentComboBox.SelectedValue);
        //    var apptList = dbHelp.getApptList(id);
        //    setAppointList(apptList);

        //    if (appointmentComboBox.SelectedIndex != -1)
        //    {
        //        appointmentText.Enabled = true;
        //        descriptionText.Enabled = true;
        //        locationText.Enabled = true;
        //        contactText.Enabled = true;
        //        typeComboBox.Enabled = true;
        //        startDateValue.Enabled = true;
        //        endDateValue.Enabled = true;
        //        deleteButton.Enabled = true;
        //        populateFields(apptList);
        //    }
        //}
        private void AppointmentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView dataRowView = appointmentComboBox.SelectedItem as DataRowView;
            int id = Convert.ToInt32(appointmentComboBox.SelectedValue);
            var apptList = dbHelp.getApptList(id);
            setAppointList(apptList);

            if (appointmentComboBox.SelectedIndex != -1)
            {
                appointmentText.Enabled = true;
                descriptionText.Enabled = true;
                locationText.Enabled = true;
                contactText.Enabled = true;
                typeComboBox.Enabled = true;
                startDateValue.Enabled = true;
                endDateValue.Enabled = true;
                deleteButton.Enabled = true;
                populateFields(apptList);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Would you like to delete this appointment? This cannot be undone.", "", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    //delete appointment
                    var list = getAppointList();

                    //lambda expression to convert list to dictionary
                    IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                    dbHelp.deleteAppt(dictionary);
                    MessageBox.Show("Appointment successfully deleted.");
                    //refresh appointment list
                    populateAppointmentList();
                    this.Owner.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
