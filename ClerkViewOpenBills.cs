using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class ClerkViewOpenBills : Form
    {
        private List<PaymentInfo> payments = new List<PaymentInfo>();

        public ClerkViewOpenBills()
        {
            InitializeComponent();
            reload();
        }

        private void ClerkViewOpenBills_Load(object sender, EventArgs e)
        {
        }

        private void reload()
        {
            requestList.Items.Clear();
            payments.Clear();

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT b.*, u.name 
                                   FROM wheeler_bills b 
                                   INNER JOIN wheeler_users u ON b.patientID = u.ID 
                                   WHERE paid = 0";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            PaymentInfo p = new PaymentInfo(
                                Convert.ToInt32(rdr["appointmentID"]),
                                Convert.ToInt32(rdr["doctorID"]),
                                Convert.ToInt32(rdr["patientID"]),
                                DateTime.Parse(rdr["date"].ToString()),
                                Decimal.Parse(rdr["cost"].ToString()),
                                rdr["name"].ToString()
                            );
                            payments.Add(p);
                        }
                    }
                }

                foreach (PaymentInfo p in payments)
                {
                    requestList.Items.Add(p.name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bills: " + ex.Message);
            }
        }

        public class PaymentInfo
        {
            public int appointmentID { get; set; }
            public int doctorID { get; set; }
            public int patientID { get; set; }
            public string name { get; set; }
            public DateTime appointmentDate { get; set; }
            public decimal amountDue { get; set; }

            public PaymentInfo(int AppointmentID, int DoctorID, int PatientID, DateTime AppointmentDate, decimal AmountDue, string Name)
            {
                appointmentDate = AppointmentDate;
                doctorID = DoctorID;
                patientID = PatientID;
                appointmentID = AppointmentID;
                amountDue = AmountDue;
                name = Name;
            }
        }

        private void MainMenuButton_Click_2(object sender, EventArgs e)
        {
            var c = Application.OpenForms.OfType<ClerkMenu>().FirstOrDefault();
            if (c != null)
            {
                c.Show();
            }
            this.Close();
        }

        private void requestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (requestList.SelectedIndex >= 0)
            {
                PaymentInfo selectedPayment = payments[requestList.SelectedIndex];
                patientNameBox.Text = selectedPayment.name;
                amountDueBox.Text = selectedPayment.amountDue.ToString("C");
                appointmentDateBox.Text = selectedPayment.appointmentDate.ToShortDateString();
            }
        }
    }
}
