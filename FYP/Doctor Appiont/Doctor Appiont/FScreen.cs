﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doctor_Appiont
{
    public partial class FScreen : Form
    {
        public FScreen()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            DropDownCustomizDesign();
        }
        private void DropDownCustomizDesign()
        {
          signUpDropDown.Visible = false;
        }

        private void FirstPageSignUpBtn_Click(object sender, EventArgs e)
        {
           signUpDropDown.Visible = !signUpDropDown.Visible;
        }

        private void DocSignUpGo_Click(object sender, EventArgs e)
        {   
            doc_ceare.Form2 docSignUp = new doc_ceare.Form2();
            docSignUp.Show();
            this.Hide();
        }

      

        private void GoToSignIn_Click(object sender, EventArgs e)
        {
            doc_ceare.Form3 login = new doc_ceare.Form3();
            login.Show();
            this.Hide();
        }

        private void userSignUpBtnGo_Click_1(object sender, EventArgs e)
        {
            doc_ceare.Form4 userSignUp = new doc_ceare.Form4();
            userSignUp.Show();
            this.Hide();
        }

        private void FScreen_Load(object sender, EventArgs e)
        {

        }

        private void goToSignIn_Click_1(object sender, EventArgs e)
        {
            doc_ceare.Form3 login = new doc_ceare.Form3();
            login.Show();
            this.Hide();
        }
    }
}