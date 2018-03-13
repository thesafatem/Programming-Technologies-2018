using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polzunok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            button1.Location = new Point(trackBar1.Value + 12, button1.Location.Y);
            button1.Size = new Size(trackBar1.Value, trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
