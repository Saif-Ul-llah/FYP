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
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\as comp\OneDrive\Documents\Visual Studio 2017\Projects\Doctor Appiont\Doctor Appiont\Appoint.mdf;Integrated Security = True"; // Replace with your actual connection string
        private SqlConnection connection;
        String email;
        public UserHomeControl(String Email)
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            email = Email;
        }

        private void UserHomeControl_Load(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM [dbo].[Users] WHERE [email_address] ="+email;
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                label2.Text = "" + reader["first_name"];
                label4.Text ="" + reader["last_name"];
                label9.Text = "" + reader["phone_number"];
                label10.Text = "" + reader["email_address"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading doctor data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
    }

