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
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Biginteger q = new Biginteger(a);
                Biginteger w = new Biginteger(b);
                Biginteger e = q + w;
                Biginteger r = q * w;
                Biginteger t = q - w;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(e);
                Console.WriteLine(r);
                Console.WriteLine(t);
                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                }
                else break;
            }
        }
    }
}
