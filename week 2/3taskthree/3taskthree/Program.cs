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
            string text = System.IO.File.ReadAllText(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\week 2\2.txt");
            string[] s = text.Split();
            int[] n = new int[s.Length];
            int ans = 10000000;
            for (int i = 0; i < s.Length; i++)
            {
                n[i] = int.Parse(s[i]);
                //Console.WriteLine(n[i]);
            }
            foreach (int k in n)
            {
                for (int i=2; i<=Math.Sqrt(k); i++)
                {
                    if (k % i == 0) break;
                    if (i == (int)Math.Sqrt(k)) if (k < ans) ans = k;
                }
            }
            if (ans != 10000000) Console.WriteLine(ans);
            else Console.WriteLine("There is no primes");
            Console.ReadKey();
        }
    }
}
