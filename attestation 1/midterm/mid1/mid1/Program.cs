using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int x = int.Parse(n);
            Console.WriteLine(Math.Pow(2, x));
            Console.ReadKey();
        }
    }
}
