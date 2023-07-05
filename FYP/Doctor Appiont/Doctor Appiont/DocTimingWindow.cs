using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace doc_ceare
{
    public partial class DocTimingWindow : UserControl
    {
        private List<TimeSpan> appointmentTimings;
        string doctorId ;
        string userId = "";


        public DocTimingWindow(string Email)
        {
            InitializeComponent();
            doctorId = Email;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parse the input values
            TimeSpan startTimeOfDoc = TimeSpan.Parse(textBox1.Text);
            TimeSpan endTimeOfDoc = TimeSpan.Parse(textBox2.Text);
            TimeSpan breakStarteTimeOfDoc = TimeSpan.Parse(textBox3.Text);
            TimeSpan breakEndTimeOfDoc = TimeSpan.Parse(textBox4.Text);
            TimeSpan appointmentDuration = TimeSpan.FromMinutes(30);
            string selectedDay =dateTimePicker1.Value.ToString(); // Get the selected day from comboBox1
            string price = textBox5.Text;
            

            // Create a list to store the appointment timings
            appointmentTimings = new List<TimeSpan>();

            // Generate the appointment timings
            TimeSpan currentAppointmentTime = startTimeOfDoc;

            while (currentAppointmentTime + appointmentDuration <= endTimeOfDoc)
            {
                if (currentAppointmentTime < breakStarteTimeOfDoc || currentAppointmentTime >= breakEndTimeOfDoc)
                {
                    appointmentTimings.Add(currentAppointmentTime);
                }

                currentAppointmentTime = currentAppointmentTime.Add(appointmentDuration);
            }

            // Bind the appointment timings to the DataGridView
            dataGridView1.DataSource = ConvertToDataTable(appointmentTimings, dateTimePicker1.Value.ToString(),price);

            // Save the data to the database
           SaveAppointmentTimingsToDatabase(appointmentTimings,dateTimePicker1.Value.ToString(),price, doctorId, userId);
        }

        private DataTable ConvertToDataTable(List<TimeSpan> timings, string selectedDay, string price)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Day", typeof(string));
            dataTable.Columns.Add("Start Time", typeof(TimeSpan));
            dataTable.Columns.Add("End Time", typeof(TimeSpan));
            dataTable.Columns.Add("Price", typeof(string));
            foreach (var timing in timings)
            {
                TimeSpan endTime = timing.Add(TimeSpan.FromMinutes(30)); // Assuming each appointment has a duration of 30 minutes
                dataTable.Rows.Add(selectedDay, timing, endTime, price);
            }

            return dataTable;
        }


        private void SaveAppointmentTimingsToDatabase(List<TimeSpan> timings, string selectedDay, string price, string doctorId, string userId)
        {
            // Replace the connection string with your own
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\as comp\OneDrive\Documents\Visual Studio 2017\Projects\Doctor Appiont\Doctor Appiont\Appoint.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (var timing in timings)
                {
                    string query = "INSERT INTO AppointmentTimings (StartTime, EndTime, DayOfWeek, Price, doc_id, user_id) VALUES (@StartTime, @EndTime, @DayOfWeek, @Price, @DoctorId, @UserId)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StartTime", timing.ToString()); // Convert TimeSpan to string representation
                    command.Parameters.AddWithValue("@EndTime", timing.Add(TimeSpan.FromMinutes(30)).ToString()); // Assuming each appointment has a duration of 30 minutes
                    command.Parameters.AddWithValue("@DayOfWeek", selectedDay);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@DoctorId", doctorId);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
