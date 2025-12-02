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
    public partial class ClerkMenu : Form
    {
        public ClerkMenu()
        {
            InitializeComponent();
            NameLabel.Text = ("Welcome, " + SharedData.name.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClerkProcessPayment cp = new ClerkProcessPayment();
            
            cp.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SharedData.ClearData();
            LoginPage l = new LoginPage();
            l.ShowDialog();
            this.Close();
        }

        private void ClerkPayment_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClerkViewHistoricalBills hb = new ClerkViewHistoricalBills();
            hb.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClerkViewOpenBills ob = new ClerkViewOpenBills();
            ob.ShowDialog();
        }
    }
}
