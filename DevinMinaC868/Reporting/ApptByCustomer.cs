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

namespace DevinMinaC868.Reporting
{
    public partial class ApptByCustomer : Form
    {
        public ApptByCustomer()
        {
            InitializeComponent();
            popCustomerList();
            customerComboBox.SelectedItem = null;
            dataGridView1.Visible = false;
            customerComboBox.Text = "--Select--";
            date.Text = DateTime.Now.ToString();
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
                customerComboBox.DisplayMember = "Display";
                customerComboBox.ValueMember = "customerId";
                customerComboBox.DataSource = dataSet.Tables["Cust"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
            }
        }

        private void CustComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedIndex > -1)
            {
                int id = Convert.ToInt32(customerComboBox.SelectedValue);
                DataTable dataTableRecord = dbHelp.getApptListByCustomer(id.ToString());
                dataGridView1.DataSource = dataTableRecord;
                dataGridView1.Visible = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
