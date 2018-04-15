using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicButton
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[6, 6];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i ++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Button b = new Button();
                    b.Size = new Size(30, 30);
                    b.Location = new Point(30 + 30 * i, 30 + 30 * j);
                    b.BackColor = Color.White;
                    b.Click += new System.EventHandler(click);
                    Controls.Add(b);
                    btn[i, j] = b;
                }
            }
        }

        public void click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (btn[i,j] == b)
                    {
                        for (int k = 0; k < 6; k++)
                        {
                            btn[i, k].BackColor = Color.Crimson;
                            btn[k, j].BackColor = Color.Crimson;
                        }
                    }
                }
            }
        }

        
    }
}
