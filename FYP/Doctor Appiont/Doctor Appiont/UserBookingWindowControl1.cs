using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Doctor_Appiont
{
    public partial class UserBookingWindowControl1 : UserControl
    {


        private SqlConnection connection;
        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\\Users\\as comp\\OneDrive\\Documents\\Visual Studio 2017\\Projects\\doc ceare\\doc ceare\\Appoint.mdf; Integrated Security = True"; // Replace with your actual connection string
        public UserBookingWindowControl1()
        {
           
            InitializeComponent();
          
        }


        //booking button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while sending data in appointment table : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
