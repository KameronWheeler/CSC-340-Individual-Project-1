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
        public UserMedicineRequest()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            listView1.View = View.List;



        }

        private void UserMedicineRequest_Load(object sender, EventArgs e)
        {
            String connString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            try
            {
                conn.Open();
                String sql = "select * FROM wheeler_prescriptions WHERE patientID = @userID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", SharedData.userID);
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["medicine"].ToString());

                    listView1.Items.Add(item);

                }



                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void drNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
