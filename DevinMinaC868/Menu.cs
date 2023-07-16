using DevinMinaC868.Appt;
using DevinMinaC868.Reporting;
using DevinMinaC868.User;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DevinMinaC868
{
    public partial class Menu : Form
    {
        private DataTable customer_dt;
        public Menu()
        {
            InitializeComponent();
            appointmentCalendar.DataSource = displayCalendar(weekRadio.Checked);
            update_customers();
            //updates customers dgv

        }

        private void txtBox_search_TextChanged(object sender, EventArgs e)
        {
            string search = searchBox.Text.ToLower();
            try
            {
                var re = from row in customer_dt.AsEnumerable()
                    where row[1].ToString().ToLower().Contains(search)
                    select row;

                dgv_customers.DataSource = re.CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateCalendar()
        {
            appointmentCalendar.DataSource = displayCalendar(weekRadio.Checked);
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Form addCustomer = new AddCustomer();
            addCustomer.Owner = this;
            addCustomer.Show();
            this.Hide();

        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            Form editCustomer = new EditCustomer();
            editCustomer.Owner = this;
            editCustomer.Show();
            this.Hide();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            Form deleteCustomer = new DeleteCustomer();
            deleteCustomer.Owner = this;
            deleteCustomer.Show();
            this.Hide();
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            Form addAppt = new AddAppt();
            addAppt.Owner = this;
            addAppt.Show();
            this.Hide();
        }

        private void EditAppointmentButton_Click(object sender, EventArgs e)
        {
            Form editAppt = new EditAppt();
            editAppt.Owner = this;
            editAppt.Show();
            this.Hide();
        }

        private void DeleteAppointmentButton_Click(object sender, EventArgs e)
        {
            Form deleteAppt = new DeleteAppt();
            deleteAppt.Owner = this;
            deleteAppt.Show();
            this.Hide();
        }

        public static Array displayCalendar(bool week)
        {
            MySqlConnection connection = new MySqlConnection(dbHelp.connectionString);
            connection.Open();
            var query =
                $"SELECT customerId, type, start, end, appointmentId, userId FROM appointment WHERE userId = '{dbHelp.getUserID()}'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            Dictionary<int, Hashtable> appointments = new Dictionary<int, Hashtable>();

            //create dictionary of appointments
            while (reader.Read())
            {
                Hashtable appointment = new Hashtable();
                appointment.Add("customerId", reader[0]);
                appointment.Add("type", reader[1]);
                appointment.Add("start", reader[2]);
                appointment.Add("end", reader[3]);
                appointment.Add("userId", reader[5]);
                appointments.Add(Convert.ToInt32(reader[4]), appointment);
            }

            reader.Close();

            //assigns username to appointment dictionary
            foreach (var appointment in appointments.Values)
            {
                query = $"SELECT userName FROM user WHERE userId = '{appointment["userId"]}'";
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Read();
                appointment.Add("userName", reader[0]);
                reader.Close();
            }

            //assigns customerName to appointment dictionary
            foreach (var appointment in appointments.Values)
            {
                query = $"SELECT customerName FROM customer WHERE customerId = '{appointment["customerId"]}'";
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Read();
                appointment.Add("customerName", reader[0]);
                reader.Close();
            }

            Dictionary<int, Hashtable> parsedAppointments = new Dictionary<int, Hashtable>();
            foreach (var appointment in appointments)
            {
                DateTime start = DateTime.Parse(appointment.Value["start"].ToString());
                DateTime end = DateTime.Parse(appointment.Value["end"].ToString());
                DateTime today = DateTime.UtcNow;
                //week is checked this is our appointment list
                if (week)
                {
                    DateTime sunday = today.AddDays(-(int)today.DayOfWeek);
                    DateTime saturday = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Saturday);
                    if (start >= sunday && end < saturday)
                    {
                        parsedAppointments.Add(appointment.Key, appointment.Value);
                    }
                }
                //if not we get month appointments
                else
                {
                    DateTime firstOfMonth = new DateTime(today.Year, today.Month, 1);
                    DateTime lastOfMonth = firstOfMonth.AddMonths(1).AddDays(-1);
                    if (start >= firstOfMonth && end < lastOfMonth)
                    {
                        parsedAppointments.Add(appointment.Key, appointment.Value);
                    }
                }
            }

            //what we display to the user in the calendar view
            dbHelp.setAppointments(appointments);
            var apptArray = from row in parsedAppointments
                            select new
                            {
                                id = row.Key,
                                type = row.Value["type"],
                                start = Convert.ToDateTime(row.Value["start"].ToString()).ToLocalTime(),
                                end = Convert.ToDateTime(row.Value["end"].ToString()).ToLocalTime(),
                                customer = row.Value["customerName"]
                            };
            connection.Close();
            return apptArray.ToArray();

        }


        private void WeekRadio_CheckedChanged(object sender, EventArgs e)
        {
            updateCalendar();
        }



        private void RefreshButton_Click(object sender, EventArgs e)
        {
            updateCalendar();
        }

        private void ApptByMonthButton_Click(object sender, EventArgs e)
        {
            Form apptByMonth = new ApptByMonth();
            apptByMonth.Owner = this;
            apptByMonth.Show();
            this.Hide();
        }

        private void AppointmentsByConsultant_Click(object sender, EventArgs e)
        {
            Form apptByConsult = new ApptByConsult();
            apptByConsult.Owner = this;
            apptByConsult.Show();
            this.Hide();
        }

        private void AppointmentsByCustomer_Click(object sender, EventArgs e)
        {
            Form apptByCustomer = new ApptByCustomer();
            apptByCustomer.Owner = this;
            apptByCustomer.Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Record.logOut(dbHelp.getUserName());
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            Form addUser = new AddUser();
            addUser.Owner = this;
            addUser.Show();
            this.Hide();
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            Form editUser = new EditUser();
            editUser.Owner = this;
            editUser.Show();
            this.Hide();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            Form deleteUser = new DeleteUser();
            deleteUser.Owner = this;
            deleteUser.Show();
            this.Hide();
        }

        private void AppointmentCountByType_Click(object sender, EventArgs e)
        {
            Form apptCountByType = new ApptCountByType();
            apptCountByType.Owner = this;
            apptCountByType.Show();
            this.Hide();
        }

        public void update_customers()
        {
            string query = "SELECT * FROM CUSTOMER";
            MySqlConnection conn = new MySqlConnection(dbHelp.connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            customer_dt = new DataTable("customers");
            customer_dt.Load(cmd.ExecuteReader());

            dgv_customers.DataSource = customer_dt;
        }
    }
}
