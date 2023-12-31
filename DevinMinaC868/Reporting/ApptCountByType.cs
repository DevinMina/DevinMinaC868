﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevinMinaC868.Reporting
{
    public partial class ApptCountByType : Form
    {
        public ApptCountByType()
        {
            InitializeComponent();
            IDictionary<string, object> dictionary = dbHelp.apptCountByType();
            accountsPayable.Text = dictionary["accounts_payable"].ToString();
            accountsReceivable.Text = dictionary["accounts_receivable"].ToString();
            payrollProcessing.Text = dictionary["payroll_processing"].ToString();
            consultations.Text = dictionary["consultation"].ToString();
            auditing.Text = dictionary["auditing"].ToString();
            other.Text = dictionary["other"].ToString();
            date.Text = DateTime.Now.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
