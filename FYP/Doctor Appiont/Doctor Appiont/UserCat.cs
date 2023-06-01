using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doctor_Appiont
{
    public partial class UserCat : UserControl
    {
         private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\as comp\OneDrive\Documents\Visual Studio 2017\Projects\Doctor Appiont\Doctor Appiont\Appoint.mdf;Integrated Security = True"; // Replace with your actual connection string
         private SqlConnection connection;
         FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
        //private FlowLayoutPanel flowLayoutPanel;
        Panel mainPanel = new Panel();

        public UserCat()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void dentist(object sender, EventArgs e)
        {
          
            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'dentist'";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

               
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);

                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);
//
            //    doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();

                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Cardiology(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'cardiologist'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

                
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;


                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;


                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

          //      doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Neurology(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'neurologist'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

              
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

                
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Nephrology(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'nephrology'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

                
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

          //      doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Radiology(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'radiology'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

              
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

             //   doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Psychiatrist(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'psychiatrists'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

               
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);
//
            //    doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Orthopedic(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'orthopedic'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

               // doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Ophthalmology(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'ophthalmologist'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

               
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

             //   doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void ENT(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'ENT'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

                
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

              //  doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Oncology(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'oncology'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

               
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

               // doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Skin(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'skin specilist'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

               
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

               // doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        private void Pulmonology(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [dbo].[Doctors] WHERE [Specilization] = 'pulmonology'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //   int panelSpacing = 30; // Extra spacing between panels

              
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.Dock = DockStyle.Top;
                flowLayoutPanel.AutoSize = true;

                //back button to categeries
                Button back = new Button();
                back.Click += new EventHandler(Back);
                back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
                back.Text = "Back";
                back.Height = 30;
                back.ForeColor = Color.White;
                back.FlatStyle = FlatStyle.Flat;
                back.Dock = DockStyle.Top;

                while (reader.Read())
                {
                    PictureBox docPicshow = new PictureBox();
                    docPicshow.Dock = DockStyle.Top;
                    // Load the image using docPicshow.Image = Image.FromFile(filePath);

                    // int r = 46, g = 134, a = 193;
                    Button bookingButton = new Button();
                    bookingButton.Click += new EventHandler(getBookingScreen);
                    bookingButton.FlatStyle = FlatStyle.Flat;
                    bookingButton.Dock = DockStyle.Bottom;
                    bookingButton.Text = "Booking";
                    bookingButton.ForeColor = Color.White;
                    bookingButton.FlatAppearance.BorderSize = 0;
                    bookingButton.Height = 30;
                    bookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));

                    Panel mainPanel = new Panel();
                    mainPanel.BackColor = Color.White;
                    mainPanel.Width = 180;
                    mainPanel.Height = 350;
                    mainPanel.Margin = new Padding(10, 50, 0, 10);


                    Panel labelPanel = new Panel();
                    labelPanel.AutoSize = true;
                    labelPanel.Dock = DockStyle.Fill;

                    Label nameLabel = new Label();
                    nameLabel.Text = "Name: " + reader["first_name"] + " " + reader["last_name"];
                    nameLabel.Location = new Point(10, 220);
                    nameLabel.AutoSize = true;

                    Label specializationLabel = new Label();
                    specializationLabel.Text = "Specialization: " + reader["Specilization"];
                    specializationLabel.Location = new Point(10, 240);
                    specializationLabel.AutoSize = true;

                    Label experienceLabel = new Label();
                    experienceLabel.Text = "Experience: " + reader["Experience"];
                    experienceLabel.Location = new Point(10, 260);
                    experienceLabel.AutoSize = true;

                    labelPanel.Controls.Add(nameLabel);
                    labelPanel.Controls.Add(specializationLabel);
                    labelPanel.Controls.Add(experienceLabel);

                    mainPanel.Controls.Add(docPicshow);
                    mainPanel.Controls.Add(labelPanel);
                    mainPanel.Controls.Add(bookingButton);


                    flowLayoutPanel.Controls.Add(mainPanel);
                }

                flowLayoutPanel.Controls.Add(back);
                this.Controls.Remove(panel1);
                this.Controls.Remove(panel2);
                this.Controls.Remove(panel3);
                this.Controls.Remove(panel4);
                this.Controls.Remove(panel5);
                this.Controls.Remove(panel6);
                this.Controls.Remove(panel7);
                this.Controls.Remove(panel8);
                this.Controls.Remove(panel9);
                this.Controls.Remove(panel10);
                this.Controls.Remove(panel11);
                this.Controls.Remove(panel12);

               // doc_ceare.UserFisrtScreen list = new doc_ceare.UserFisrtScreen();
                this.Controls.Add(flowLayoutPanel);
                this.AutoScroll = true;

                reader.Close();
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

        // booking screen show button
        private void getBookingScreen(object sender, EventArgs e)
        {

            Doctor_Appiont.UserBookingWindowControl1 bookingSrc = new Doctor_Appiont.UserBookingWindowControl1();
            Form bookingForm = new Form();
            bookingForm.StartPosition = FormStartPosition.CenterScreen;
            bookingForm.Height = 375;
            bookingForm.Width = 225;
            bookingForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            bookingForm.Controls.Add(bookingSrc);
            bookingForm.ShowDialog();

        }

        // back button to categeries
        private void Back(object sender,EventArgs e)
        {
            //flowLayoutPanel.Controls.Remove(mainPanel);
            this.Controls.Remove(flowLayoutPanel);
            //this.Destroy(flowLayoutPanel);
            
            // Check if the panel exists in the FlowLayoutPanel
            if (flowLayoutPanel.Controls.Contains(mainPanel))
            {
                // Remove the panel from the FlowLayoutPanel
                flowLayoutPanel.Controls.Remove(mainPanel);
            }

            this.Controls.Add(panel1);
            this.Controls.Add(panel2);
            this.Controls.Add(panel3);
            this.Controls.Add(panel4);
            this.Controls.Add(panel5);
            this.Controls.Add(panel6);
            this.Controls.Add(panel7);
            this.Controls.Add(panel8);
            this.Controls.Add(panel9);
            this.Controls.Add(panel10);
            this.Controls.Add(panel11);
            this.Controls.Add(panel12);

        
        }
    }
}
