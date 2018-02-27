using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mid3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(path);
            FileSystemInfo[] fil = dir.GetFileSystemInfos();
            Console.Clear();
            foreach (var v in fil)
            {
                if (v.GetType() == typeof(FileInfo) && v.FullName.Contains("fit"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(v.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
