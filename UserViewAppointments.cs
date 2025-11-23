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
using System.Windows.Forms.VisualStyles;

namespace Individual_Project
{
    public partial class UserViewAppointments : Form
    {
        List<int> doctorIDs = new List<int>();
        List<int> appointmentIDs = new List<int>();
        int currentAppointmentID;
        public UserViewAppointments()
        {
            InitializeComponent();
            //button2.Enabled = false;//disabled until an appointment is selected
            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                String sql = "SELECT * FROM wheelerrequest WHERE patientID = @patientID AND confirmation = 1;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@patientID", SharedData.userID);
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    listBox1.Items.Add(DateTime.Parse(rdr["date"].ToString()));
                    doctorIDs.Add(Convert.ToInt32(rdr["doctorID"]));
                    appointmentIDs.Add(Convert.ToInt32(rdr["requestID"]));
                }

                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UserViewAppointments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Main menu button
        {
            MainMenu m = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            this.Hide();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                // First update schedule
                using (var updateCmd = new MySqlCommand())
                {
                    updateCmd.Connection = conn;
                    updateCmd.CommandText = @"
        UPDATE wheeler_schedule s
        INNER JOIN wheelerrequest r ON s.scheduleID = r.appointmentID
        SET s.isBooked = FALSE
        WHERE r.requestID = @requestID;";
                    updateCmd.Parameters.AddWithValue("@requestID", currentAppointmentID);

                    int updateRows = updateCmd.ExecuteNonQuery();
                    Console.WriteLine("Updated " + updateRows + " schedule rows");
                }

                // Then delete from wheelerrequest
                using (var deleteCmd = new MySqlCommand())
                {
                    deleteCmd.Connection = conn;
                    deleteCmd.CommandText = "DELETE FROM wheelerrequest WHERE requestID = @requestID;";
                    deleteCmd.Parameters.AddWithValue("@requestID", currentAppointmentID);

                    int deleteRows = deleteCmd.ExecuteNonQuery();
                    Console.WriteLine("Deleted " + deleteRows + " request rows");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAppointmentID = appointmentIDs[listBox1.SelectedIndex];
            
            Console.WriteLine("current appointmentID: " + currentAppointmentID);
            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            
            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT s.scheduleID, s.doctorID, s.startTime, s.date, u.name
                           FROM wheeler_schedule s
                           INNER JOIN wheelerrequest r ON s.scheduleID = r.appointmentID
                           INNER JOIN wheeler_users u ON s.doctorID = u.ID
                           WHERE requestID = @requestID;";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@requestID", currentAppointmentID);

                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                drBox.Text = rdr["name"].ToString();

                                if (DateTime.TryParse(rdr["startTime"]?.ToString(), out DateTime start))
                                    timeBox.Text = start.ToString("hh:mm tt");

                                if (DateTime.TryParse(rdr["date"]?.ToString(), out DateTime date))
                                    dateBox.Text = date.ToString("MM/dd/yyyy");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointment: " + ex.Message);
            }

        }
    }
}
