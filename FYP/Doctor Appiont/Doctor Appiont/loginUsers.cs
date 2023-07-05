
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace doc_ceare
{
    public partial class Form3 : Form
    {
        private string tb;
        private bool isPasswordVisible = false;

        public Form3(string type)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            tb = type;

           
        }

        private void BackToFirstScreenToDrSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            Doctor_Appiont.FScreen back = new Doctor_Appiont.FScreen();
            back.Show();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            string email = textBox18.Text.Trim();
            string password = textBox19.Text.Trim();

              UserFisrtScreen user = new UserFisrtScreen(email ,tb);
              DoctorFisrtScreen doctor = new DoctorFisrtScreen(email, tb);

        // Establish database connection
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\as comp\\OneDrive\\Documents\\Visual Studio 2017\\Projects\\Doctor Appiont\\Doctor Appiont\\Appoint.mdf\";Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Construct the SQL query
                string query = "SELECT COUNT(*) FROM [dbo].[" + tb + "] WHERE [email_address] = @Email AND [password] = @Password";

                // Create a command object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameters
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the query
                    int result = (int)command.ExecuteScalar();
                 
                    
                    // Check the query result
                    if (result > 0)
                    {
                        // Login successful
                        this.Hide();
                        if (tb == "Users")
                        {
                            user.Show();
                        }
                        else
                        {
                            doctor.Show();
                        }
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid email or password.");
                    }
              
                }

              
            }
        }

        private void TogglePasswordVisibility()
        {
            if (isPasswordVisible)
            {
                textBox19.PasswordChar = '*'; // Set password character for hiding password
                isPasswordVisible = false;
            }
            else
            {
                textBox19.PasswordChar = '\0'; // Set no password character for visible password
                isPasswordVisible = true;
            }
        }

        
        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }
    }
}
