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

namespace DevinMinaC868
{
    public partial class AddAppt : Form
    {
        public Menu menuObject;
        public AddAppt()
        {
            InitializeComponent();
            popCustomerList();
            comboBoxDefaultSettings();
            endDateValue.Value = endDateValue.Value.AddHours(1);
        }

        public void comboBoxDefaultSettings()
        {
            addApptComboBox.SelectedItem = null;
            addApptComboBox.Text = "--Select--";
            appointmentText.Enabled = false;
            descriptionText.Enabled = false;
            locationText.Enabled = false;
            contactText.Enabled = false;
            typeComboBox.Enabled = false;
            createButton.Enabled = false;
        }

        public void popCustomerList()
        {
            MySqlConnection conn = new MySqlConnection(dbHelp.getConnectionString());

            try
            {
                string query = "SELECT customerId, concat(customerName, ' --ID: ', customerId) as Display FROM customer;";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet, "Cust");
                addApptComboBox.DisplayMember = "Display";
                addApptComboBox.ValueMember = "customerId";
                addApptComboBox.DataSource = dataSet.Tables["Cust"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex);
            }
        }


        //-------------------------------------------------------------START DEBUG(VAR)



        public int appointmentAllowed(DateTime start, DateTime end)
        {

            DateTime systStart = start.ToLocalTime();
            DateTime systEnd = end.ToLocalTime();
            DateTime businessStart = DateTime.Today.AddHours(8);
            DateTime businessEnd = DateTime.Today.AddHours(17);

            if (systStart.TimeOfDay < businessStart.TimeOfDay || systEnd.TimeOfDay > businessEnd.TimeOfDay)
            {
                return 1;
            }
            if (dbHelp.appointmentOverlaps(start, end) == true)
            {
                return 2;
            }
            if (systStart.TimeOfDay > systEnd.TimeOfDay)
            {
                return 3;
            }
            if (systStart.Date != systEnd.Date)
            {
                return 4;
            }

            return 0;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //take currently selected customer and create an appointment for that customer
            bool pass = emptyCheck();
            if (pass == true)
            {
                if (addApptComboBox.SelectedItem != null)
                {
                    DataRowView dataRowView = addApptComboBox.SelectedItem as DataRowView;
                    int custID = Convert.ToInt32(addApptComboBox.SelectedValue);
                    DateTime start = startDateValue.Value.ToUniversalTime();
                    DateTime end = endDateValue.Value.ToUniversalTime();

                    int available = appointmentAllowed(start, end);
                    switch (available)
                    {
                        case 0:
                            dbHelp.createAppointment(custID, appointmentText.Text, descriptionText.Text, locationText.Text, contactText.Text, typeComboBox.SelectedItem.ToString(), start, end);
                            MessageBox.Show("Appointment successfully created.");
                            this.Owner.Show();
                            this.Close();


                            break;
                        case 1:
                            MessageBox.Show("The appointment is outside of business hours. Please choose a different time."); ;
                            break;
                        case 2:
                            MessageBox.Show("The appointment conflicts with another appointment. Please choose another time.");
                            break;
                        case 3:
                            MessageBox.Show("The appointment start is after the end time.");
                            break;
                        case 4:
                            MessageBox.Show("The appointments start and end date are not on the same date.");
                            break;

                    }
                }
            }
            if (pass == false)
            {
                MessageBox.Show("Please ensure all fields are not empty.");
            }
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

        private void AddApptComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            appointmentText.Enabled = true;
            descriptionText.Enabled = true;
            locationText.Enabled = true;
            contactText.Enabled = true;
            typeComboBox.Enabled = true;
            createButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }


    }
}
