using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Individual_Project.ClerkProcessPayment;

namespace Individual_Project
{
    public partial class PayBills : Form
    {
        
        List<PaymentInfo> payments = new List<PaymentInfo>();

        public PayBills()
        {
            InitializeComponent();
            
            OpenBillsCheckbox.CheckOnClick = true;
            string connStr = "server = csitmariadb.eku.edu; user = student; database = csc340_db; port = 3306; password = Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * FROM wheeler_bills WHERE paymentAttempt = 0 AND patientID = @patientID AND paid = FALSE";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@patientID", SharedData.userID);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                PaymentInfo p = new PaymentInfo(
                    Convert.ToInt32(rdr["appointmentID"]),
                    Convert.ToInt32(rdr["doctorID"]),
                    Convert.ToInt32(rdr["patientID"]),
                    DateTime.Parse(rdr["date"].ToString()),
                    Decimal.Parse(rdr["cost"].ToString()),
                    Decimal.Parse(rdr["paymentAmount"].ToString())
                );
                payments.Add(p);

            }
            foreach (PaymentInfo p in payments)
            {
                OpenBillsCheckbox.Items.Add($"{p.appointmentDate}, Amount Due: {p.amountDue:C}");
            }

            
        }

        private void OpenBillsCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenBillsCheckbox.ClearSelected();
            decimal totalAmountDue = 0;
            foreach (int i in OpenBillsCheckbox.CheckedIndices)
            {
                totalAmountDue += Convert.ToDecimal(OpenBillsCheckbox.Items[i].ToString().Split('$')[1]);
            }
            totalLabel.Text = totalAmountDue.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal totalAmountDue = 0;
            foreach (int i in OpenBillsCheckbox.CheckedIndices)
            {
                totalAmountDue += Convert.ToDecimal(OpenBillsCheckbox.Items[i].ToString().Split('$')[1]);
            }

            PaymentInformation pi = new PaymentInformation(this);
            pi.amountDue = totalAmountDue;
            pi.ShowDialog();

        }

        private void PayBills_Load(object sender, EventArgs e)
        {

        }

        private void paymentHistoryButton_Click(object sender, EventArgs e)
        {
            string connStr = "server = csitmariadb.eku.edu; user = student; database = csc340_db; port = 3306; password = Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            conn.Open();
            using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT appointmentID, date, cost FROM wheeler_bills WHERE patientID = @patientID AND paid = 1";
                cmd.Parameters.AddWithValue("@patientID", SharedData.userID);
                using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                {
                    StringBuilder paymentHistory = new StringBuilder();
                    while (reader.Read())
                    {
                        paymentHistory.Clear();
                        DateTime paymentDate = reader.GetDateTime("date");
                        decimal amountPaid = reader.GetDecimal("cost");
                        paymentHistory.AppendLine($"{paymentDate.ToShortDateString()}, {amountPaid:C}");
                        historyView.Items.Add(paymentHistory.ToString());
                    }
                   
                    
                }
            }
            conn.Close();
        }

        public class PaymentInfo
        {

            //paymentAttempted bit will always be true if this class is being used



            public int appointmentID { get; set; }

            public int doctorID { get; set; }

            public int patientID { get; set; }

            public DateTime appointmentDate { get; set; }

            public decimal amountDue { get; set; }

            public decimal ammountPaid { get; set; }

            public PaymentInfo(int AppointmentID, int DoctorID, int PatientID, DateTime AppointmentDate, decimal AmountDue, decimal AmountPaid)
            {
                appointmentDate = AppointmentDate;
                doctorID = DoctorID;
                patientID = PatientID;
                appointmentID = AppointmentID;
                amountDue = AmountDue;
                ammountPaid = AmountPaid;
            }



        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MainMenu"].Show();
            this.Close();
        }
    }
}
