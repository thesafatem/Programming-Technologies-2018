using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Car
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath gp = new GraphicsPath();
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 10;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.Clear(Color.White);
            gp = new GraphicsPath();
            gp.AddRectangle(new Rectangle(30 + i, 50, 40, 10));
            gp.AddRectangle(new Rectangle(10 + i, 60, 80, 20));
            gp.AddEllipse(new Rectangle(25 + i, 75, 10, 10));
            gp.AddEllipse(new Rectangle(65 + i, 75, 10, 10));
            g.DrawPath(new Pen(Color.Red, 2), gp);
        }
    }
}
