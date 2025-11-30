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

namespace Individual_Project
{
    public partial class DoctorMenu : Form
    {
        public DoctorMenu()
        {
            InitializeComponent();
            label1.Text = "Welcome " + SharedData.name;
        }

        private void button4_Click(object sender, EventArgs e)//view appointments
        {
            DoctorViewSchedule d = new DoctorViewSchedule();
            this.Hide();
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorMedicineRequest d = new DoctorMedicineRequest();
            this.Hide();
            d.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SharedData.ClearData();
            LoginPage l = new LoginPage();
            l.Show();
            this.Hide();
            this.Close();
        }
    }
}
