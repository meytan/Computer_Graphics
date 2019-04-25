using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab5
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2);

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Point point = new Point(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));

            g.DrawLine(pen1, 0, 0, 620, 420);

            g.DrawEllipse(pen1, point.X, point.Y, 10, 10);

            double y = 0.6774193548;
            y *= point.X;


            if (point.Y > y )
            {
                label1.Text = "POD";
                
            }
            else if (point.Y == y)
            {
                label1.Text = "NA PROSTEJ";

            }
            else
            {
                label1.Text = "NAD";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Point point = new Point(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));

            g.DrawLine(pen1, 0, 0, 620, 420);

            g.DrawEllipse(pen1, point.X-5, point.Y-5, 10, 10);
            g.DrawEllipse(pen1, 200, 300, 10, 10);

            double y = 0.6774193548;
            y *= point.X;
            double y1 = 0.6774193548 * 300;

            if (point.Y > y)
            {
                label1.Text = "LEZY PO TEJ SAMEJ STRONIE";

            }
            else
            {
                label1.Text = "LEZA PO INNEJ STRONIE";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Point point = new Point(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));

            g.DrawLine(pen1, 0, 0, 620, 420);

            g.DrawEllipse(pen1, point.X-5, point.Y-5, 10, 10);

            double y = 0.6774193548;
            y *= point.X;


            if (point.Y - y < 0.1 && point.Y - y >-0.1)
            {
                label1.Text = "Nalezy";

            }
            else
            {
                label1.Text = "Nie Nalezy";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Point point = new Point(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));

            g.DrawLine(pen1, 0, 0, 620, 420);
            g.DrawLine(pen1, 0, 420, point.X , point.Y);

              
            double y = 0.6774193548;
            y *= point.X;


            if (point.Y < y)
            {
                label1.Text = "Przecina sie";

            }
            else
            {
                label1.Text = "Nie Przecina sie ";
            }
        }
    }
}
