
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Doctor_Appiont
{
    partial class FScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel signUpDropDown;
        private Button docSignUpGo;
        private Button userSignUpBtnGo;
        private Button goToSignIn;
        private Button firstPageSignUpBtn;
        private Label label25;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.signUpDropDown = new System.Windows.Forms.Panel();
            this.docSignUpGo = new System.Windows.Forms.Button();
            this.userSignUpBtnGo = new System.Windows.Forms.Button();
            this.goToSignIn = new System.Windows.Forms.Button();
            this.firstPageSignUpBtn = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.signUpDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(172)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.signUpDropDown);
            this.panel1.Controls.Add(this.goToSignIn);
            this.panel1.Controls.Add(this.firstPageSignUpBtn);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(303, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // signUpDropDown
            // 
            this.signUpDropDown.Controls.Add(this.docSignUpGo);
            this.signUpDropDown.Controls.Add(this.userSignUpBtnGo);
            this.signUpDropDown.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.signUpDropDown.Location = new System.Drawing.Point(209, 253);
            this.signUpDropDown.Name = "signUpDropDown";
            this.signUpDropDown.Size = new System.Drawing.Size(147, 69);
            this.signUpDropDown.TabIndex = 22;
            // 
            // docSignUpGo
            // 
            this.docSignUpGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.docSignUpGo.FlatAppearance.BorderSize = 0;
            this.docSignUpGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docSignUpGo.ForeColor = System.Drawing.Color.White;
            this.docSignUpGo.Location = new System.Drawing.Point(0, 35);
            this.docSignUpGo.Name = "docSignUpGo";
            this.docSignUpGo.Size = new System.Drawing.Size(147, 31);
            this.docSignUpGo.TabIndex = 1;
            this.docSignUpGo.Text = "Doc Sign Up";
            this.docSignUpGo.UseVisualStyleBackColor = false;
            this.docSignUpGo.Click += new System.EventHandler(this.DocSignUpGo_Click);
            // 
            // userSignUpBtnGo
            // 
            this.userSignUpBtnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.userSignUpBtnGo.Dock = System.Windows.Forms.DockStyle.Top;
            this.userSignUpBtnGo.FlatAppearance.BorderSize = 0;
            this.userSignUpBtnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userSignUpBtnGo.ForeColor = System.Drawing.Color.White;
            this.userSignUpBtnGo.Location = new System.Drawing.Point(0, 0);
            this.userSignUpBtnGo.Name = "userSignUpBtnGo";
            this.userSignUpBtnGo.Size = new System.Drawing.Size(147, 31);
            this.userSignUpBtnGo.TabIndex = 0;
            this.userSignUpBtnGo.Text = "User Sign Up";
            this.userSignUpBtnGo.UseVisualStyleBackColor = false;
            this.userSignUpBtnGo.Click += new System.EventHandler(this.userSignUpBtnGo_Click_1);
            // 
            // goToSignIn
            // 
            this.goToSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.goToSignIn.FlatAppearance.BorderSize = 0;
            this.goToSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSignIn.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.goToSignIn.ForeColor = System.Drawing.Color.White;
            this.goToSignIn.Location = new System.Drawing.Point(411, 205);
            this.goToSignIn.Name = "goToSignIn";
            this.goToSignIn.Size = new System.Drawing.Size(147, 42);
            this.goToSignIn.TabIndex = 21;
            this.goToSignIn.Text = "Sign In";
            this.goToSignIn.UseVisualStyleBackColor = false;
            this.goToSignIn.Click += new System.EventHandler(this.goToSignIn_Click_1);
            // 
            // firstPageSignUpBtn
            // 
            this.firstPageSignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.firstPageSignUpBtn.FlatAppearance.BorderSize = 0;
            this.firstPageSignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstPageSignUpBtn.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.firstPageSignUpBtn.ForeColor = System.Drawing.Color.White;
            this.firstPageSignUpBtn.Location = new System.Drawing.Point(209, 205);
            this.firstPageSignUpBtn.Name = "firstPageSignUpBtn";
            this.firstPageSignUpBtn.Size = new System.Drawing.Size(147, 42);
            this.firstPageSignUpBtn.TabIndex = 20;
            this.firstPageSignUpBtn.Text = "Sign up";
            this.firstPageSignUpBtn.UseVisualStyleBackColor = false;
            this.firstPageSignUpBtn.Click += new System.EventHandler(this.FirstPageSignUpBtn_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label25.Location = new System.Drawing.Point(223, 156);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(302, 41);
            this.label25.TabIndex = 19;
            this.label25.Text = "ASAAN  DOCTOR";
            // 
            // FScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.signUpDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

