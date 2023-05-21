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

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(userCat);
            panel2.Controls.Add(UserHomeControl);

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Remove(UserHomeControl);
            panel2.Controls.Add(userCat);
        }
        private void Button3_Click(object sender, EventArgs e)
        {

        }
        private void Button4_Click(object sender, EventArgs e)
        {

        }
        private void Button5_Click(object sender, EventArgs e)
        {

        }

    }
}
