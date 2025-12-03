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
    public partial class DoctorMedicineRequest : Form
    {
        List<Prescription> medicineRequests = new List<Prescription>();

        public DoctorMedicineRequest()
        {


            InitializeComponent();
            acceptButton.Enabled = false;
            rejectButton.Enabled = false;

        }

        private void drNameLabel_Click(object sender, EventArgs e)
        {

        }
        private void reload()
        {
            requestList.Items.Clear();
            medicineRequests.Clear();
            int doctorID = SharedData.userID;

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT p.requestID, p.medicine, p.datePrescribed, p.number_Refills, 
                                  u.name AS name 
                           FROM wheeler_prescriptions p 
                           INNER JOIN wheeler_users u ON p.patientID = u.ID 
                           WHERE p.doctorID = @doctorID AND p.requested = 1;";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctorID", doctorID);

                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                               
                                // Keep local Prescription object list in sync
                                medicineRequests.Add(new Prescription(
                                    int.Parse(rdr["requestID"].ToString()),
                                    rdr["medicine"].ToString(),
                                    rdr["name"].ToString(),
                                    DateTime.Parse(rdr["datePrescribed"].ToString()),
                                    int.Parse(rdr["number_Refills"].ToString())
                                ));
                                requestList.Items.Add(rdr["medicine"].ToString());

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void DoctorMedicineRequest_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void requestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            acceptButton.Enabled = true;
            rejectButton.Enabled = true;
            var selected = medicineRequests[requestList.SelectedIndex];
            patientName.Text = selected.patientName;
            datePrescribed.Text = selected.datePrescribed.ToShortDateString();
            MedicationName.Text = selected.name;
            numRefills.Text = selected.numRefills.ToString();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            String connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            try
            {
                conn.Open();
                String sql = "UPDATE wheeler_prescriptions SET approved = TRUE, requested = false WHERE requestID = @requestID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@requestID", medicineRequests[requestList.SelectedIndex].requestID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Request Approved.");
                conn.Close();
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            String connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            try
            {
                conn.Open();
                String sql = "UPDATE wheeler_prescriptions SET rejected = TRUE, requested = false WHERE requestID = @requestID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@requestID", medicineRequests[requestList.SelectedIndex].requestID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Request Rejected.");
                conn.Close();
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["DoctorMenu"].Show();
            
        }

        public class Prescription
        {
            public int requestID {  get; set; }
            public string name {  get; set; }
            public string patientName { get; set; }
            public DateTime datePrescribed { get; set; }
            public int numRefills { get; set; }

            public Prescription(int requestID, string name, string patientName, DateTime prescribed, int numRefills)
            {
                this.requestID = requestID;
                this.name = name;
                this.patientName = patientName;
                this.datePrescribed = prescribed;
                this.numRefills = numRefills;
            }
        }
    }
}