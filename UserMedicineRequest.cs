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
            String connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            try
            {
                conn.Open();
                String sql = "select p.*, u.name as name FROM wheeler_prescriptions p inner join wheeler_users u ON p.doctorID = u.ID WHERE patientID = @userID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", SharedData.userID);
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listView1.Items.Add(rdr["medicine"].ToString());//add medicine name to list view
                    medicines.Add(new Medicine(
                        rdr["medicine"].ToString(), rdr["name"].ToString(), 
                        DateTime.Parse(rdr["datePrescribed"].ToString()))); //add medicines to local list

                   

                }



                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            ListViewItem selected = new ListViewItem();

            String connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            try
            {

                //FIXME find the correct requestID to update
                conn.Open();
                String sql = "UPDATE wheeler_prescriptions SET requested = true, approved = false, rejected = false WHERE requestID = @requestID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@requestID", selected.ToString());
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            public Medicine(String name, String prescriber, DateTime date)
            {
                this.Name = name;
                this.drName = prescriber;
                this.DatePrescribed = date;
                
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = listView1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                RxName.Text = medicines[selectedIndex].Name;
                DrName.Text = medicines[selectedIndex].drName;
                date.Text = medicines[selectedIndex].DatePrescribed.ToShortDateString();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
