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
    public partial class DeleteCustomer : Form
    {
        public static List<KeyValuePair<string, object>> CustList;
        public DeleteCustomer()
        {
            InitializeComponent();
            popCustomerList();
            comboBoxDefaultSettings();
        }

        //fills combobox with customers from database
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
                deleteComboBox.DisplayMember = "Display";
                deleteComboBox.ValueMember = "customerId";
                deleteComboBox.DataSource = dataSet.Tables["Cust"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
            }
        }
        public void setCustList(List<KeyValuePair<string, object>> list)
        {
            CustList = list;
        }
        public static List<KeyValuePair<string, object>> getCustList()
        {
            return CustList;
        }

        //once customer has been selected text boxes are filled with customer information (this is not editable)
        public void populateFields(List<KeyValuePair<string, object>> custList)
        {
            //lambda expressions to retrieve values from given custList
            nameText.Text = custList.First(kvp => kvp.Key == "customerName").Value.ToString();
            phoneText.Text = custList.First(kvp => kvp.Key == "phone").Value.ToString();
            addressText.Text = custList.First(kvp => kvp.Key == "address").Value.ToString();
            cityText.Text = custList.First(kvp => kvp.Key == "city").Value.ToString();
            zipText.Text = custList.First(kvp => kvp.Key == "postalCode").Value.ToString();
            countryText.Text = custList.First(kvp => kvp.Key == "country").Value.ToString();
            if (Convert.ToInt32(custList.First(kvp => kvp.Key == "active").Value) == 1)
            {
                yesRadio.Checked = true;
            }
            else
            {
                noRadio.Checked = true;
            }
        }
        private void DeleteComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView dataRowView = deleteComboBox.SelectedItem as DataRowView;
            int id = Convert.ToInt32(deleteComboBox.SelectedValue);
            var customerList = dbHelp.searchCustomer(id);
            setCustList(customerList);
            if (customerList != null)
            {
                populateFields(customerList);
            }
        }

        //default values for form fields and comboBox.
        public void comboBoxDefaultSettings()
        {
            deleteComboBox.SelectedItem = null;
            deleteComboBox.Text = "--Select--";
            nameText.Text = null;
            phoneText.Text = null;
            addressText.Text = null;
            cityText.Text = null;
            zipText.Text = null;
            countryText.Text = null;
            yesRadio.Checked = false;
            noRadio.Checked = false;
            nameText.Enabled = false;
            phoneText.Enabled = false;
            addressText.Enabled = false;
            cityText.Enabled = false;
            zipText.Enabled = false;
            countryText.Enabled = false;
            yesRadio.Enabled = false;
            noRadio.Enabled = false;
        }
        //prevents users from entering incorrect characters
        private void NameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddressText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CityText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ZipText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CountryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this customer? This cannot be undone.", "", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var list = getCustList();
                    IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                    bool appts = dbHelp.checkAppts(dictionary["customerId"].ToString());
                    if (appts == false)
                    {
                        dbHelp.deleteCustomer(dictionary);
                    }
                    else
                    {
                        DialogResult confirm2 = MessageBox.Show("Deleting this customer will also remove all associated appointments, are you sure?", "", MessageBoxButtons.YesNo);
                        if (confirm2 == DialogResult.Yes)
                        {
                            dbHelp.deleteCustAppts(dictionary["customerId"].ToString());
                            dbHelp.deleteCustomer(dictionary);
                        }
                        else
                        {
                            return;
                        }
                    }
                    MessageBox.Show("Customer successfully deleted.");
                    this.Owner.Show();
                    this.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
