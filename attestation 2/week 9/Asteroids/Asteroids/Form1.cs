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

namespace Asteroids
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.Clear(Color.Black);
            g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(10, 10, 766, 442));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(40, 60, 25, 25));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(40, 380, 25, 25));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(300, 50, 25, 25));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(500, 80, 25, 25));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(700, 150, 25, 25));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(300, 300, 25, 25));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(700, 400, 25, 25));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(610, 250, 25, 25));
            g.DrawRectangle(new Pen(Color.Green, 6), 520, 15, 220, 30);
            g.FillRectangle(new SolidBrush(Color.White), 522, 17, 218, 28);
            g.DrawString("Level: 1 Score: 200 Live: ***", new Font (FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Black), 525, 20);
            g.FillPolygon(new SolidBrush(Color.Red), new Point[3] { new Point(100, 130), new Point(120, 100), new Point(140, 130) });
            g.FillPolygon(new SolidBrush(Color.Red), new Point[3] { new Point(100, 110), new Point(120, 140), new Point(140, 110) });
            g.FillPolygon(new SolidBrush(Color.Red), new Point[3] { new Point(140, 260), new Point(160, 230), new Point(180, 260) });
            g.FillPolygon(new SolidBrush(Color.Red), new Point[3] { new Point(140, 240), new Point(160, 270), new Point(180, 240) });
            g.FillPolygon(new SolidBrush(Color.Red), new Point[3] { new Point(600, 110), new Point(620, 80), new Point(640, 110) });
            g.FillPolygon(new SolidBrush(Color.Red), new Point[3] { new Point(600, 90), new Point(620, 120), new Point(640, 90) });
            g.FillPolygon(new SolidBrush(Color.Red), new Point[3] { new Point(520, 350), new Point(540, 320), new Point(560, 350) });
            g.FillPolygon(new SolidBrush(Color.Red), new Point[3] { new Point(520, 330), new Point(540, 360), new Point(560, 330) });
            g.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(370, 200, 90, 40));
            g.FillPolygon(new SolidBrush(Color.Yellow), new Point[3] { new Point(370, 200), new Point(415, 180), new Point(460, 200) });
            g.FillPolygon(new SolidBrush(Color.Yellow), new Point[3] { new Point(370, 240), new Point(415, 260), new Point(460, 240) });
            g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(410, 220, 10, 20));
            g.FillPolygon(new SolidBrush(Color.Green), new Point[3] { new Point(405, 220), new Point(415, 200), new Point(425, 220) });
            g.FillRectangle(new SolidBrush(Color.LightGreen), new Rectangle(412, 144, 6, 6));
            g.FillPolygon(new SolidBrush(Color.LightGreen), new Point[3] { new Point(412, 144), new Point(415, 130), new Point(418, 144) });
            g.FillPolygon(new SolidBrush(Color.LightGreen), new Point[3] { new Point(412, 150), new Point(415, 164), new Point(418, 150) });
            g.FillPolygon(new SolidBrush(Color.LightGreen), new Point[3] { new Point(412, 144), new Point(412, 150), new Point(398, 147) });
            g.FillPolygon(new SolidBrush(Color.LightGreen), new Point[3] { new Point(418, 144), new Point(418, 150), new Point(432, 147) });
            pictureBox1.Refresh();
        }
    }
}
