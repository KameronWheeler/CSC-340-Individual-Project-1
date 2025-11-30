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
    public partial class PaymentInformation : Form
    {
        private PayBills parentForm;
        public decimal amountDue;

        public PaymentInformation(PayBills parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void PaymentInformation_Load(object sender, EventArgs e)
        {
            totalLabel.Text = amountDue.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(cvvBox.Text) || String.IsNullOrEmpty(cardNumber.Text) || String.IsNullOrEmpty(expirationBox.Text))
            {
                if(String.ReferenceEquals(cvvBox.Text, "123") && String.ReferenceEquals(cardNumber.Text, "1234567890123456") && String.ReferenceEquals(expirationBox.Text, "12/34"))
                {
                    MessageBox.Show("Payment Successful! Amount Due: " + amountDue.ToString("C"));
                }
                else
                {
                    MessageBox.Show("Payment Failed! Please check your payment information and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all payment information fields.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
