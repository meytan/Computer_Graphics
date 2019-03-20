using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika_Lab2
{
    public partial class Form1 : Form
    {
        
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2);
        private float sx = 300;
        private double r = 100;
        private double r1 = 250;
        private double r2 = 250;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private double a = 2*Math.PI/100;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < 100; i++)
            {
                g.DrawLine(pen1, sx + (float)(r * Math.Cos(a * i)), sx + (float)(r * Math.Sin(a * i)), sx + (float)(r * Math.Cos(a * (i + 1))), sx + (float)(r * Math.Sin(a * (i + 1))));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < 1000; i++)
            {
                g.DrawLine(pen1, sx + (float)(r * Math.Cos(a * i)), sx + (float)(r * Math.Sin(a * i)), sx + (float)(r * Math.Cos(a * (i + 1))), sx + (float)(r * Math.Sin(a * (i + 1))));
                r = r - 0.1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            for (int j = 0; j < 4; j++)
            {


                for (int i = 0; i < 100; i++)
                {
                    g.DrawLine(pen1, sx + (float)(r1 * Math.Cos(a * i)), sx + (float)(r2 * Math.Sin(a * i)), sx + (float)(r1 * Math.Cos(a * (i + 1))), sx + (float)(r2 * Math.Sin(a * (i + 1))));
                    g.DrawLine(pen1, sx + (float)(r2 * Math.Cos(a * i)), sx + (float)(r1 * Math.Sin(a * i)), sx + (float)(r2 * Math.Cos(a * (i + 1))), sx + (float)(r1 * Math.Sin(a * (i + 1))));

                }

                r1 = r2;
                r2 *= 0.7;
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < 100; i++)
            {
                g.DrawLine(pen1, sx + (float)(r * Math.Cos(a * i)), sx + (float)(r * Math.Sin(a * i)), sx + (float)(r * Math.Cos(a * (i + 1))), sx + (float)(r * Math.Sin(a * (i + 1))));
            }
            for (int i = 0; i < 333; i++)
            {
                g.DrawLine(pen1, 
                    sx + (float)(r * Math.Cos(a * i)),
                    sx + (float)(r * Math.Sin(a * i)), 
                    sx + (float)(r * Math.Cos(a * (i + 1))), 
                    sx + (float)(r * Math.Sin(a * (i + 1))));
                g.DrawLine(pen1, 
                    sx + (float)(r * Math.Cos(a * i + Math.PI)),
                    sx + (float)(r * Math.Sin(a * i+ Math.PI)), 
                    sx + (float)(r * Math.Cos(a * (i + 1)+ Math.PI)), 
                    sx + (float)(r * Math.Sin(a * (i + 1)+ Math.PI)));
                g.DrawLine(pen1, 
                    sx + (float)(r * Math.Cos(a * i + Math.PI/2)),
                    sx + (float)(r * Math.Sin(a * i+ Math.PI/2)), 
                    sx + (float)(r * Math.Cos(a * (i + 1)+ Math.PI/2)), 
                    sx + (float)(r * Math.Sin(a * (i + 1)+ Math.PI/2)));
                g.DrawLine(pen1, 
                    sx + (float)(r * Math.Cos(a * i - Math.PI/2)),
                    sx + (float)(r * Math.Sin(a * i- Math.PI/2)), 
                    sx + (float)(r * Math.Cos(a * (i + 1)- Math.PI/2)), 
                    sx + (float)(r * Math.Sin(a * (i + 1)- Math.PI/2)));

                r = r - 0.3;
            }
  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Point[] points = new Point[5];

            for (int i = 0; i < 400; i += 10)
            {
                Point P1 = new Point(270 - i, 140);
                Point P2 = new Point(300, 170 - i);
                Point P3 = new Point(270 + i, 200);
                Point P4 = new Point(240, 170 + i);
                Point P5 = new Point(270 - i, 140);
                points[0] = P1;
                points[1] = P2;
                points[2] = P3;
                points[3] = P4;
                points[4] = P5;
                g.DrawLines(pen1, points);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Point[] points = new Point[5];

            for (int i = 0; i < 400; i += 10)
            {
                Point P1 = new Point(270 - i, 80);
                Point P2 = new Point(360, 170 - i);
                Point P3 = new Point(270 + i, 260);
                Point P4 = new Point(180, 170 + i);
                Point P5 = new Point(270 - i, 80);
                points[0] = P1;
                points[1] = P2;
                points[2] = P3;
                points[3] = P4;
                points[4] = P5;
                g.DrawLines(pen1, points);
            }
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 720);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(956, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(956, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(956, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(956, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(956, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(956, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1176, 784);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


    }
}
