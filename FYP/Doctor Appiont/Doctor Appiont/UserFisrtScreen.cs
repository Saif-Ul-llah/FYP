using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace doc_ceare
{
    public partial class UserFisrtScreen : Form
    {
        private String Email;
        private UserHomeControl UserHomeControl;
        private Doctor_Appiont.UserCat userCat;
        private DataGridView dataGridView;

        public UserFisrtScreen(String email, String tb)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            Email = email;
            UserHomeControl = new UserHomeControl(Email, tb);
            userCat = new Doctor_Appiont.UserCat(Email);
            panel2.Controls.Add(UserHomeControl);
        }

        Doctor_Appiont.FScreen log = new Doctor_Appiont.FScreen();

        private void Button1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(dataGridView);
            this.panel2.Controls.Remove(userCat);
            panel2.Controls.Add(UserHomeControl);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(dataGridView);
            this.panel2.Controls.Remove(UserHomeControl);
            panel2.Controls.Add(userCat);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(userCat);
            this.panel2.Controls.Remove(UserHomeControl);

            string email = Email;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\as comp\OneDrive\Documents\Visual Studio 2017\Projects\Doctor Appiont\Doctor Appiont\Appoint.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT doc_id, StartTime, Price, DayOfWeek, EndTime FROM AppointmentTimings WHERE user_id = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    panel2.Controls.Clear();

                    dataGridView = new DataGridView();
                    dataGridView.DataSource = dataTable;
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Dock = DockStyle.Fill;

                    // Create the button column
                    DataGridViewButtonColumn printSlipColumn = new DataGridViewButtonColumn();
                    printSlipColumn.Name = "PrintSlip";
                    printSlipColumn.HeaderText = "Print Slip";
                    printSlipColumn.Text = "Print Slip";
                    printSlipColumn.UseColumnTextForButtonValue = true;

                    // Add the button column to the dataGridView
                    dataGridView.Columns.Add(printSlipColumn);

                    // Add event handler for cell formatting
                    dataGridView.CellFormatting += DataGridView_CellFormatting;

                    // Add event handler for cell content click
                    dataGridView.CellContentClick += DataGridView_CellContentClick;

                    panel2.Controls.Add(dataGridView);
                }
                else
                {
                    MessageBox.Show("No records found for the specified email.");
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(dataGridView);
            this.panel2.Controls.Remove(userCat);
            panel2.Controls.Add(UserHomeControl);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.log.Show();
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["PrintSlip"].Index && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView.Rows[e.RowIndex].Cells["PrintSlip"];
                buttonCell.Value = "Print Slip";

                // Set the background color and text color
                buttonCell.Style.BackColor = Color.FromArgb(33, 92, 173);
                buttonCell.Style.ForeColor = Color.White;

            }
        }


        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["PrintSlip"].Index && e.RowIndex >= 0)
            {
                // Get the row data
                string docId = dataGridView.Rows[e.RowIndex].Cells["doc_id"].Value.ToString();
                string startTime = dataGridView.Rows[e.RowIndex].Cells["StartTime"].Value.ToString();
                string price = dataGridView.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string dayOfWeek = dataGridView.Rows[e.RowIndex].Cells["DayOfWeek"].Value.ToString();
                string endTime = dataGridView.Rows[e.RowIndex].Cells["EndTime"].Value.ToString();
              
                
                // Create a PrintDocument
                PrintDocument pd = new PrintDocument();

                // Assign the PrintPage event handler
                pd.PrintPage += (s, args) =>
                {
                    // Set the font and font size
                    Font headingFont = new Font("Arial", 16, FontStyle.Bold);
                    Font contentFont = new Font("Arial", 12);

                    // Set the text alignment
                    StringFormat centerAlignment = new StringFormat();
                    centerAlignment.Alignment = StringAlignment.Center;

                    // Calculate the slip content height
                    float slipContentHeight = headingFont.GetHeight() + contentFont.GetHeight() * 20; // Increase the multiplier to adjust the height

                    // Generate the slip content
                    StringBuilder slipContent = new StringBuilder();
                    slipContent.AppendLine("ASAAN DOCTOR");
                    slipContent.AppendLine("----------------------------------");
                    slipContent.AppendLine("Doctor ID: " + docId);
                    slipContent.AppendLine("Start Time: " + startTime);
                    slipContent.AppendLine("Price: " + price);
                    slipContent.AppendLine("Date: " + dayOfWeek);
                    slipContent.AppendLine("End Time: " + endTime);
                    slipContent.AppendLine("----------------------------------");

                    // Set the printing area rectangle
                    RectangleF printArea = new RectangleF(args.MarginBounds.Left, args.MarginBounds.Top, args.MarginBounds.Width, slipContentHeight);

                    // Draw the slip content
                    args.Graphics.DrawString(slipContent.ToString(), headingFont, Brushes.Black, printArea, centerAlignment);

                    // Dispose the fonts and string format
                    headingFont.Dispose();
                    contentFont.Dispose();
                    centerAlignment.Dispose();
                };

                // Create a PrintPreviewDialog and set the PrintDocument
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = pd;

                // Show the print preview dialog
                printPreviewDialog.ShowDialog();

            }
        }
    }
}
