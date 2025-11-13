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
    public partial class UserViewAppointments : Form
    {
        public UserViewAppointments()
        {
            InitializeComponent();
            listBox1.Items.Add("09/25/2025");
            listBox1.Items.Add("10/20/2026");
            drBox.Text = "Dr. Joan";
            dateBox.Text = "09/25/2025";
            timeBox.Text = "11:00am";
            purposeBox.Text = "Checkup";

        }

        private void UserViewAppointments_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MainMenu m = new MainMenu();
            ActiveForm.Hide();
            m.Show();
        }
    }
}
