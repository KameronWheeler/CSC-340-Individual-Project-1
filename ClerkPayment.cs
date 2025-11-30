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
    public partial class ClerkPayment : Form
    {
        public ClerkPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClerkProcessPayment cp = new ClerkProcessPayment();
            this.Hide();
            cp.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SharedData.ClearData();
            LoginPage l = new LoginPage();
            l.ShowDialog();
            this.Close();
        }
    }
}
