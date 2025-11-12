using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class SchedulerViewSchedule : Form
    {
        public SchedulerViewSchedule()
        {
            InitializeComponent();
            listBox1.Items.Add("10:00am Dr. Thomas - Cataract Surgery");
            listBox1.Items.Add("10:15am Dr. Smith - Dental Checkup");
            listBox1.Items.Add("10:15am Dr. Johnson - Physical Therapy");
            listBox1.Items.Add("11:00am Dr. Brown - Cardiology Consultation");
            listBox1.Items.Add("11:30am Dr. Davis - Dermatology Appointment");
            listBox1.Items.Add("01:00pm Dr. Wilson - Neurology Follow-up");

        }

        private void SchedulerViewSchedule_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateBox.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
    }
}
