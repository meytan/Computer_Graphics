using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab3
{
    public partial class Form1 : Form
    {
        
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.DarkRed, 2);
        double x1, x2, x3, x4, y1, y2, y3, y4;

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            readTextBox();
            label1.Text = "";
            double z1 = 100, z2 = 50, z3 = 0;
            x2 -= x1;
            y2 -= y1;
            z2 -= z1;
            x3 -= x1;
            y3 -= y1;
            z3 -= z1;
            double v1, v2, v3;
            v1 = y2 * z3 - z2 * y3;
            v2 = x2 * z3 - z2 * x3;
            v3 = x2 * y3 - x3 * y2;
            label1.Text = "Plaszczyzna ta okreslona jest wzorem " + "((" +v1 + ","+ v2 + ", " + v3+"))*(x-("+ x1+", "+y1+ ", "+z1+")=0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            readTextBox();
            label1.Text = "";
            double b, d,n,k;
            b = x1;
            d = y1;
            n = x2;
            k = y2;
            double miu = (k - n * b) / n * d;

            label1.Text = "Plaszczyzna i prosta przecina sie w punkcie (" + miu + ", " + b + miu * d + ")";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            readTextBox();
            label1.Text = "";
            g.DrawLine(pen1, new Point(0, 0), new Point((int)x1, (int)y1));
            g.DrawLine(pen1, new Point(0, 0), new Point((int)x2, (int)y2));
            double cosx1, cosx2, cosy1, cosy2;
            cosx1 = x1 / Math.Sqrt(Math.Pow(x1,2) + Math.Pow(y1,2));
            cosy1 = y1 / Math.Sqrt(Math.Pow(x1,2) + Math.Pow(y1,2));
            cosx2 = x2 / Math.Sqrt(Math.Pow(x2,2) + Math.Pow(y2,2));
            cosy2 = y2 / Math.Sqrt(Math.Pow(x2,2) + Math.Pow(y2,2));

            double result = Math.Acos(Math.Abs(cosx1 * cosx2 + cosy1 * cosy2))* (180 / Math.PI);
            label1.Text = "Proste tworza kat " + result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            readTextBox();
            label1.Text = "";
            double delta = (x2 - x1) * (y3 - y4) - (x3 - x4) * (y2 - y1);
            double delta_miu, miu, x, y;
            g.DrawLine(pen1, new Point((int)x1, (int)y1), new Point((int)x2, (int)y2));
            g.DrawLine(pen1, new Point((int)x3, (int)y3), new Point((int)x4, (int)y4));
            if (delta == 0)
            {
                label1.Text = "Te proste sa rownolegle";
                return;

            }
            else
            {

                delta_miu = (x3 - x1) * (y3 - y4) - (x3 - x4) * (y3 - y1);
                miu = delta_miu / delta;
                x = (1 - miu) * x1 + miu * x2;
                y = (1 - miu) * y1 + miu * y2;
                label1.Text = "Proste przecinaja sie w punkcie (" + x + ", " + y + ")";
                g.DrawEllipse(pen1, (int)x-25, (int)y-25, 50, 50);
            }   

        }

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void readTextBox()
        {
            x1 = Convert.ToDouble(textBox1.Text);
            y1 = Convert.ToDouble(textBox2.Text);
            y2 = Convert.ToDouble(textBox3.Text);
            x2 = Convert.ToDouble(textBox4.Text);
            y3 = Convert.ToDouble(textBox5.Text);
            x3 = Convert.ToDouble(textBox6.Text);
            y4 = Convert.ToDouble(textBox7.Text);
            x4 = Convert.ToDouble(textBox8.Text);


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
