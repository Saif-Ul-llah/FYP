﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace doc_ceare
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\as comp\\OneDrive\\Documents\\Visual Studio 2017\\Projects\\Doctor Appiont\\Doctor Appiont\\Appoint.mdf\";Integrated Security=True";
        public Form2()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Insert data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL command with parameterized query
                    string sql = "INSERT INTO Doctors (first_name,last_name, email_address, password, confirm_password, phone_number,Specilization,Address,Experience) " +
                                 "VALUES             (@Param1, @Param2, @Param3, @Param4, @Param5, @Param6, @Param7, @Param8, @Param9)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // Add parameter values
                    command.Parameters.AddWithValue("@Param1", firstname.Text);
                    command.Parameters.AddWithValue("@Param2", lastname.Text);
                    command.Parameters.AddWithValue("@Param3", email.Text);
                    command.Parameters.AddWithValue("@Param4", pas.Text);
                    command.Parameters.AddWithValue("@Param5", cpas.Text);
                    command.Parameters.AddWithValue("@Param6", phone.Text);
                    command.Parameters.AddWithValue("@Param7", speic.Text);
                    command.Parameters.AddWithValue("@Param8", address.Text);
                    command.Parameters.AddWithValue("@Param9", exp.Text);

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

        private void BackToFirstScreenToDrSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            Doctor_Appiont.FScreen back = new Doctor_Appiont.FScreen();
            back.Show();
        }
    }
}
