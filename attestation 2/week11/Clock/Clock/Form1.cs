using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen second = new Pen(Color.Purple, 2);
        Pen minute = new Pen(Color.Green, 2);
        Pen hour = new Pen(Color.Blue, 2);
        int radius;
        int centerx, centery;
        int secrad, minuterad, hourrad, rad1, rad2;
        double secx, secy, minutex, minutey, hourx, houry;
        float secangle, minangle, hourangle;
        double x1, y1, x2, y2;

        public Form1()
        {
            InitializeComponent();
            radius = 100;
            centerx = 200;
            centery = 150;
            secrad = radius - 20;
            minuterad = radius - 40;
            hourrad = radius - 55;
            secangle = 270;
            minangle = 270;
            hourangle = 270;
            rad1 = radius - 10;
            rad2 = radius - 5;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i <= 360; i += 6)
            {
                x1 = centerx + rad1 * Math.Cos(i * Math.PI / 180);
                x2 = centerx + rad2 * Math.Cos(i * Math.PI / 180);
                y1 = centery + rad1 * Math.Sin(i * Math.PI / 180);
                y2 = centery + rad2 * Math.Sin(i * Math.PI / 180);
                g.DrawLine(new Pen(Color.Black), (float)x1, (float)y1, (float)x2, (float)y2);
            }
            secx = centerx + secrad * Math.Cos(secangle * Math.PI / 180);
            secy = centery + secrad * Math.Sin(secangle * Math.PI / 180);
            minutex = centerx + minuterad * Math.Cos(minangle * Math.PI / 180);
            minutey = centery + minuterad * Math.Sin(minangle * Math.PI / 180);
            hourx = centerx + hourrad * Math.Cos(hourangle * Math.PI / 180);
            houry = centery + hourrad * Math.Sin(hourangle * Math.PI / 180);
            g.DrawEllipse(new Pen(Color.Black, 2), centerx - radius, centery - radius, 2 * radius, 2 * radius);
            g.DrawLine(hour, centerx, centery, (float)hourx, (float)houry);
            g.DrawLine(minute, centerx, centery, (float)minutex, (float)minutey);
            g.DrawLine(second, centerx, centery, (float)secx, (float)secy);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secangle += 6;
            minangle += (float)(0.1);
            hourangle += (float)(0.008);
            if (secangle % 360 == 0) secangle = 0;
            if (minangle % 360 == 0) minangle = 0;
            if (hourangle % 360 == 0) hourangle = 0;
            pictureBox1.Refresh();
        }
    }
}
