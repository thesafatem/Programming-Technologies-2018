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
        GraphicsPath star;

        public Form1()
        {
            InitializeComponent();
            star = new GraphicsPath();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.Clear(Color.Black);
            g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(10, 10, 766, 442));
            pictureBox1.Refresh();
        }
    }
}
