using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Calc
    {
        public double first;
        public double second;
        public bool sec;
        public bool complete;
        public int entermod;
        public double result;
        public string operation;
        public string error;

        public Calc()
        {
            first = 0;
            second = 0;
            sec = false;
            complete = false;
            result = 0;
            operation = "";
            error = "";
            entermod = 1;
        }

        int fact (int x)
        {
            if (x != 1) return x * fact(x - 1);
            else return 1;
        }

        public void Mono(string operation)
        {
            switch (operation)
            {
                case "!":
                    if (first < 0) error = "It is impossible";
                    else result = fact((int)Math.Floor(Math.Round(first)));
                    break;
                case "x^2":
                    result = first * first;
                    break;
                case "10^x":
                    result = Math.Pow(10, first);
                    break;
                case "e^x":
                    result = Math.Exp(first);
                    break;
                case "sqrt":
                    if (first >= 0) result = Math.Sqrt(first);
                    else error = "It is impossible";
                    break;
                case "lnx":
                    if (first > 0) result = Math.Log(first);
                    else error = "It is impossible";
                    break;
                case "1/x":
                    if (first != 0) result = 1 / first;
                    else error = "It is impossible";
                    break;
                case "sinx":
                    result = Math.Sin(first);
                    break;
                case "cosx":
                    result = Math.Cos(first);
                    break;
                case "tanx":
                    if (Math.Cos(first) != 0) result = Math.Tan(first);
                    else error = "It is impossible";
                    break;
                case "cotx":
                    if (Math.Tan(first) != 0) result = 1 / Math.Tan(first);
                    else error = "It is impossible";
                    break;
            }
        }

        public void Bi(string operation)
        {
            switch (operation)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "х":
                    result = first * second;
                    break;
                case "÷":
                    if (second != 0) result = first / second;
                    else error = "It is impossible";
                    break;
                case "%":
                    result = first * second / 100;
                    break;
                case "mod":
                    result = first % second;
                    break;
                case "x^y":
                    result = Math.Pow(first, second);
                    break;
                case "sqrt^x":
                    if (first % 2 == 0 && second < 0) error = "It is impossible";
                    else result = Math.Pow(second, 1 / first);
                    break;
                case "logxy":
                    result = Math.Log10(second) / Math.Log10(first);
                    break;
            }
        }
    }
}
