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
    public partial class ApptByMonth : Form
    {
        public ApptByMonth()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString();
        }

        private void TypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string type = typeComboBox.SelectedItem.ToString();
            IDictionary<string, object> dictionary = dbHelp.appointmentByTypeMonth(type);
            jan.Text = dictionary["Jan"].ToString();
            feb.Text = dictionary["Feb"].ToString();
            mar.Text = dictionary["Mar"].ToString();
            apr.Text = dictionary["Apr"].ToString();
            may.Text = dictionary["May"].ToString();
            jun.Text = dictionary["Jun"].ToString();
            jul.Text = dictionary["Jul"].ToString();
            aug.Text = dictionary["Aug"].ToString();
            sep.Text = dictionary["Sep"].ToString();
            oct.Text = dictionary["Oct"].ToString();
            nov.Text = dictionary["Nov"].ToString();
            dec.Text = dictionary["Feb"].ToString();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
