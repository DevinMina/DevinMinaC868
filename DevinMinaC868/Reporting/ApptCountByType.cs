using System;
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
            IDictionary<string, object> dictionary = dbHelp.appointmentByTypeCount();
            cleanings.Text = dictionary["General Consultation"].ToString();
            //cavities.Text = dictionary["cavities"].ToString();
            //wisdomTeeth.Text = dictionary["wisdomTeeth"].ToString();
            //consultations.Text = dictionary["consultation"].ToString();
            //rootCanals.Text = dictionary["rootCanals"].ToString();
            //other.Text = dictionary["other"].ToString();
            label1.Text = DateTime.Now.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }


    }
}
