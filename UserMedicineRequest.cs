using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class UserMedicineRequest : Form
    {
        List<Medicine> medicines;

        public UserMedicineRequest()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void UserMedicineRequest_Load(object sender, EventArgs e)
        {
            medicines = new List<Medicine>();
            string connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT p.*, u.name AS name 
                                   FROM wheeler_prescriptions p 
                                   INNER JOIN wheeler_users u ON p.doctorID = u.ID 
                                   WHERE patientID = @userID;";
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@userID", SharedData.userID);

                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listView1.Items.Add(rdr["medicine"].ToString()); // ✅ keep your naming
                        medicines.Add(new Medicine(
                            rdr["medicine"].ToString(),
                            rdr["name"].ToString(),
                            DateTime.Parse(rdr["datePrescribed"].ToString()),
                            Convert.ToInt32(rdr["requestID"])) // ✅ include requestID
                        );
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var m = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            if (m != null)
            {
                m.Show();
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            int selectedIndex = listView1.SelectedIndex; // ✅ ListBox supports SelectedIndex
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select a prescription request first.");
                return;
            }

            int requestID = medicines[selectedIndex].RequestID;

            string connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE wheeler_prescriptions 
                                   SET requested = true, approved = false, rejected = false 
                                   WHERE requestID = @requestID;";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@requestID", requestID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Prescription request updated successfully.");
                        else
                            MessageBox.Show("No matching request found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            if (m != null)
            {
                m.Show();
            }
            this.Close();
        }

        public class Medicine
        {
            public string Name { get; set; }
            public string drName { get; set; }
            public DateTime DatePrescribed { get; set; }
            public int RequestID { get; set; } // ✅ Added

            public Medicine(string name, string prescriber, DateTime date, int requestID)
            {
                this.Name = name;
                this.drName = prescriber;
                this.DatePrescribed = date;
                this.RequestID = requestID;
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = listView1.SelectedIndex; // ✅ works for ListBox
            if (selectedIndex >= 0)
            {
                RxName.Text = medicines[selectedIndex].Name;
                DrName.Text = medicines[selectedIndex].drName;
                date.Text = medicines[selectedIndex].DatePrescribed.ToShortDateString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // optional custom drawing
        }
    }
}