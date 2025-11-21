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


        public DoctorMedicineRequest()
        {
            
            
            InitializeComponent();
            
        }

        private void drNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void DoctorMedicineRequest_Load(object sender, EventArgs e)
        {
            int doctorID = SharedData.userID;
            //stored locally
            int patientID = 0;
            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                String sql = "SELECT * FROM wheeler_prescriptions WHERE doctorID = '" + SharedData.userID + "' AND requested = 1;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@doctorID", SharedData.userID);
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();
                

                while (rdr.Read())
                {
                    requestList.Items.Add(int.Parse(rdr["requestID"].ToString()));
                    
                }
              
                
                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            try
            {
                string sql = "SELECT name FROM wheeler_users WHERE ID = '" + patientID + "';";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@doctorID", SharedData.userID);
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();

                
                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void requestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = "";
            if (requestList.SelectedIndex >= 0)
            {
                value = requestList.Items[requestList.SelectedIndex].ToString();
                // Proceed with parsing or SQL query
            }


            Console.WriteLine("current index: " + value);
            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                String sql = "SELECT p.requestID, p.doctorID, p.medicine, p.datePrescribed, p.number_Refills, " +
                    "u.name FROM wheeler_prescriptions p inner JOIN wheeler_users u ON p.doctorID = u.ID WHERE p.requested = 1 " +
                    "AND requestID = @requestID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@requestID", value);
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();


                if(rdr.Read())
                {
                    patientName.Text = rdr["name"].ToString();
                    MedicationName.Text = rdr["medicine"].ToString();
                    datePrescribed.Text = rdr["datePrescribed"].ToString().Substring(0,11);
                    numRefills.Text = rdr["number_Refills"].ToString();

                }


                rdr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
    }
}
