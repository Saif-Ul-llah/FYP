namespace doc_ceare
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoBackToFirstSreen = new System.Windows.Forms.Button();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(172)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.GoBackToFirstSreen);
            this.panel1.Controls.Add(this.textBox19);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // GoBackToFirstSreen
            // 
            this.GoBackToFirstSreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.GoBackToFirstSreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackToFirstSreen.FlatAppearance.BorderSize = 0;
            this.GoBackToFirstSreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackToFirstSreen.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.GoBackToFirstSreen.ForeColor = System.Drawing.Color.White;
            this.GoBackToFirstSreen.Location = new System.Drawing.Point(27, 27);
            this.GoBackToFirstSreen.Name = "GoBackToFirstSreen";
            this.GoBackToFirstSreen.Size = new System.Drawing.Size(100, 25);
            this.GoBackToFirstSreen.TabIndex = 64;
            this.GoBackToFirstSreen.Text = "Go Back";
            this.GoBackToFirstSreen.UseVisualStyleBackColor = false;
            this.GoBackToFirstSreen.Click += new System.EventHandler(this.BackToFirstScreenToDrSignUp_Click);
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(347, 193);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(164, 24);
            this.textBox19.TabIndex = 11;
            this.textBox19.PasswordChar = '*';
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(347, 155);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(164, 24);
            this.textBox18.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(315, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sign In";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(214, 195);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 18);
            this.label24.TabIndex = 8;
            this.label24.Text = "Password :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(214, 157);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 18);
            this.label23.TabIndex = 7;
            this.label23.Text = "Email :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(344, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 30);
            this.label22.TabIndex = 6;
            this.label22.Text = "Sign In";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(92)))), ((int)(((byte)(173)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(517, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 65;
            this.button1.Text = "#";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.TogglePasswordVisibility);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button GoBackToFirstSreen;
        private System.Windows.Forms.Button button1;
    }
}