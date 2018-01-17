using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4taskfour
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            Complex q = new Complex(a1, a2);
            Complex w = new Complex(b1, b2);
            Complex d = q + w;
            Complex t = q * w;
            Complex e = q / w;
            Complex p = q - w;
            Console.WriteLine(d);
            Console.WriteLine(t);
            Console.WriteLine(e);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
