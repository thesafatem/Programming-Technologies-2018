using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Calc calc = new Calc();
            textBox1.Text = "0";
        }

        private void Enter_Numbers(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (textBox1.Text != "0") textBox1.Text += b.Text;
            else textBox1.Text = b.Text;
        }

        private void change_sign_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text) * (-1)).ToString();
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",") != true) textBox1.Text += ",";
        }

        private void delete_last_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void Mono_operations(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Text)
            {
                case "!":
                    break;
                case "x^2":
                    break;
                case "10^x":
                    break;
                case "e^x":
                    break;
                case "sqrt":
                    break;
                case "lnx":
                    break;
                case "1/x":
                    break;
                case "sinx":
                    break;
                case "cosx":
                    break;
                case "tanx":
                    break;
                case "cotx":
                    break;
            }
        }
    }
}
