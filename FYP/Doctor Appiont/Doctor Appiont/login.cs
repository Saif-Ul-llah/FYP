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
    public partial class Form3 : Form
    {
        public Form3()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void BackToFirstScreenToDrSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            Doctor_Appiont.FScreen back = new Doctor_Appiont.FScreen();
            back.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            doc_ceare.UserFisrtScreen user = new doc_ceare.UserFisrtScreen();
            user.Show();

        }
    }
}
