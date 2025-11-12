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
    public partial class SchedulerPage : Form
    {
        public SchedulerPage()
        {
            InitializeComponent();
            patientNameTextBox.Text = "James";
            listBox1.Items.Add("James Peterson");
            listBox1.Items.Add("James Patterson");
            listBox1.Items.Add("James Murphy");
            AppointmentHistoryListBox.Items.Add("08/12/2020");
            AppointmentHistoryListBox.Items.Add("09/15/2020");
            AppointmentHistoryListBox.Items.Add("10/20/2022");
            AppointmentHistoryListBox.Items.Add("12/07/2024");
        }

        private void SchedulerPage_Load(object sender, EventArgs e)
        {

        }
    }
}
