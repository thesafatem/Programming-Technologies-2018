using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SnakeNewEdition
{
    [Serializable]

    public class Menu
    {
        public string[] scoreboard;
        string[] print = new string[4];
        string[] end = new string[2];
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
            end[0] = "Main Menu";
            end[1] = "Exit";

        }

        public void Draw(int cursor)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(26, 7 + i);
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

        public void Rewrite(Score score)
        {
            bool b = true;
            for (int i = 0; i < 4; i++)
            {
                string[] s = scoreboard[i].Split(' ');
                if (s[0] == name)
                {
                    b = false;
                    if (int.Parse(s[1]) < score.score)
                    {
                        scoreboard[i] = name + " " + score.score.ToString();
                        for (int j = 0; j < i; j++)
                        {
                            string[] h = scoreboard[j].Split(' ');
                            if (int.Parse(s[1]) > int.Parse(h[1]))
                            {
                                for (int k = i; i > j; i--)
                                {
                                    scoreboard[k] = scoreboard[k - 1];
                                }
                                scoreboard[j] = name + " " + score.score.ToString();
                            }
                        }
                    }
                    break;
                }
            }
            if (b)
            {
                for (int i = 0; i < 4; i++)
                {
                    string[] s = scoreboard[i].Split(' ');
                    if (score.score > int.Parse(s[1]))
                    {
                        for (int j = 4; j > i; j--)
                        {
                            scoreboard[j] = scoreboard[j - 1];
                        }
                        scoreboard[i] = name + " " + score.score.ToString();
                        break;
                    }
                }
            }
        }

        public void Serialize(Menu menu)
        {
            if (File.Exists("savemenu.xml") == true)
            {
                File.Delete("savemenu.xml");
            }
            XmlSerializer save = new XmlSerializer(typeof(Menu));
            FileStream fs = new FileStream("savemenu.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            save.Serialize(fs, menu);
            fs.Close();
        }

        public Menu Deserialize()
        {
            XmlSerializer open = new XmlSerializer(typeof(Menu));
            FileStream fs = new FileStream("savemenu.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Menu menu = open.Deserialize(fs) as Menu;
            fs.Close();
            return menu;
        }
    }
}
