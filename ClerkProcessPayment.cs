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
    public partial class ClerkProcessPayment : Form
    {
        public ClerkProcessPayment()
        {
            InitializeComponent();
            requestList.Items.Add("John Doe");
            patientName.Text = "John Doe";
            textBox1.Text = "08/13/2024";
            textBox2.Text = "11:00am";
            textBox3.Text = "$150.00";
        }

        private void ClerkProcessPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
