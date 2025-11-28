using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Individual_Project
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            loginButton.Enabled = false;
            label1.Text = "";
            this.AcceptButton = loginButton;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            anyTextBox_TextChanged(sender, e);
        }

        private void anyTextBox_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(usernameTextBox.Text) || String.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                loginButton.Enabled = false;
            }
            else
            {
                loginButton.Enabled = true;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string name = "";

            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT ID, username, privileges, password, name FROM wheeler_users WHERE username = @username AND password = @password";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // store important info
                    SharedData.userID = Convert.ToInt32(reader["ID"]);
                    if (password == reader["password"].ToString())
                    {
                        // Successful login
                        SharedData.userName = reader["username"].ToString();
                        SharedData.permissionLevel = Convert.ToInt32(reader["privileges"]);
                        SharedData.name = reader["name"].ToString();
                        if (SharedData.permissionLevel == 1)
                        {
                            // Patient
                            MainMenu userPage = new MainMenu();
                            this.Hide();
                            userPage.ShowDialog();
                            this.Close();
                        }
                        else if(SharedData.permissionLevel == 2)
                        {
                            // Doctor
                            DoctorMenu doctorPage = new DoctorMenu();
                            this.Hide();
                            doctorPage.ShowDialog();
                            this.Close();
                        }
                        else if(SharedData.permissionLevel == 3)
                        {
                            // Clerk
                            ClerkPayment clerkPayment = new ClerkPayment();
                            this.Hide();
                            clerkPayment.ShowDialog();
                            this.Close();
                        }
                        else if (SharedData.
                            permissionLevel == 4)
                        {
                            // Scheduler
                           SchedulerMenu schedulerMenu = new SchedulerMenu();
                            this.Hide();
                            schedulerMenu.ShowDialog();
                            this.Close();
                        }
                        else 
                        {
                            label1.Text = "Account error: please contact system administrator.";
                        }


                    }
                    else
                    {
                        // Failed login
                        label1.Text = "Username/Password incorrect.";
                    }
                }
                else
                {
                    // Failed login
                    label1.Text = "Username/Password incorrect.";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            anyTextBox_TextChanged(sender, e);
        }

    }
}
