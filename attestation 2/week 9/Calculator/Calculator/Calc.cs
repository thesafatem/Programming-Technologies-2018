using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calc
    {
        double first;
        double second;
        double result;
        string operation;

        public Calc()
        {
            first = 0;
            second = 0;
            result = 0;
            operation = "";
        }

        public void Get_First(object sender, EventArgs e)
        {

            first = double.Parse();
        }
    }
}
