using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;
            int level = 1;
            bool gameon = true;
            Logic a = new Logic();
            Field f = new Field(level);
            Fruit fr = new Fruit(f, a);
            fr.MakeFood(f);
            while (gameon)
            {
                f.Draw();
                a.Draw();
                if (a.Collisionwithfruit(fr, f) == true)
                {
                    a.body.Add(new Point(0, 0));
                    fr = new Fruit(f, a);
                    fr.MakeFood(f);
                }
                ConsoleKeyInfo q = Console.ReadKey();
                if (q.Key == ConsoleKey.UpArrow)
                {
                    a.Move(0, -1, f, fr, a);
                }
                if (q.Key == ConsoleKey.DownArrow)
                {
                    a.Move(0, 1, f, fr, a);
                }
                if (q.Key == ConsoleKey.LeftArrow)
                {
                    a.Move(-1, 0, f, fr, a);
                }
                if (q.Key == ConsoleKey.RightArrow)
                {
                    a.Move(1, 0, f, fr, a);
                }
                

                if (a.Collisionwithbody() == true || a.Collisionwithobstacle(f) == true)
                {
                    Console.Clear();
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("Press R to restart or any other button to quit");
                    ConsoleKeyInfo w = Console.ReadKey();
                    if (w.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        level = 1;
                        a = new Logic();
                        f = new Field(level);
                        fr = new Fruit(f, a);
                        fr.MakeFood(f);
                    }
                    else
                    {
                        break;
                    }
                }
                if (a.body.Count % 7 == 0)
                {
                    level++;
                    f = new Field(level);
                    a = new Logic();
                    fr = new Fruit(f, a);
                    Console.Clear();
                    a.Draw();
                    f.Draw();
                    fr.MakeFood(f);
                }
            }
        }
    }
}
