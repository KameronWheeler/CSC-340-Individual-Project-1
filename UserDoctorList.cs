using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Individual_Project
{

    public partial class UserDoctorList : Form
    {

        private string[] doctors;
        public UserDoctorList()
        {
            InitializeComponent();




        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)//request button
        {
            request req = new request();
        }

        private void button2_Click_1(object sender, EventArgs e)//cancel button
        {
            MainMenu m = new MainMenu();
            ActiveForm.Hide();
            m.Show();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MainMenu m = new MainMenu();
            ActiveForm.Hide();
            m.Show();
        }
    }


}

