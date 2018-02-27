using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mid2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1000000000;
            int min2 = 100000000;
            string n = File.ReadAllText(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\input.txt");
            string[] x = n.Split(' ');
            int[] f = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                f[i] = int.Parse(x[i]);
                if (f[i] < min)
                {
                    min = f[i];
                    int k = i;
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (f[i] < min2 && f[i] != min)
                {
                    min2 = f[i];
                }
            }
            File.WriteAllText(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\output.txt", min2.ToString());
            Console.ReadKey();
        }
    }
}
