using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3taskthree
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Rectangle q = new Rectangle();
            Rectangle w = new Rectangle(a);
            Rectangle e = new Rectangle(b,c);
            Console.WriteLine(q);
            Console.WriteLine(w);
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
