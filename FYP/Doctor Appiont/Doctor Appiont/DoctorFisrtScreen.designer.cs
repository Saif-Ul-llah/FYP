using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace doc_ceare
{
    partial class DoctorFisrtScreen
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


      //private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;


        private class CustomButton : Button
        {
            private Color primaryColor = Color.FromArgb(33, 92, 173);
            private Color hoverColor = Color.FromArgb(62, 95, 107);
            private Color textColor = Color.White;

            private int iconSize = 24; // Set the desired constant icon size

            public CustomButton()
            {
                FlatStyle = FlatStyle.Flat;
                FlatAppearance.BorderSize = 0;
                Font = new Font("Segoe UI", 12, FontStyle.Regular);
                ForeColor = textColor;
                BackColor = primaryColor;
                TextAlign = ContentAlignment.MiddleLeft;
                ImageAlign = ContentAlignment.MiddleLeft;
                TextImageRelation = TextImageRelation.ImageBeforeText;
                Padding = new Padding(10, 5, 10, 5);
                Size = new Size(200, 40);

            }

            
            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics graphics = e.Graphics;
                Rectangle bounds = new Rectangle(0, 0, Width, Height);

                // Create a rounded rectangle shape for the button
                using (GraphicsPath path = new GraphicsPath())
                {
                    int borderRadius = 1;
                    path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
                    path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
                    path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
                    path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
                    path.CloseFigure();

                    // Fill the button background with the current color (primary or hover color)
                    using (SolidBrush brush = new SolidBrush(BackColor))
                    {
                        graphics.FillPath(brush, path);
                    }

                    // Draw the button text and image
                    SizeF textSize = graphics.MeasureString(Text, Font);
                    int textOffset = 0;
                    int iconOffset = 0;

                    if (Image != null)
                    {
                        iconOffset = Padding.Left;
                        textOffset = iconOffset + iconSize + Padding.Horizontal;
                    }
                    else
                    {
                        textOffset = Padding.Horizontal / 2;
                    }

                    if (Font != null)
                    {
                        using (SolidBrush textBrush = new SolidBrush(ForeColor))
                        {
                            graphics.DrawString(Text, Font, textBrush, textOffset, (Height - textSize.Height) / 2);
                        }
                    }

                    if (Image != null)
                    {
                        graphics.DrawImage(Image, iconOffset, (Height - iconSize) / 2, iconSize, iconSize);
                    }
                }
            }
        }

       



        private void InitializeComponent()
        {

            //ystem.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFisrtScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            // UserDoctorListControl UserHomeControl = new UserDoctorListControl();
            //UserHomeControl deat = new UserHomeControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // ...
         


            // button1 - Profile
            this.button1 = new CustomButton();
            this.button1.Image = Image.FromFile("./../../Assets/pro.png");
            this.button1.Text = "Profile";
            this.button1.Dock = DockStyle.Top;
            this.button1.Cursor = Cursors.Hand;
            this.button1.Click += Button1_Click;

            // button2 - Categories
            this.button2 = new CustomButton();
            this.button2.Image = Image.FromFile("./../../Assets/cat.png");
            this.button2.Text = "Appointment";
            this.button2.Dock = DockStyle.Top;
            this.button2.Cursor = Cursors.Hand;
            this.button2.Click += Button2_Click;

           

            // button5 - Settings
            this.button5 = new CustomButton();
            this.button5.Image = Image.FromFile("./../../Assets/set.png");
            this.button5.Text = "Settings";
            this.button5.Dock = DockStyle.Top;
            this.button5.Cursor = Cursors.Hand;
            this.button5.Click += Button5_Click;

            // button3 - Log Out
            this.button3 = new CustomButton();
            this.button3.Image = Image.FromFile("./../../Assets/log.png");
            this.button3.Text = "Log Out";
            this.button3.Dock = DockStyle.Bottom;
            this.button3.Cursor = Cursors.Hand;
            this.button3.Click += Button3_Click;

            // ...

            // Add the buttons to the panel1
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);

            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(172)))), ((int)(((byte)(175)))));
           // this.panel2.Controls.Add(deat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 1;
            this.panel2.AutoScroll = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 150);
            this.panel3.TabIndex = 0;

            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);

            this.label1.AutoSize = false;
            this.label1.Height = 40;
            this.label1.Font = new Font("Lucida Fax", 12, FontStyle.Bold);
            this.label1.ForeColor = Color.FromArgb(33, 93, 172);
            this.label1.Text = "doctorScr\nDOCTOR";


            // this.label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size * 1.5f, label1.Font.Style, label1.Font.Unit, label1.Font.GdiCharSet, label1.Font.GdiVerticalFont);
            this.label1.TabIndex = 0;


            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = Image.FromFile("./../../Assets/LOGO.png"); 
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            //this.label2.AutoSize = true;
            //this.label2.Location = new System.Drawing.Point(115, 22);
            //this.label2.Name = "label2";
            //this.label2.Size = new System.Drawing.Size(79, 13);
            //this.label2.TabIndex = 2;
           // this.label2.Text = "get Name Here";
            // 
            // UserFisrtScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorFisrtScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorFisrtScreen";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
            }

            // ...
        }
    
