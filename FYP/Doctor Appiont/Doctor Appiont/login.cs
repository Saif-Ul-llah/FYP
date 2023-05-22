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
        public Form3()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
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
            
            // Establish database connection
            string connectionString = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Construct the SQL query
                string query = "SELECT COUNT(*) FROM [dbo].[Users] WHERE [email_address] = @Email AND [password] = @Password";

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
                        this.Close();
                        doc_ceare.UserFisrtScreen user = new doc_ceare.UserFisrtScreen();
                        user.Show();
                        MessageBox.Show("Login successful.");

                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }
        }
    }
}
