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
        int patientID;
        int doctorID;
        int schedulerID;
        DateTime dateTime;
        String reason;

        public void requestAppointment()
        {
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
                if (myReader.Read())
                {
                    patientID = myReader["patientID"].ToString();
                    doctorID = myReader["doctorID"].ToString();
                    textBox3.Text = myReader["ID"].ToString();
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
