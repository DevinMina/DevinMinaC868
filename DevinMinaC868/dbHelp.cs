using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DevinMinaC868
{
    class dbHelp
    {
        private static int userID;
        private static string userName;
        

        public static string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public static string getConnectionString()
        {
            return connectionString;
        }
        public static int getUserID()
        {
            return userID;
        }
        public static void setUserID(int currUserID)
        {
            userID = currUserID;
        }
        public static string getUserName()
        {
            return userName;
        }
        public static void setUserName(string currentUsername)
        {
            userName = currentUsername;
        }
        private static Dictionary<int, Hashtable> currentAppts = new Dictionary<int, Hashtable>();
        public static Dictionary<int, Hashtable> getAppointments()
        {
            return currentAppts;
        }
        public static void setAppts(Dictionary<int, Hashtable> appointments)
        {
            currentAppts = appointments;
        }

        public static int userCheck(string user, string password)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT userID, userName FROM user where userName = '{user}' AND password = '{password}'", conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                setUserID(Convert.ToInt32(reader[0]));
                setUserName(Convert.ToString(reader[1]));
                reader.Close();
                conn.Close();
                return 1;
            }
            conn.Close();
            return 0;
        }

        public static DateTime getTime()
        {
            return DateTime.Now.ToUniversalTime();
        }
        public static string dateSqlFormat(DateTime dateValue)
        {
            string sqlDateTime = dateValue.ToString("yyyy-MM-dd HH:mm");
            return sqlDateTime;
        }


        //creates new customer
        public static void createCustomer(int id, string name, int addressId, int active, DateTime dateTime, string user)
        {
            string sqlDate = dateSqlFormat(dateTime);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();

            var query = "INSERT into customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{id}', '{name}', '{addressId}', '{active}', '{dateSqlFormat(dateTime)}', '{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }
        public static void createUser(int userId, string userName, string password, int active, DateTime dateTime, string user)
        {
            string sqlDate = dateSqlFormat(dateTime);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();

            var query = "INSERT into user (userId, userName, password, active, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{userId}', '{userName}', '{password}', '{active}', '{dateSqlFormat(dateTime)}', '{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }
        public static void updateUser(IDictionary<string, object> dictionary)
        {
            string user = getUserName();
            DateTime utc = getTime();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //update userTable
            MySqlTransaction trans = conn.BeginTransaction();
            var userQuery = $"UPDATE user" +
                $" SET userName = '{dictionary["userName"]}', password = '{dictionary["password"]}', active = '{dictionary["active"]}', lastUpdateBy = '{user}'" +
                $" WHERE userId = '{dictionary["userId"]}'";
            MySqlCommand cmd = new MySqlCommand(userQuery, conn);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }
        //updates customer
        public static void updateCustomer(IDictionary<string, object> dictionary)
        {
            string user = getUserName();
            DateTime utc = getTime();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //update country table
            MySqlTransaction trans = conn.BeginTransaction();
            var countryQuery = $"UPDATE country" +
                $" SET country = '{dictionary["country"]}', lastUpdateBy = '{user}'" +
                $" WHERE countryId = '{dictionary["countryId"]}'";
            MySqlCommand cmd = new MySqlCommand(countryQuery, conn);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();

            //update city table
            trans = conn.BeginTransaction();
            var cityQuery = $"UPDATE city" +
                $" SET city = '{dictionary["city"]}', lastUpdateBy = '{user}'" +
                $" WHERE cityId = '{dictionary["cityId"]}'";
            cmd.CommandText = cityQuery;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();

            //update address table
            trans = conn.BeginTransaction();
            var addressQuery = $"UPDATE address" +
                $" SET address = '{dictionary["address"]}', lastUpdateBy = '{user}', postalCode = '{dictionary["postalCode"]}', phone = '{dictionary["phone"]}'" +
                $" WHERE addressID = '{dictionary["addressId"]}'";
            cmd.CommandText = addressQuery;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();

            //update customer table
            trans = conn.BeginTransaction();
            var customerQuery = $"UPDATE customer" +
                $" SET customerName = '{dictionary["customerName"]}', lastUpdateBy = '{user}', active = '{dictionary["active"]}'" +
                $" WHERE customerId = '{dictionary["customerId"]}'";
            cmd.CommandText = customerQuery;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }
        public static void deleteCustomer(IDictionary<string, object> dictionary)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //delete from customer table
            var custQuery = $"DELETE FROM customer WHERE customerId = '{dictionary["customerId"]}'";
            MySqlCommand cmd = new MySqlCommand(custQuery, conn);
            MySqlTransaction trans = conn.BeginTransaction();
            cmd.CommandText = custQuery;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();

            //delete from address table
            trans = conn.BeginTransaction();
            var addressQuery = $"DELETE FROM address WHERE addressId = '{dictionary["addressId"]}'";
            cmd.CommandText = addressQuery;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();

            //delete from city table
            trans = conn.BeginTransaction();
            var cityQuery = $"DELETE FROM city WHERE cityId = '{dictionary["cityId"]}'";
            cmd.CommandText = cityQuery;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();

            //delete from country table
            trans = conn.BeginTransaction();
            var countryQuery = $"DELETE FROM country WHERE countryId = '{dictionary["countryId"]}'";
            cmd.CommandText = countryQuery;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();

        }
        //gets ID for records
        public static int getID(string table, string id)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            var query = $"SELECT max({id}) FROM {table}";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                if (reader[0] == DBNull.Value)
                {
                    return 0;
                }
                return Convert.ToInt32(reader[0]);
            }
            return 0;
        }
        //create country record
        public static int createCountry(string country)
        {
            int countryID = getID("country", "countryID") + 1;
            string user = getUserName();
            DateTime utc = getTime();

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();
            var query = "INSERT into country (countryID, country, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{countryID}', '{country}', '{dateSqlFormat(utc)}', '{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
            return countryID;
        }
        //creates city record
        public static int createCity(int countryID, string city)
        {
            int cityID = getID("city", "cityID") + 1;
            string user = getUserName();
            DateTime utc = getTime();

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();
            var query = "INSERT into city (cityID, city, countryId, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{cityID}', '{city}', '{countryID}', '{dateSqlFormat(utc)}', '{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
            return cityID;
        }
        //creates address record
        public static int createAddress(int cityID, string address, string zipCode, string phone)
        {
            int addressID = getID("address", "addressID") + 1;
            string user = getUserName();
            DateTime utc = getTime();

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();
            var query = "INSERT into address (addressID, address, cityID, postalCode, phone, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{addressID}', '{address}', '{cityID}', '{zipCode}', '{phone}', '{dateSqlFormat(utc)}', '{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
            return addressID;
        }

        //take customerId and return a list of all customer information from the database.
        public static List<KeyValuePair<string, object>> searchCustomer(int customerID)
        {
            var list = new List<KeyValuePair<string, object>>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = $"SELECT * FROM customer where customerId = {customerID}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {

                if (reader.HasRows)
                {
                    reader.Read();
                    list.Add(new KeyValuePair<string, object>("customerId", reader[0]));
                    list.Add(new KeyValuePair<string, object>("customerName", reader[1]));
                    list.Add(new KeyValuePair<string, object>("addressId", reader[2]));
                    list.Add(new KeyValuePair<string, object>("active", reader[3]));
                    reader.Close();
                }

                else
                {

                    return null;
                }
                var addressID = list.First(kvp => kvp.Key == "addressId").Value;
                var addressQuery = $"SELECT * FROM address WHERE addressId = {addressID}";
                cmd.CommandText = addressQuery;
                cmd.Connection = conn;
                MySqlDataReader addressReader = cmd.ExecuteReader();
                if (addressReader.HasRows)
                {
                    addressReader.Read();
                    list.Add(new KeyValuePair<string, object>("address", addressReader[1]));
                    list.Add(new KeyValuePair<string, object>("cityId", addressReader[3]));
                    list.Add(new KeyValuePair<string, object>("postalCode", addressReader[4]));
                    list.Add(new KeyValuePair<string, object>("phone", addressReader[5]));
                    addressReader.Close();
                }

                var cityID = list.First(kvp => kvp.Key == "cityId").Value;
                var cityQuery = $"SELECT * FROM city WHERE cityId = {cityID}";
                cmd.CommandText = cityQuery;
                cmd.Connection = conn;
                MySqlDataReader cityReader = cmd.ExecuteReader();
                if (cityReader.HasRows)
                {
                    cityReader.Read();
                    list.Add(new KeyValuePair<string, object>("city", cityReader[1]));
                    list.Add(new KeyValuePair<string, object>("countryId", cityReader[2]));
                    cityReader.Close();
                }

                var countryID = list.First(kvp => kvp.Key == "countryId").Value;
                var countryQuery = $"SELECT * FROM country WHERE countryId = {countryID}";
                cmd.CommandText = countryQuery;
                cmd.Connection = conn;
                MySqlDataReader countryReader = cmd.ExecuteReader();
                if (countryReader.HasRows)
                {
                    countryReader.Read();
                    list.Add(new KeyValuePair<string, object>("country", countryReader[1]));
                    countryReader.Close();
                }
                return list;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception);
                return null;
            }
        }
        public static List<KeyValuePair<string, object>> searchUser(int userId)
        {
            var list = new List<KeyValuePair<string, object>>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = $"SELECT * FROM user where userId = {userID}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {

                if (reader.HasRows)
                {
                    reader.Read();
                    list.Add(new KeyValuePair<string, object>("userId", reader[0]));
                    list.Add(new KeyValuePair<string, object>("userName", reader[1]));
                    list.Add(new KeyValuePair<string, object>("password", reader[2]));
                    list.Add(new KeyValuePair<string, object>("active", reader[3]));
                    reader.Close();
                }
                return list;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception);
                return null;
            }
        }
        public static void deleteUser(string userId)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //delete from customer table
            var userQuery = $"DELETE FROM user WHERE userId = '{userId}'";
            MySqlCommand cmd = new MySqlCommand(userQuery, conn);
            MySqlTransaction trans = conn.BeginTransaction();
            cmd.CommandText = userQuery;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }

        //creates a new appointment tied to a customer
        public static void createAppt(int custID, string title, string description, string location, string contact, string type, DateTime start, DateTime end)
        {
            int appointID = getID("appointment", "appointmentId") + 1;
            int userID = 1;
            DateTime utc = getTime();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();
            var query = $"INSERT into appointment (appointmentId, customerId, title, userId, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdateBy)" +
                $"VALUES ('{appointID}', '{custID}', '{title}', '{getUserID()}', '{description}', '{location}', '{contact}', '{type}', 'not needed', '{dateSqlFormat(start)}', '{dateSqlFormat(end)}', '{dateSqlFormat(utc)}', '{userID}','{userID}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }



        //takes a dictionary of data supplied from text fields in form and saves to database
        public static void updateAppt(IDictionary<string, object> dictionary)
        {
            string user = getUserName();
            DateTime utc = getTime();
            DateTime start = Convert.ToDateTime(dictionary["start"]);
            DateTime end = Convert.ToDateTime(dictionary["end"]);

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();
            var query = $"UPDATE appointment SET customerId = '{dictionary["customerId"]}', title = '{dictionary["title"]}', description = '{dictionary["description"]}', location = '{dictionary["location"]}', contact = '{dictionary["contact"]}', type = '{dictionary["type"]}',  start = '{dateSqlFormat(start.ToUniversalTime())}', end = '{dateSqlFormat(end.ToUniversalTime())}', url = '{dictionary["url"]}', lastUpdate = '{dateSqlFormat(utc)}',  lastUpdateBy = '{user}' WHERE appointmentId = '{dictionary["appointmentId"]}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();

        }
        //returns a list with information of appointment based on appointmentId
        public static List<KeyValuePair<string, object>> getApptList(int appointmentId)
        {
            var list = new List<KeyValuePair<string, object>>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = $"SELECT * FROM appointment WHERE appointmentId = {appointmentId}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    list.Add(new KeyValuePair<string, object>("appointmentId", reader[0]));
                    list.Add(new KeyValuePair<string, object>("customerId", reader[1]));
                    list.Add(new KeyValuePair<string, object>("title", reader[3]));
                    list.Add(new KeyValuePair<string, object>("description", reader[4]));
                    list.Add(new KeyValuePair<string, object>("location", reader[5]));
                    list.Add(new KeyValuePair<string, object>("contact", reader[6]));
                    list.Add(new KeyValuePair<string, object>("type", reader[7]));
                    list.Add(new KeyValuePair<string, object>("start", reader[9]));
                    list.Add(new KeyValuePair<string, object>("end", reader[10]));
                    reader.Close();
                }
                else
                {
                    return null;
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public static List<KeyValuePair<string, object>> getUserList(int userId)
        {
            var list = new List<KeyValuePair<string, object>>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = $"SELECT * FROM user WHERE userId = {userId}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    list.Add(new KeyValuePair<string, object>("userId", reader[0]));
                    list.Add(new KeyValuePair<string, object>("userName", reader[1]));
                    list.Add(new KeyValuePair<string, object>("password", reader[3]));
                    list.Add(new KeyValuePair<string, object>("enabled", reader[4]));
                    list.Add(new KeyValuePair<string, object>("location", reader[5]));
                    reader.Close();
                }
                else
                {
                    return null;
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //returns true if customer has appointments.
        public static bool checkAppts(string custID)
        {
            Console.WriteLine(custID);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = $"SELECT * FROM appointment where customerID = '{custID}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                return true;
            }
            return false;
        }
        //returns dictionary of next appointment
        public static Dictionary<string, object> getNextAppt()
        {
            Dictionary<string, object> nextAppt = new Dictionary<string, object>();
            string utcOffset = (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).ToString().Substring(0, 6));
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = $"SELECT type,  start, (SELECT customerName from customer where customerId = appointment.customerId) as 'Name' from appointment where start > now() order by start limit 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                nextAppt.Add("type", reader[0]);
                nextAppt.Add("start", Convert.ToDateTime(reader[1]).ToLocalTime());
                nextAppt.Add("name", reader[2]);
            }
            return nextAppt;
        }
        //returns the amount of times the given appointment time overlaps with existing appointments
        public static int overlap(DateTime start, DateTime end)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = $"SELECT count(*) FROM `appointment` WHERE (('{dateSqlFormat(start.ToUniversalTime())}' > start and '{dateSqlFormat(start.ToUniversalTime())}' < end) or ('{dateSqlFormat(end.ToUniversalTime())}'> start and '{dateSqlFormat(end.ToUniversalTime())}' < end)) and end > now() order by  start limit 1;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string count = reader[0].ToString();
                int result = count == "0" ? 0 : 1;
                return result;
            }
            return 0;
        }
        public static bool apptOverlaps(DateTime start, DateTime end)
        {
            foreach (var app in dbHelp.getAppointments().Values)
            {
                if (start < DateTime.Parse(app["end"].ToString()) && DateTime.Parse(app["start"].ToString()) < end)
                    return true;
            }
            return false;
        }

        //deletes appointments based on customer ID 
        public static void deleteCustAppts(string custID)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = $"DELETE FROM appointment WHERE customerId = '{custID}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlTransaction trans = conn.BeginTransaction();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }

        //deletes appointments based on appointment ID
        public static void deleteAppt(IDictionary<string, object> dictionary)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = $"DELETE FROM appointment WHERE appointmentId = '{dictionary["appointmentId"]}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlTransaction trans = conn.BeginTransaction();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
        }

        public static Dictionary<string, object> apptsByMonth(string type)
        {
            Dictionary<string, object> report = new Dictionary<string, object>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = "SELECT DISTINCT " +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 1) as 'Jan'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 2) as 'Feb'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 3) as 'Mar'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 4) as 'Apr'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 5) as 'May'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 6) as 'Jun'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 7) as 'Jul'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 8) as 'Aug'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 9) as 'Sep'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 10) as 'Oct'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 11) as 'Nov'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 12) as 'Dec'" +
                " from appointment;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                report.Add("Jan", reader[0]);
                report.Add("Feb", reader[1]);
                report.Add("Mar", reader[2]);
                report.Add("Apr", reader[3]);
                report.Add("May", reader[4]);
                report.Add("Jun", reader[5]);
                report.Add("Jul", reader[6]);
                report.Add("Aug", reader[7]);
                report.Add("Sep", reader[8]);
                report.Add("Oct", reader[9]);
                report.Add("Nov", reader[10]);
                report.Add("Dec", reader[11]);
            }
            return report;

        }
        public static DataTable getApptListByUser(string id)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = $"SELECT (select customerName from customer where customerId = appointment.customerId) as 'Customer', start as 'Start Time', end as 'End Time', location as 'Location', title as 'Title', type as 'Type' FROM appointment where createdBy = '{id}' ORDER BY start;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }
            conn.Close();
            return dataTable;
        }
        public static DataTable getApptListByCustomer(string id)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = $"SELECT title as 'Title', start as 'Start Time', end as 'End Time', location as 'Location', contact as 'Contact', type as 'Type' FROM appointment where customerId = '{id}' ORDER BY start;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }
            conn.Close();
            return dataTable;
        }
        public static Dictionary<string, object> apptCountByType()
        {
            Dictionary<string, object> report = new Dictionary<string, object>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var query = "SELECT DISTINCT " +
                $" (select count(type) from appointment where type = 'Accounts Payable') as 'Accounts Payable'," +
                $" (select count(type) from appointment where type = 'Accounts Receivable') as 'Accounts Receivable'," +
                $" (select count(type) from appointment where type = 'Payroll Processing') as 'Payroll Processing'," +
                $" (select count(type) from appointment where type = 'Consultation') as 'Consultation'," +
                $" (select count(type) from appointment where type = 'Auditing') as 'Auditing'," +
                $" (select count(type) from appointment where type = 'Other') as 'Other'" +
                $" from appointment";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                report.Add("accounts_payable", reader[0]);
                report.Add("accounts_receivable", reader[1]);
                report.Add("payroll_processing", reader[2]);
                report.Add("consultation", reader[3]);
                report.Add("auditing", reader[4]);
                report.Add("other", reader[5]);
            }
            return report;

        }
    }
}
