using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1taskone
{
    class Program
    {
        static void ShowDirect(DirectoryInfo direct, int x)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            FileSystemInfo[] fild = direct.GetFileSystemInfos();
            for (int i = 0; i < fild.Length; i++)
            {
                FileSystemInfo fsi = fild[i];
                if (i == x)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                if (fild[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(fild[i].Name);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            int cursor = 0;
            int limit = dir.GetFileSystemInfos().Length;
            ShowDirect(dir, cursor);
            while (true)
            {
                try
                {
                    Console.CursorVisible = false;
                    ConsoleKeyInfo button = Console.ReadKey();
                    if (button.Key == ConsoleKey.UpArrow)
                    {
                        cursor--;
                        if (cursor < 0) cursor = limit - 1;
                    }
                    if (button.Key == ConsoleKey.DownArrow)
                    {
                        cursor++;
                        if (cursor == limit) cursor = 0;
                    }
                    if (button.Key == ConsoleKey.F7)
                    {
                        Console.Clear();
                        Console.WriteLine("Please, enter the path");
                        string path = Console.ReadLine();
                        if (dir.GetFileSystemInfos()[cursor].GetType() == typeof(FileInfo))
                        {
                            File.Move(dir.GetFileSystemInfos()[cursor].FullName, path);
                        }
                        else
                        {
                            Directory.Move(dir.GetFileSystemInfos()[cursor].FullName, path);
                        }
                    }
                    if (button.Key == ConsoleKey.Enter)
                    {
                        if (dir.GetFileSystemInfos()[cursor].GetType() != typeof(FileInfo))
                        {
                            dir = new DirectoryInfo(dir.GetFileSystemInfos()[cursor].FullName);
                            cursor = 0;
                            limit = dir.GetFileSystemInfos().Length;
                        }
                        else
                        {
                            StreamReader read = new StreamReader(dir.GetFileSystemInfos()[cursor].FullName);
                            string output = read.ReadToEnd();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine(output);
                            Console.ReadKey();
                        }
                    }
                    if (button.Key == ConsoleKey.Escape)
                    {
                        if (dir.Parent != null)
                        {
                            dir = dir.Parent;
                            cursor = 0;
                            limit = dir.GetFileSystemInfos().Length;
                        }
                        else break;
                    }
                    ShowDirect(dir, cursor);
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(e);
                }
            }
        }
    }
}
