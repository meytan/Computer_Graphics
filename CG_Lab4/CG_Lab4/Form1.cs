using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab4
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
            Point s = new Point(100, 100);
            g.DrawEllipse(pen1, s.X, s.Y, 100, 100);
            System.Threading.Thread.Sleep(1000);
            s.X += (int) Double.Parse(textBox1.Text);
            s.Y += (int) Double.Parse(textBox2.Text);
            g.Clear(Color.White);
            g.DrawEllipse(pen1, s.X, s.Y, 100, 100);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Point[] points =
            {
                new Point(100,100),
                new Point(200,100),
                new Point(200,200),
                new Point(100,200),
                new Point(100,100)
            };

            g.DrawLines(pen1, points);
            System.Threading.Thread.Sleep(1000);
            for(int i = 0; i<5;i++)
            {
                points[i] = rotate(points[i], DegreeToRadian(Double.Parse(textBox1.Text)), 150, 150);
            }
             g.Clear(Color.White);
            g.DrawLines(pen1, points);



        }

        private Point rotate(Point point, double rotation, int x, int y)
        {
            point.X -= x;
            point.Y -= y;
            Point tmpPoint = new Point((int) (Math.Cos(rotation) * (double) point.X) - (int)(Math.Sin(rotation) * (double)point.Y),(int)(Math.Sin(rotation) *(double) point.X) + (int)(Math.Cos(rotation) * (double)point.Y));
            tmpPoint.X += x;
            tmpPoint.Y += y;
            return tmpPoint;

        }
        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 100, y = 100;
            g.Clear(Color.White);
            Point s = new Point(100, 100);
            g.DrawEllipse(pen1, s.X, s.Y, x, y);
            System.Threading.Thread.Sleep(1000);
            x *= (int)Double.Parse(textBox1.Text);
            y *= (int)Double.Parse(textBox2.Text);

            g.Clear(Color.White);
            g.DrawEllipse(pen1, s.X, s.Y, x, y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 100, y = 100;
            g.Clear(Color.White);
            Point s = new Point(100, 100);
            g.DrawEllipse(pen1, s.X, s.Y, x, y);
            System.Threading.Thread.Sleep(1000);
            x *= (int)Double.Parse(textBox3.Text);
            y *= (int)Double.Parse(textBox3.Text);
            s.X += (int)Double.Parse(textBox1.Text);
            s.Y += (int)Double.Parse(textBox2.Text);
            g.Clear(Color.White);
            g.DrawEllipse(pen1, s.X, s.Y, x, y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Point[] points =
            {
                new Point(100,100),
                new Point(200,100),
                new Point(200,200),
                new Point(100,200),
                new Point(100,100)
            };

            g.DrawLines(pen1, points);
            System.Threading.Thread.Sleep(1000);
            for (int i = 0; i < 5; i++)
            {
                points[i] = rotate(points[i], DegreeToRadian(Double.Parse(textBox3.Text)), 150, 150);
                points[i].X += (int)Double.Parse(textBox1.Text);
                points[i].Y += (int)Double.Parse(textBox2.Text);
            }

            g.Clear(Color.White);
            g.DrawLines(pen1, points);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Point[] points =
            {
                new Point(100,100),
                new Point(200,100),
                new Point(200,200),
                new Point(100,100)
            };

            g.DrawLines(pen1, points);
            System.Threading.Thread.Sleep(1000);
            for (int i = 0; i < 4; i++)
            {
                points[i] = rotate(points[i], DegreeToRadian(Double.Parse(textBox3.Text)), 150, 150);
                points[i].X += (int)Double.Parse(textBox1.Text);
                points[i].Y += (int)Double.Parse(textBox2.Text);
            }

            g.Clear(Color.White);
            g.DrawLines(pen1, points);
        }
    }
}
