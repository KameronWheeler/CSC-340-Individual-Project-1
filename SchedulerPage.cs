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
        }

        private void SchedulerPage_Load(object sender, EventArgs e)
        {

        }
    }
}
