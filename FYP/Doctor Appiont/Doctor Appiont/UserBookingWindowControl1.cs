using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Doctor_Appiont
{
    public partial class UserBookingWindowControl1 : UserControl
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\as comp\OneDrive\Documents\Visual Studio 2017\Projects\Doctor Appiont\Doctor Appiont\Appoint.mdf;Integrated Security=True";
        private string userEmail;
        private string userMails;

        public UserBookingWindowControl1(string userEmail,string userMail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            userMails=userMail;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [dbo].[Doctors] WHERE [email_address] = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", userEmail);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label2.Text = reader["first_name"].ToString();
                            label7.Text = reader["Experience"].ToString();
                        }
                    }

                    string query1 = "SELECT StartTime, Price FROM AppointmentTimings WHERE [doc_id] = @Email";
                    SqlCommand command1 = new SqlCommand(query1, connection);
                    command1.Parameters.AddWithValue("@Email", userEmail);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command1))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboBox1.DataSource = dataTable;
                        comboBox1.DisplayMember = "StartTime";

                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow selectedRow = dataTable.Rows[0];
                            label5.Text = selectedRow["Price"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading doctor data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Booking button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the selected start time from the ComboBox
                    string selectedStartTime = comboBox1.Text;

                    // Perform the necessary operations to update the appointment in the database
                    string query = "UPDATE AppointmentTimings SET user_id = @UserId WHERE StartTime = @StartTime";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userMails);
                    command.Parameters.AddWithValue("@StartTime", selectedStartTime);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        this.Hide();
                        MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No appointment found for the selected start time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
