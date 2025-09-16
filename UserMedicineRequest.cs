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
    public partial class UserMedicineRequest : Form
    {
        public UserMedicineRequest()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            listBox1.Items.Add("Amoxicillin");
            RxName.Text = "Amoxicillin";
            DrName.Text = "Dr. Doe";
            date.Text = "08/12/2025";
            purpose.Text = "Ear Infection";


        }

        private void UserMedicineRequest_Load(object sender, EventArgs e)
        {

        }

        
        private void drNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}
