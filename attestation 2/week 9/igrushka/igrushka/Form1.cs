using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igrushka
{
    public partial class Form1 : Form
    {
        List<Button> l = new List<Button>();
        Random random = new Random();
        Button player = new Button();
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Size = new Size(35, 35);
            player.Location = new Point(0, 340);
            player.Text = "You";
            player.BackColor = System.Drawing.SystemColors.Highlight;
            Controls.Add(player);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Size = new Size(35, 35);
            b.BackColor = System.Drawing.SystemColors.HighlightText;
            int x = random.Next(0, 450);
            b.Location = new Point(x, 0);
            b.Text = (x%10).ToString();
            l.Add(b);
            Controls.Add(b);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < l.Count; i++)
            {
                l[i].Location = new Point(l[i].Location.X, l[i].Location.Y + 7);
                if (l[i].Location.Y > player.Location.Y + 35)
                {
                    l[i].Hide();
                    l.RemoveAt(i);
                }
                if (int.Parse(l[i].Text) % 2 != 0 && Math.Abs(l[i].Location.Y - player.Location.Y) < 35 && Math.Abs(l[i].Location.X - player.Location.X) < 35)
                {

                    timer1.Stop();
                    timer2.Stop();
                    for (int k = 0; k < l.Count; k++)
                    {
                        l[k].Hide();
                    }
                    player.Hide();
                    trackBar1.Hide();
                    label1.Visible = true;
                    label2.Text += score.ToString();
                    label2.Visible = true;
                }
                else if (int.Parse(l[i].Text) % 2 == 0 && Math.Abs(l[i].Location.Y - player.Location.Y) < 35 && Math.Abs(l[i].Location.X - player.Location.X) < 35)
                {
                    score += int.Parse(l[i].Text);
                    l[i].Hide();
                    l.RemoveAt(i);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.Location = new Point(trackBar1.Value, player.Location.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
