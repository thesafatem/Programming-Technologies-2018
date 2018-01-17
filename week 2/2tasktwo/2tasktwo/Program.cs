using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2tasktwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\week 2\2.txt");
            string[] s = text.Split();
            int[] n = new int[s.Length];
            for (int i=0; i<s.Length; i++)
            {
                n[i] = int.Parse(s[i]);
            }
            Console.WriteLine(n.Max());
            Console.WriteLine(n.Min());
            Console.ReadKey();
        }
    }
}
