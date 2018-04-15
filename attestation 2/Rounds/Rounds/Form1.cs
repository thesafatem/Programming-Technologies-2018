using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rounds
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point p;
        Color[] color = { Color.Green, Color.Yellow, Color.Blue, Color.Red, Color.Purple };
        int r = 0;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        public Color rand(Color[] color)
        {
            Random x = new Random();
            int k = x.Next(0, 4);
            return color[k];
        }
        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
            g.DrawEllipse(new Pen(rand(color)), new Rectangle(p.X - r, p.Y - r, 2 * r, 2 * r));
            timer1.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            r += 10;
            for (int i = 0; i < r; i += 10)
            {
                g.DrawEllipse(new Pen(rand(color)), new Rectangle(p.X - i, p.Y - i, 2 * i, 2 * i));
            }
        }
    }
}
