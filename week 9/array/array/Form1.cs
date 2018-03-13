using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {

        Button[,] btn = new Button[10, 7];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Button b = new Button();
                    b.Location = new Point(10 + 30 * j, 10 + 30 * i);
                    b.Size = new Size(30, 30);
                    b.BackColor = System.Drawing.SystemColors.Window;
                    b.Click += new System.EventHandler(click);
                    Controls.Add(b);
                    btn[i,j] = b;
                }
            }
        }

        private void click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor == System.Drawing.SystemColors.Highlight)
                b.BackColor = System.Drawing.SystemColors.Window;
            else
                b.BackColor = System.Drawing.SystemColors.Highlight;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (btn[i, j] == b)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            if (btn[k, j] != b)
                            {
                                if (btn[k, j].BackColor == System.Drawing.SystemColors.Highlight)
                                    btn[k, j].BackColor = System.Drawing.SystemColors.Window;
                                else
                                    btn[k, j].BackColor = System.Drawing.SystemColors.Highlight;
                            }
                        }
                        for (int l = 0; l < 7; l++)
                        {
                            if (btn[i, l] != b)
                            {
                                if (btn[i, l].BackColor == System.Drawing.SystemColors.Highlight)
                                    btn[i, l].BackColor = System.Drawing.SystemColors.Window;
                                else
                                    btn[i, l].BackColor = System.Drawing.SystemColors.Highlight;
                            }
                        }
                        break;
                    }
                }
            }
        }
        

        
    }
}
