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

        private string[] doctors;
        public UserDoctorList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            time.Text = listBox2.SelectedItem.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            date.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctor.Text = listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//request button
        {
            request req = new request();
        }

        private void button2_Click_1(object sender, EventArgs e)//cancel button
        {
            MainMenu m = new MainMenu();
            ActiveForm.Hide();
            m.Show();

         }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MainMenu m = new MainMenu();
            ActiveForm.Hide();
            m.Show();
        }
    }


    internal class request

    {
        private string[] doctors;
        int patientID = -1;
        int doctorID = -1;
        int schedulerID;
        DateTime dateTime;
        String reason;
        
        public void requestAppointment()
        { 
            string id;

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                request myRequest = new request();


                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM wheelerRequest WHERE requestID = 1";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql,
                conn);
                //cmd.Parameters.AddWithValue("@requestID", s);
                MySqlDataReader myReader = cmd.ExecuteReader();
                myReader.Close();
                if (myReader.Read())
                {
                    patientID = int.Parse(myReader["patientID"].ToString());
                    doctorID = int.Parse(myReader["doctorID"].ToString());
                    id = myReader["ID"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public string[] getDoctors() {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                string sql = "SELECT name FROM wheelerdoctor where doctorID =";
                sql.Concat(doctorID.ToString());

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                doctors = new string[myReader.FieldCount];
                for (int i = 0; i<myReader.FieldCount; i++)
                {
                    doctors[i] = myReader["doctor"].ToString();
                }
                
                myReader.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return doctors;
            }
        }
    }

