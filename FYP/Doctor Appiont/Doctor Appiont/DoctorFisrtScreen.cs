using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace doc_ceare
{
    public partial class DoctorFisrtScreen : Form
    {
        
        
        Doctor_Appiont.FScreen log = new Doctor_Appiont.FScreen();
        private UserHomeControl UserHomeControl;
        private doc_ceare.DocTimingWindow Schedule;
        private String Email;
        private String Tb;

        public DoctorFisrtScreen(String email, String tb)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            Tb = tb;
            Email = email;

            UserHomeControl = new UserHomeControl(Email, tb);
            panel2.Controls.Add(UserHomeControl);
        }

        //this button is for Profile
        private void Button1_Click(object sender, EventArgs e)
        {

            this.panel2.Controls.Remove(Schedule);
            UserHomeControl = new UserHomeControl(Email, Tb);
            this.panel2.Controls.Add(UserHomeControl);
            
        }

        //this button is for Appointment Schedul for Doctor
        private void Button2_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(UserHomeControl);
            Schedule = new doc_ceare.DocTimingWindow(Email);
            this.panel2.Controls.Add(Schedule);
        }
        
       
        
        //thid is for Setting
        private void Button5_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(Schedule);
            UserHomeControl = new UserHomeControl(Email, Tb);
            this.panel2.Controls.Add(UserHomeControl);

        }

        //this is for Logout
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.log.Show();

        }

    }
}
