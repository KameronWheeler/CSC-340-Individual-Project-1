using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT id, username, permission_level FROM users WHERE username = @username AND password = @password";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // store important info
                    SharedData.userID = Convert.ToInt32(reader["userID"]);
                    if (password == reader["Password"].ToString())
                    {
                        // Successful login
                        SharedData.userName = reader["username"].ToString();
                        SharedData.permissionLevel = Convert.ToInt32(reader["permission_level"]);


                       
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
