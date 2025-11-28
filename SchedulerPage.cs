using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class SchedulerPage : Form
    {
        List<Appointment> appointments;
        public SchedulerPage()
        {
            InitializeComponent();
            appointments = new List<Appointment>();//List to hold appointments related to items in appointment listbox
        }

        private void SchedulerPage_Load(object sender, EventArgs e)
        {
            
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "SELECT r.*, u.name as patientName FROM wheelerrequest r inner join wheeler_users u ON r.patientID = u.ID WHERE confirmation = 0;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appt = new Appointment(
                            Convert.ToInt32(reader["requestID"]),
                            DateTime.Parse(reader["date"].ToString()),
                            reader["patientName"].ToString(),
                            reader["reason"].ToString(),
                            Convert.ToInt32(reader["patientID"]),
                            Convert.ToInt32(reader["doctorID"]),
                            DateTime.Parse(reader["time"].ToString())
                        );

                        listBox1.Items.Add(appt.Name);
                        appointments.Add(appt);
                    }
                }
                conn.Close();
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)//approve appointment button
        {
            String sql;
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                string connStr = "server = csitmariadb.eku.edu; user = student; database = csc340_db; port = 3306; password = Maroon@21?;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                sql = "UPDATE wheelerrequest SET schedulerID = @schedulerID, confirmation = 1 WHERE requestID = @requestID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@requestID", appointments[selectedIndex].requestID);
                cmd.Parameters.AddWithValue("@schedulerID", SharedData.userID);
                cmd.ExecuteNonQuery();
                conn.Close();
                listBox1.Items.RemoveAt(selectedIndex);
            }
        }

        private void DenyButton_Click(object sender, EventArgs e)//reject appointment button
        {
            String sql;
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                string connStr = "server = csitmariadb.eku.edu; user = student; database = csc340_db; port = 3306; password = Maroon@21?;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                sql = "UPDATE wheeler_schedule s INNER JOIN wheelerrequest r ON r.appointmentID = s.scheduleID SET s.isBooked = 0 where r.appointmentID = s.scheduleID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                sql = "DELETE FROM wheelerrequest WHERE requestID = @requestID;";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@requestID", appointments[selectedIndex].requestID);
                cmd.ExecuteNonQuery();

                

                conn.Close();   
                listBox1.Items.RemoveAt(selectedIndex);

            }

        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            apptDetails.Clear();
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {

                apptDetails.AppendText("Patient Name: " + appointments[selectedIndex].Name + Environment.NewLine);
                apptDetails.AppendText("Appointment Date: " + appointments[selectedIndex].Date.ToShortDateString() + Environment.NewLine);
                apptDetails.AppendText("Appointment Time: " + appointments[selectedIndex].Time.ToShortTimeString() + Environment.NewLine);
                apptDetails.AppendText("Reason: " + appointments[selectedIndex].Description + Environment.NewLine);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<SchedulerMenu>().First().Show();
            this.Hide();
        }
        
        private class Appointment //all appointments in this class will have the same confirmation status and will have null shcedulerID's until confirmed
        {
            public int requestID { get; set; } //requestID in the database

            public DateTime Date { get; set; } //date of the appointment

            public DateTime Time { get; set; } //time of the appointment

            public string Name { get; set; } //patient name

            public string Description { get; set; } //reason for the appointment

            public int doctorID { get; set; } //doctor assigned to the appointment

            public int patientID { get; set; } //patient assigned to the appointment

            public Appointment(int appointmentID, DateTime date, string name, string description, int patientID, int doctorID, DateTime time)
            {
                requestID = appointmentID;
                Date = date;
                Time = time;
                Name = name;
                Description = description;
                this.patientID = patientID;
                this.doctorID = doctorID;


            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(patientNameTextBox.Text))
            {
                listBox1.Items.Clear();
                string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText ="SELECT r.*, u.name as patientName, s.startTime as time FROM wheelerrequest r inner join wheeler_users u ON r.patientID = u.ID INNER JOIN wheeler_schedule s ON r.appointmentID = s.scheduleID WHERE confirmation = 0 AND INSTR(u.name, @enteredName);";
                    cmd.Parameters.AddWithValue("@enteredName", patientNameTextBox.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appt = new Appointment(
                                Convert.ToInt32(reader["requestID"]),
                                DateTime.Parse(reader["date"].ToString()),
                                reader["patientName"].ToString(),
                                reader["reason"].ToString(),
                                Convert.ToInt32(reader["patientID"]),
                                Convert.ToInt32(reader["doctorID"]),
                                DateTime.Parse(reader["time"].ToString())
                             
                            );

                            listBox1.Items.Add(appt.Name);
                            appointments.Add(appt);
                        }
                    }
                    conn.Close();
                }
            }
            else
            {
                listBox1.Items.Clear();
                string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT r.*, u.name as patientName, s.startTime as time FROM wheelerrequest r inner join wheeler_users u ON r.patientID = u.ID INNER JOIN wheeler_schedule s ON r.appointmentID = s.scheduleID WHERE confirmation = 0;";
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appt = new Appointment(
                                Convert.ToInt32(reader["requestID"]),
                                DateTime.Parse(reader["date"].ToString()),
                                reader["patientName"].ToString(),
                                reader["reason"].ToString(),
                                Convert.ToInt32(reader["patientID"]),
                                Convert.ToInt32(reader["doctorID"]),
                                DateTime.Parse(reader["time"].ToString())
                            );

                            listBox1.Items.Add(appt.Name);
                            appointments.Add(appt);
                        }
                    }
                    conn.Close();
                }
            }


            
        }
    }
}
