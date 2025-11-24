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
    public partial class SchedulerMenu : Form
    {
        public SchedulerMenu()
        {
            InitializeComponent();
            label1.Text = "Welcome " + SharedData.name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SchedulerViewSchedule sv = new SchedulerViewSchedule();
            this.Hide();
            sv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SchedulerPage sv = new SchedulerPage();
            this.Hide();
            sv.ShowDialog();
        }

        private void SchedulerMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
