using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Individual_Project
{

    internal class request
    {
        private int patientID;
        private int doctorID;
        private int schedulerID;
        private DateTime dateTime;
        private String reason;


        public void setPatientID(int pID)
        {
            patientID = pID;
        }

        public void requestAppointment()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                request myRequest = new request();
                
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM wheelerRequest WHERE patientID = ";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql,
                conn);
                //cmd.Parameters.AddWithValue("@requestID", s);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    patientID = int.Parse(myReader["patientID"].ToString());
                    doctorID = int.Parse(myReader["doctorID"].ToString());
                    
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        

    }


}
}
