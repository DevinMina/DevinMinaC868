﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevinMinaC868
{
    class Record
    {
        private static DateTime? time;
        public static void setTime(DateTime? Time)
        {
            time = Time;
        }
        public static DateTime? getTime()
        {
            return time;
        }
        public static void reminder()
        {
            try
            {
                var list = dbHelp.getNextAppt();
                IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                DateTime? currentTime = getTime();
                string type = dictionary["type"].ToString();
                DateTime? nextAppt = Convert.ToDateTime(dictionary["start"]);
                string name = dictionary["name"].ToString();
                if (currentTime != null && nextAppt != null)
                {
                    DateTime dateTime = currentTime.Value;
                    DateTime dateTime2 = nextAppt.Value;
                    string dateString = nextAppt.Value.ToString("h:mm tt");
                    TimeSpan diff = dateTime2.Subtract(dateTime);
                    if (diff.Minutes < 15)
                    {
                        MessageBox.Show("Reminder: You have a " + type + " appointment at " + dateString + " with " + name + "!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public static void logIn(string userName)
        {
            DateTime time = DateTime.Now.ToLocalTime();
            Dictionary<DateTime, string> dictionary = new Dictionary<DateTime, string>();
            dictionary.Add(time, userName);
            setTime(time);

            foreach (KeyValuePair<DateTime, string> keyValue in dictionary)
            {
                string record = string.Format("Login time = {0}, userName = {1}", keyValue.Key, keyValue.Value);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(record + Environment.NewLine);
                File.AppendAllText(Application.StartupPath + "_access_records.txt", stringBuilder.ToString());
                stringBuilder.Clear();
            }
        }
        public static void logOut(string userName)
        {
            Dictionary<DateTime, string> dictionary = new Dictionary<DateTime, string>();
            dictionary.Add(DateTime.Now, userName);


            foreach (KeyValuePair<DateTime, string> keyValue in dictionary)
            {
                string record = string.Format("Logout time = {0}, userName = {1}", keyValue.Key, keyValue.Value);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(record + Environment.NewLine);
                File.AppendAllText(Application.StartupPath + "_access_records.txt", stringBuilder.ToString());
                stringBuilder.Clear();
            }
        }
    }
}
