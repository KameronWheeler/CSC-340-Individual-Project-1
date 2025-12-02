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
    public partial class ClerkViewHistoricalBills : Form
    {
        List<PaymentInfo> payments = new List<PaymentInfo>();
        public ClerkViewHistoricalBills()
        {
            InitializeComponent();
            reload();

        }

        private void ClerkViewHistoricalBills_Load(object sender, EventArgs e)
        {
            
        }

        private void reload()
        {
            requestList.Items.Clear();
            payments.Clear();
            string connStr = "server = csitmariadb.eku.edu; user = student; database = csc340_db; port = 3306; password = Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT b.*, u.name FROM wheeler_bills b inner join wheeler_users u on b.patientID = u.ID WHERE paid = 1";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                PaymentInfo p = new PaymentInfo(
                    Convert.ToInt32(rdr["appointmentID"]),
                    Convert.ToInt32(rdr["doctorID"]),
                    Convert.ToInt32(rdr["patientID"]),
                    DateTime.Parse(rdr["date"].ToString()),
                    Decimal.Parse(rdr["cost"].ToString()),
                    Decimal.Parse(rdr["paymentAmount"].ToString()),
                    rdr["name"].ToString()
                    );
                payments.Add(p);

            }

            foreach (PaymentInfo p in payments)
            {
                requestList.Items.Add(p.name);
                Console.WriteLine(p.name);
            }
        }

        public class PaymentInfo
        {   //paymentAttempted bit will always be true if this class is being used

            public int appointmentID { get; set; }

            public int doctorID { get; set; }

            public int patientID { get; set; }

            public string name { get; set; }

            public DateTime appointmentDate { get; set; }

            public decimal amountDue { get; set; }

            public decimal ammountPaid { get; set; }

            public PaymentInfo(int AppointmentID, int DoctorID, int PatientID, DateTime AppointmentDate, decimal AmountDue, decimal AmountPaid, string Name)
            {
                appointmentDate = AppointmentDate;
                doctorID = DoctorID;
                patientID = PatientID;
                appointmentID = AppointmentID;
                amountDue = AmountDue;
                ammountPaid = AmountPaid;
                name = Name;
            }

        }


        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            var c = Application.OpenForms.OfType<ClerkMenu>().FirstOrDefault();
            if (c != null)
            {
                c.Show();
            }
            this.Close();
        }

        private void MainMenuButton_Click_1(object sender, EventArgs e)
        {
            var c = Application.OpenForms.OfType<ClerkMenu>().FirstOrDefault();
            if (c != null)
            {
                c.Show();
            }
            this.Close();
        }

        private void requestList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = requestList.SelectedIndex;
            PaymentInfo selectedPayment = payments[selectedIndex];
            patientNameBox.Text = selectedPayment.name;
            amountDueBox.Text = selectedPayment.amountDue.ToString("C");
            amountPaidBox.Text = selectedPayment.ammountPaid.ToString("C");
            appointmentDateBox.Text = selectedPayment.appointmentDate.ToString().Substring(0, 10);

        }
    }
}
