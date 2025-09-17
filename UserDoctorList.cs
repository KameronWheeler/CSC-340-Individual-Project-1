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
    public partial class UserDoctorList : Form
    {
        public UserDoctorList()
        {
            InitializeComponent();
            listBox1.Items.Add("Dr. John Doe");
            listBox1.Items.Add("Dr. Jane Smith");
            listBox2.Items.Add("11:00am");
            listBox2.Items.Add("2:00pm");
            listBox2.Items.Add("3:30pm");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            time.Text = listBox2.SelectedItem.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            date.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctor.Text = listBox1.SelectedItem.ToString();
        }
    }
}
