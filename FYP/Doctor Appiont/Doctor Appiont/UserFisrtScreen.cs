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
    public partial class UserFisrtScreen : Form
    {

        UserHomeControl UserHomeControl = new UserHomeControl();
        Doctor_Appiont.UserCat userCat = new Doctor_Appiont.UserCat();
        public UserFisrtScreen()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            panel2.Controls.Add(UserHomeControl);

        }
        //this button is for Profile
        private void Button1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(userCat);
            panel2.Controls.Add(UserHomeControl);

        }

        //this button is for Categories
        private void Button2_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(UserHomeControl);
            panel2.Controls.Add(userCat);
        }
        //this is for My Booking
        private void Button4_Click(object sender, EventArgs e)
        {

        }
        //thid is for Setting
        private void Button5_Click(object sender, EventArgs e)
        {

        }
        //this is for Logout
        private void Button3_Click(object sender, EventArgs e)
        {

        }

    }
}
