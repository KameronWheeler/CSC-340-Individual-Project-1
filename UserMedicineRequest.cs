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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainMenu m = new MainMenu();
            m.Show();
        }
    }
}
