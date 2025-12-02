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
            label1.Text = "Welcome " + SharedData.name;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDoctorList u = new UserDoctorList();
            
            u.ShowDialog();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserViewAppointments u = new UserViewAppointments();
            u.ShowDialog();
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            UserMedicineRequest r = new UserMedicineRequest();
            
            r.ShowDialog();
            
        }

        private void billPay_Click(object sender, EventArgs e)
        {
            PayBills pb = new PayBills();
            
            pb.ShowDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SharedData.ClearData();
            LoginPage l = new LoginPage();
            l.ShowDialog();
            this.Close();
            
        }
    }
}
