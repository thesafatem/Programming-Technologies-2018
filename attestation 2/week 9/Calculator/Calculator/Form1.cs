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
        Calc calc = new Calc();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void Enter_Numbers(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (textBox1.Text == "0" || textBox1.Text == "It is impossible" || calc.complete == true)
            {
                textBox1.Text = b.Text;
                calc.complete = false;
            }
            else textBox1.Text += b.Text;
            if (calc.operation != "") calc.sec = true;
            if (calc.entermod == 1)
            {
                calc.first = double.Parse(textBox1.Text);
            }
            else calc.second = double.Parse(textBox1.Text);
        }

        private void change_sign_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text) * (-1)).ToString();
            if (calc.operation != "") calc.sec = true;
            if (calc.entermod == 1) calc.first = double.Parse(textBox1.Text);
            else calc.second = double.Parse(textBox1.Text);
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",") != true && textBox1.Text != "It is impossible")
                textBox1.Text += ",";
        }

        private void delete_last_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 1)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            else textBox1.Text = "0";
            if (calc.entermod == 1) calc.first = double.Parse(textBox1.Text);
            else calc.second = double.Parse(textBox1.Text);
        }

        private void Mono_operations(object sender, EventArgs e)
        {
            Button b = sender as Button;
            calc.operation = b.Text;
            calc.first = double.Parse(textBox1.Text);
            calc.Mono(calc.operation);
            if (calc.error != "")
            {
                textBox1.Text = calc.error;
                calc.error = "";
            }
            else textBox1.Text = calc.result.ToString();
            calc.complete = true;
        }

        private void Bi_operations(object sender, EventArgs e)
        {
            calc.entermod = 2;
            calc.second = calc.first;
            if (calc.operation !=  "" && calc.sec == true)
            {
                calc.Bi(calc.operation);
                if (calc.error != "")
                {
                    textBox1.Text = calc.error;
                    calc.error = "";
                }
                else textBox1.Text = calc.result.ToString();
                calc.first = calc.result;
            }
            Button b = sender as Button;
            calc.operation = b.Text;
            calc.complete = true;
            calc.sec = false;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (calc.operation != "")
            {
                calc.Bi(calc.operation);
                if (calc.error != "")
                {
                    textBox1.Text = calc.error;
                    calc.error = "";
                }
                else textBox1.Text = calc.result.ToString();
                calc.first = calc.result;
                calc.entermod = 1;
                calc.complete = true;
                calc.sec = false;
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            if (calc.entermod == 1) calc.first = 0;
            else calc.second = 0;
        }

        private void C_Click(object sender, EventArgs e)
        {
            calc = new Calc();
            textBox1.Text = "0";
        }
    }
}
