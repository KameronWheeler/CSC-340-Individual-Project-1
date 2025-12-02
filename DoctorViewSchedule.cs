using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class DoctorViewSchedule : Form
    {
        public DoctorViewSchedule()
        {
            InitializeComponent();
            updateSQL();
        }

        private void DoctorViewSchedule_Load(object sender, EventArgs e)
        {
            
        }

        private void updateSQL()
        {
            listBox1.Items.Clear();
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            //code to update list box by date
            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                String sql = "SELECT d.name as name, r.* FROM wheelerrequest r INNER JOIN wheelerdoctor d ON r.doctorID = @doctorID WHERE confirmation = 1 AND date = @date;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", selectedDate);
                cmd.Parameters.AddWithValue("@doctorID", SharedData.userID);
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr["name"].ToString() + " - " + DateTime.Parse(rdr["time"].ToString()));
                }

                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<DoctorMenu>().First().Show();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            listBox1.Items.Clear();
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            //code to update list box by date
            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                String sql = "SELECT * FROM wheelerrequest WHERE confirmation = 1 AND date = @date;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", selectedDate);
                cmd.Parameters.AddWithValue("@doctorID", SharedData.userID);
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    String dateString = DateTime.Parse(rdr["date"].ToString()).ToString().Substring(0, 10);
                    String timeString = DateTime.Parse(rdr["time"].ToString()).ToString("HH:mm");
                    listBox1.Items.Add(dateString + " - " + timeString);
                    Console.WriteLine(rdr["requestID"]);
                }

                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
