using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easycalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                int a = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                label2.Text = Convert.ToString(a);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                int a = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                label2.Text = Convert.ToString(a);
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                int a = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                label2.Text = Convert.ToString(a);
            }
        }
    }
}
