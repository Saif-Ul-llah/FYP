using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows;

using System.Data.SqlClient;

namespace doc_ceare
{
    public partial class Form4 : Form
    {
        // Define your connection string
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\as comp\\OneDrive\\Documents\\Visual Studio 2017\\Projects\\Doctor Appiont\\Doctor Appiont\\Appoint.mdf\";Integrated Security=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog class
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to only allow certain file types
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path of the selected file
                string filePath = openFileDialog.FileName;

                // Read the contents of the file into a byte array
                byte[] fileBytes = File.ReadAllBytes(filePath);

                // Upload the file to the desired location (e.g. a web server)
                // ...

               
            }
        }

        private void GoBackToFirstSreen_Click(object sender, EventArgs e)
        {
            this.Close();
            Doctor_Appiont.FScreen back = new Doctor_Appiont.FScreen();
            back.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insert data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL command with parameterized query
                    string sql = "INSERT INTO Users (first_name,last_name, email_address, password, confirm_password, phone_number) " +
                                 "VALUES (@Param1, @Param7, @Param2, @Param4, @Param5, @Param3)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // Add parameter values
                    command.Parameters.AddWithValue("@Param1", textBox1.Text);
                    command.Parameters.AddWithValue("@Param2", textBox2.Text);
                    command.Parameters.AddWithValue("@Param7", textBox4.Text);
                    command.Parameters.AddWithValue("@Param3", textBox5.Text);
                    command.Parameters.AddWithValue("@Param4", textBox3.Text);
                    command.Parameters.AddWithValue("@Param5", textBox6.Text);
                    //command.Parameters.AddWithValue("@Param6", fileBytes);

                    // Execute the command
                    command.ExecuteNonQuery();

                    MessageBox.Show("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting data: " + ex.Message);
                }
            }
        }
    }
}
