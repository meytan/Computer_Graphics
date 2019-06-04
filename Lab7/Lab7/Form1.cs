using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.White, 2);        Rectangle rect;
        SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            
            rect = new Rectangle(0, 0, 140, 140);
            brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, rect);
            update_square();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    int u = (int)(i * 255.0 / 100);
                    int v = (int)(j * 255.0 / 100);
                    pen1.Color = Color.FromArgb(255 - u, 0, v);
                    g.DrawRectangle(pen1, 0 + i, 0 + j, 1, 1);

                
                    pen1.Color = Color.FromArgb(255-u, v, 255);
                    g.DrawRectangle(pen1, 0 + i, 100 + j, 1, 1);

                    
                    pen1.Color = Color.FromArgb(255 - u, 255, 255-v);
                    g.DrawRectangle(pen1, 0 + i, 200 + j, 1, 1);

                    
                    pen1.Color = Color.FromArgb(0, v, 255-u);
                    g.DrawRectangle(pen1, 100 + i, 100 + j, 1, 1);

                   
                    pen1.Color = Color.FromArgb(u, v, 0);
                    g.DrawRectangle(pen1, 200 + i, 100 + j, 1, 1);

                    
                    pen1.Color = Color.FromArgb(255, v, u);
                    g.DrawRectangle(pen1, 300 + i, 100 + j, 1, 1);



                }

            }
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            update_square();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            update_square();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            update_square();
        }

        private void update_square()
        {
            brush = new SolidBrush(Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value));
            g.FillRectangle(brush, rect);
            label1.Text = "Red : " + trackBar1.Value.ToString();            label2.Text = "Green : " + trackBar2.Value.ToString();            label3.Text = "Blue : " + trackBar3.Value.ToString();            double c = 1 - ((double)trackBar1.Value / 255);            double m = 1 - ((double)trackBar2.Value / 255);            double k = 1 - ((double)trackBar3.Value / 255);            label4.Text = "C: " + c.ToString() +"M: " + m.ToString() +"K: " + k.ToString() ;
            System.Drawing.Color color = System.Drawing.Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            float hue = color.GetHue();
            float saturation = color.GetSaturation();
            float lightness = color.GetBrightness();

            label6.Text = "H: " + hue.ToString() + "S: " + saturation.ToString() + "V: " + lightness.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
