using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab6
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            PointF[] points =
            {
                new PointF(50,500),
                new PointF(100,50),
                new PointF(400,20),
                new PointF(500,480)
            };
            
            for(float t = 0; t<1; t += 0.0001f)
            {
                float y = (1 - t) * (1 - t) * (1 - t) * points[0].Y + (1 - t) * (1 - t) * 3 * t * points[1].Y + 3 * t * t * (1 - t) * points[2].Y + t * t * t * points[3].Y;
                float x = (1 - t) * (1 - t) * (1 - t) * points[0].X + (1 - t) * (1 - t) * 3 * t * points[1].X + 3 * t * t * (1 - t) * points[2].X + t * t * t * points[3].X;

                g.FillRectangle((Brush)Brushes.Blue, x, y, 1, 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            PointF P1 = new PointF(10, 100);
            PointF P2 = new PointF(100,100);
            


            for (float t = 0.001f; t < 1; t += 0.001f)
            {
                
                float x = (2 * t * t * t - 3 * t * t + 1) * P1.X + (-2 * t * t * t + 3 * t * t) * P2.X + (t * t * t - 2 * t * t + t) * 10 + (t * t * t - t * t) * 10;
                float y = (2 * t * t * t - 3 * t * t + 1) * P1.Y + (-2 * t * t * t + 3 * t * t) * P2.Y + (t * t * t - 2 * t * t + t) * 1000 + (t * t * t - t * t) * 1000;
                g.FillRectangle((Brush)Brushes.Blue, x, y, 1, 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            PointF P1 = new PointF(10, 10);
            PointF P2 = new PointF(30, 250);
            PointF P3 = new PointF(320, 300);
            PointF P4 = new PointF(400, 450);
            PointF P5 = new PointF(430, 30);
            PointF P6 = new PointF(390, 100);
            PointF P7 = new PointF(90, 100);

            /*
            for (float t = 0.001f; t < 1; t += 0.001f)
            {

                float x =  ((((1 - t) * (1 - t) * (1 - t)) * P1.X) / 6) + (((3 * t * t * t - 6 * t * t + 4) * P2.X) / 6) +((-3 * t * t * t + 3 * t * t + 3 * t + 1) * P3.X) / 6 + (t * t * t * P4.X) / 6;
                float y =  ((((1 - t) * (1 - t) * (1 - t)) * P1.Y) / 6) + (((3 * t * t * t - 6 * t * t + 4) * P2.Y) / 6) +((-3 * t * t * t + 3 * t * t + 3 * t + 1) * P3.Y) / 6 + (t * t * t * P4.Y) / 6;
                
                g.FillRectangle((Brush)Brushes.Blue, x, y, 1, 1);
            }

            for (float t = 0.001f; t < 1; t += 0.001f)
            {

                float x = ((((1 - t) * (1 - t) * (1 - t)) * P3.X) / 6) + (((3 * t * t * t - 6 * t * t + 4) * P4.X) / 6) + ((-3 * t * t * t + 3 * t * t + 3 * t + 1) * P5.X) / 6 + (t * t * t * P6.X) / 6;
                float y = ((((1 - t) * (1 - t) * (1 - t)) * P3.Y) / 6) + (((3 * t * t * t - 6 * t * t + 4) * P4.Y) / 6) + ((-3 * t * t * t + 3 * t * t + 3 * t + 1) * P5.Y) / 6 + (t * t * t * P6.Y) / 6;

                g.FillRectangle((Brush)Brushes.Blue, x, y, 1, 1);
            }*/

            for (float t = 0; t < 1; t += 0.0001f)
            {
                float y = (1 - t) * (1 - t) * (1 - t) * P1.Y + (1 - t) * (1 - t) * 3 * t * P2.Y + 3 * t * t * (1 - t) * P3.Y + t * t * t * P6.Y;
                float x = (1 - t) * (1 - t) * (1 - t) * P1.X + (1 - t) * (1 - t) * 3 * t * P2.X + 3 * t * t * (1 - t) * P3.X + t * t * t * P6.X;

                g.FillRectangle((Brush)Brushes.Blue, x, y, 1, 1);

               
            }for (float t = 0; t < 1; t += 0.0001f)
            {
                float y = (1 - t) * (1 - t) * (1 - t) * P6.Y + (1 - t) * (1 - t) * 3 * t * P5.Y + 3 * t * t * (1 - t) * P3.Y + t * t * t * P4.Y;
                float x = (1 - t) * (1 - t) * (1 - t) * P6.X + (1 - t) * (1 - t) * 3 * t * P5.X + 3 * t * t * (1 - t) * P3.X + t * t * t * P4.X;

                g.FillRectangle((Brush)Brushes.Blue, x, y, 1, 1);
            }

            for (float t = 0; t < 1; t += 0.0001f)
            {
                float y = (1 - t) * (1 - t) * (1 - t) * P4.Y + (1 - t) * (1 - t) * 3 * t * P5.Y + 3 * t * t * (1 - t) * P3.Y + t * t * t * P7.Y;
                float x = (1 - t) * (1 - t) * (1 - t) * P4.X + (1 - t) * (1 - t) * 3 * t * P5.X + 3 * t * t * (1 - t) * P3.X + t * t * t * P7.X;

                g.FillRectangle((Brush)Brushes.Blue, x, y, 1, 1);
            }
        }
    }
}
