using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mid4
{
    class Write
    {

        public Write()
        {

        }

        public void Draw1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }
        }
        public void Draw2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }
        }
        public void Draw3()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("********");
            }
        }
    }
}
