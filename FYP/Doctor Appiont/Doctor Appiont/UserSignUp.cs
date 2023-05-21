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


namespace doc_ceare
{
    public partial class Form4 : Form
    {
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
    }
}
