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
    public partial class ApptByConsult : Form
    {
        public ApptByConsult()
        {
            InitializeComponent();
            populateUserList();
            userComboBox.SelectedItem = null;
            dataGridView1.Visible = false;
            userComboBox.Text = "--Select--";
            label2.Text = DateTime.Now.ToString();
        }
        public void populateUserList()
        {
            MySqlConnection connection = new MySqlConnection(dbHelp.getConnectionString());

            try
            {
                string query = "SELECT userId, concat(userName, ' --ID: ', userId) as Display FROM user;";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                connection.Open();
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet, "User");
                userComboBox.DisplayMember = "Display";
                userComboBox.ValueMember = "userId";
                userComboBox.DataSource = dataSet.Tables["User"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
            }
        }

        private void UserComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (userComboBox.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(userComboBox.SelectedValue);
                DataTable dataTableRecord = dbHelp.getAppointmentListByUser(id.ToString());
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
