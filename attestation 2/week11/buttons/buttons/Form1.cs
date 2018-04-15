using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttons
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[10, 10];
        Color cconst = Color.White;
        Color cprev;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Color c = Color.White;
                    Button b = new Button();
                    b.Size = new Size(30, 30);
                    b.Location = new Point(30 + 30 * i, 30 + 30 * j);
                    b.Click += new System.EventHandler(click);
                    b.MouseEnter += new System.EventHandler(enter);
                    b.MouseLeave += new System.EventHandler(leave);
                    Controls.Add(b);
                    btn[i, j] = b;
                }
            }
        }

        public void leave(object sender, EventArgs e)
        {
            Button bn = sender as Button;
            bn.BackColor = Color.White;
        }

        public void enter(object sender, EventArgs e)
        {
            Button bn = sender as Button;
            bn.
            bn.BackColor = Color.LightCoral;
        }

        public void click(object sender, EventArgs e)
        {
            Button bn = sender as Button;
            cconst = Color.Crimson;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
