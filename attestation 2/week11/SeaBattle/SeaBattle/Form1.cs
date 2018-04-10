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

namespace SeaBattle
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath square;
        GraphicsPath ship;
        int n = 30;

        public Form1()
        {
            InitializeComponent();

            square = new GraphicsPath();
            ship = new GraphicsPath();

            g = CreateGraphics();

            for (int i = 30; i <= 300; i += n)
            {
                for (int j = 30; j <= 300; j += n)
                {
                    square.AddRectangle(new Rectangle(i, j, n, n));
                    square.AddRectangle(new Rectangle(i + 350, j, n, n));
                }
            }
            ship.AddEllipse(new Rectangle(30, 350, 30, 30));
            ship.AddEllipse(new Rectangle(60, 350, 30, 30));
            ship.AddEllipse(new Rectangle(90, 350, 30, 30));
            ship.AddEllipse(new Rectangle(120, 350, 30, 30));
            ship.AddEllipse(new Rectangle(30, 400, 30, 30));
            ship.AddEllipse(new Rectangle(60, 400, 30, 30));
            ship.AddEllipse(new Rectangle(90, 400, 30, 30));
            ship.AddEllipse(new Rectangle(30, 450, 30, 30));
            ship.AddEllipse(new Rectangle(60, 450, 30, 30));
            ship.AddEllipse(new Rectangle(30, 500, 30, 30));
            g.DrawPath(new Pen(Color.Blue, 2), square);
        }
        
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawPath(new Pen(Color.Blue, 2), square);
            g.DrawPath(new Pen(Color.Red, 2), ship);
        }
    }
}
