using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace doc_ceare
{
    public partial class UserHomeControl : UserControl
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\as comp\\OneDrive\\Documents\\Visual Studio 2017\\Projects\\Doctor Appiont\\Doctor Appiont\\Appoint.mdf\";Integrated Security=True"; // Replace with your actual connection string
        private SqlConnection connection;
        private string email;
        private string Tb;
        public UserHomeControl(string Email ,string tb)
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString); // Assign connection to SqlConnection object
            email = Email; // Assign the passed email to the instance variable

            string query = "SELECT * FROM [dbo].[" + tb + "] WHERE [email_address] = @Email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            Tb = tb;
        }

        private void UserHomeControl_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[" + Tb + "] WHERE [email_address] = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@Email", email); // Assign email value to the parameter
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    label2.Text = " " + reader["first_name"];
                    label4.Text = " " + reader["last_name"];
                    label9.Text = " " + reader["phone_number"];
                    label10.Text = " " + reader["email_address"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
