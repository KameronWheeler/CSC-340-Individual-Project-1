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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDoctorList u = new UserDoctorList();
            ActiveForm.Hide();
            u.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserViewAppointments u = new UserViewAppointments();
            ActiveForm.Hide();
            u.Show();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserMedicineRequest r = new UserMedicineRequest();
            ActiveForm.Hide();
            r.Show();
        }
    }
}
