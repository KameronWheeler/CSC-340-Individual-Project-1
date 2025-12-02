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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Individual_Project
{

    public partial class UserDoctorList : Form
    {
        List<int> doctorIDs = new List<int>();
        int scheduleID = 0;
        public UserDoctorList()
        {
            InitializeComponent();
            int userID = SharedData.userID;
            button1.Enabled = false;

            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT DISTINCT doctorList.name as name, request.doctorID as doctorID FROM wheelerrequest request " +
                "inner join wheeler_users doctorList on request.doctorID = doctorList.ID WHERE request.patientID = @patientID;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@patientID", userID);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        int index = 0;
                        while (rdr.Read())
                        {
                            doctorsList.Items.Add(rdr["name"].ToString());
                            doctorIDs.Add(Convert.ToInt32(rdr["doctorID"]));
                            Console.WriteLine(rdr["name"].ToString());
                            Console.WriteLine(doctorIDs[index]);
                            index++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null && listBox2.SelectedIndex >= 0)
            {
                object selectedItem = listBox2.SelectedItem;
                string timeString = Convert.ToString(selectedItem);

                try
                {
                    time.Text = timeString;
                }
                catch
                {
                    // Handle control type issues
                }

                // Enable button if both doctor and time are selected
                if (doctorsList.SelectedIndex >= 0)
                {
                    button1.Enabled = true;
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar cal = (MonthCalendar)sender;
            DateTime selectedDate = cal.SelectionStart;

            string dateString = string.Format("{0:MM/dd/yyyy}", selectedDate);

            try
            {
                date.Text = dateString;
            }
            catch
            {
                // Handle control type issues
            }

            if (doctorsList.SelectedIndex >= 0)
            {
                LoadAvailableTimes();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorsList.SelectedIndex >= 0)
            {
                doctor.Text = doctorsList.Items[doctorsList.SelectedIndex].ToString();
                LoadAvailableTimes();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void LoadAvailableTimes()
        {
            listBox2.Items.Clear();
            listBox2.DisplayMember = "";

            if (doctorsList.SelectedIndex < 0)
                return;

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "SELECT startTime, scheduleID FROM wheeler_schedule WHERE doctorID = @doctorID AND isBooked = FALSE AND date = @selectedDate;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@doctorID", doctorIDs[doctorsList.SelectedIndex]);
                // Use DATE format for MySQL DATE type
                cmd.Parameters.AddWithValue("@selectedDate", monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd"));

                using (var rdr = cmd.ExecuteReader())
                {
                    bool hasSlots = false;
                    while (rdr.Read())
                    {
                        // Get TIME value from MySQL (stored as TimeSpan in .NET)
                        TimeSpan startTime = (TimeSpan)rdr["startTime"];
                        TimeSpan endTime = startTime.Add(TimeSpan.FromHours(1));
                        
                        // Format as HH:mm - HH:mm
                        string timeSlot = string.Format("{0:hh\\:mm} - {1:hh\\:mm}", startTime, endTime);

                        scheduleID = Convert.ToInt32(rdr["scheduleID"]);

                        listBox2.Items.Add(timeSlot);
                        hasSlots = true;
                    }

                    if (!hasSlots)
                    {
                        listBox2.Items.Add("No available times");
                    }
                }

                button1.Enabled = (listBox2.Items.Count > 0 && listBox2.Items[0].ToString() != "No available times");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading times: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (doctorsList.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }

            if (listBox2.SelectedIndex < 0 || listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid time slot.");
                return;
            }

            string selectedTimeStr = listBox2.SelectedItem.ToString();
            if (selectedTimeStr == "No available times")
            {
                MessageBox.Show("Please select a valid time slot.");
                return;
            }

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // Parse the selected time slot to get the start time
                    string[] timeParts = selectedTimeStr.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (timeParts.Length >= 1)
                    {
                        string startTimeStr = timeParts[0].Trim();
                        
                        // Parse time string to TimeSpan for SQL TIME type
                        TimeSpan startTime = TimeSpan.Parse(startTimeStr);

                        // Get the selected date for SQL DATE type
                        DateTime selectedDate = monthCalendar1.SelectionStart.Date;
                        int selectedDoctorID = doctorIDs[doctorsList.SelectedIndex];

                        // Insert into wheelerrequest with DATE and TIME types
                        cmd.CommandText = "INSERT INTO wheelerrequest (appointmentID,patientID, doctorID, date, time, reason, confirmation) " +
                            "VALUES (@appointmentID, @patientID, @doctorID, @date, @startTime, @reason, FALSE);";

                        cmd.Parameters.AddWithValue("@patientID", SharedData.userID);
                        cmd.Parameters.AddWithValue("@doctorID", selectedDoctorID);
                        cmd.Parameters.AddWithValue("@appointmentID", scheduleID);
                        cmd.Parameters.AddWithValue("@reason", textBox1.Text);
                        // Use DATE format
                        cmd.Parameters.AddWithValue("@date", selectedDate.ToString("yyyy-MM-dd"));
                        // Use TIME format
                        cmd.Parameters.AddWithValue("@startTime", startTime.ToString(@"hh\:mm\:ss"));
                        cmd.Prepare();
                        
                        Console.WriteLine("Inserting - Date: " + selectedDate.ToString("yyyy-MM-dd") + ", Time: " + startTime.ToString(@"hh\:mm\:ss"));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Update the wheeler_schedule to mark the slot as booked
                        if (rowsAffected > 0)
                        {
                            using (var updateCmd = new MySqlCommand())
                            {
                                updateCmd.Connection = conn;
                                updateCmd.CommandText = "UPDATE wheeler_schedule SET isBooked = TRUE " +
                                    "WHERE doctorID = @doctorID AND startTime = @startTime AND date = @selectedDate;";
                               
                                updateCmd.Parameters.AddWithValue("@selectedDate", selectedDate.ToString("yyyy-MM-dd"));
                                updateCmd.Parameters.AddWithValue("@doctorID", selectedDoctorID);
                                updateCmd.Parameters.AddWithValue("@startTime", startTime.ToString(@"hh\:mm\:ss"));
                                
                                int updateRows = updateCmd.ExecuteNonQuery();
                                Console.WriteLine("Updated " + updateRows + " schedule rows");
                            }

                            MessageBox.Show("Appointment requested successfully!");
                            LoadAvailableTimes(); // Refresh the time slots
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid time format selected.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating appointment: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var m = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            if (m != null)
            {
                m.Show();
            }
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}