using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Move(@"C:\KBTU\COURSE I\SEMESTER II\PHYSICS I", @"C:");
            Console.Write("OK");
            Console.ReadKey();
        }
    }
}
