using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billions
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Biginteger q = new Biginteger(a);
            Biginteger w = new Biginteger(b);
            Biginteger e = q + w;
            Biginteger r = q * w;
            Biginteger t = q - w;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(e);
            Console.WriteLine(r);
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
