using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNewEdition
{
    [Serializable]

    public class Menu
    {
        public string[] scoreboard;
        string[] print = new string[4];
        public ConsoleColor color;
        public string name;

        public Menu()
        {
            scoreboard = new string[5];
            for (int i = 0; i < 5; i++)
            {
                scoreboard[i] = "xxx 0";
            }
            color = ConsoleColor.DarkRed;
            print[0] = "New Game";
            print[1] = "Load Game";
            print[2] = "Scoreboard";
            print[3] = "Exit";

        }

        public void Draw(int cursor)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(26, 7+i);
                if (i == cursor % 4)
                {
                    Console.BackgroundColor = ConsoleColor.White; 
                    Console.WriteLine(print[i]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(print[i]);
                }
            }
        }

        public void Score()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(25, 8+i);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine((i+1) + ". " + scoreboard[i]);
            }
        }

        public void Hello()
        {
            Console.Clear();
            Console.SetCursorPosition(24, 11);
            Console.WriteLine("Enter your name");
            Console.SetCursorPosition(26, 12);
            name = Console.ReadLine();
        }
    }
}
