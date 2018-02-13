using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int level = 1;
            int highscore = -1;
            Logic a = new Logic();
            Field f = new Field(level);
            Fruit fr = new Fruit(f, a);
            a.askme();
            Console.Clear();
            Console.CursorVisible = false;
            fr.MakeFood(f);
            int exception = 0;
            string u = "Score: 0";
            int score = 0;
            string z = "Level: 1";
            a.Draw();
            while (true)
            {
                f.Draw();
                for (int i = 0; i < u.Length; i++)
                {
                    Console.SetCursorPosition(i, f.k);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(0, f.k);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(u);
                Console.WriteLine(z);
                if (a.Collisionwithfruit(fr, f) == true)
                {
                    a.body.Add(new Point(0, 0));
                    fr = new Fruit(f, a);
                    fr.MakeFood(f);
                    score += 10;
                    u = "Score: " + score.ToString();
                }
                ConsoleKeyInfo q = Console.ReadKey();
                if (q.Key == ConsoleKey.UpArrow)
                {
                    if (exception == 2 && a.body.Count != 1) continue;
                    a.Move(0, -1, f, fr, a);
                    a.Draw(0, -1);
                    exception = 1;
                }
                if (q.Key == ConsoleKey.DownArrow)
                {
                    if (exception == 1 && a.body.Count != 1) continue;
                    a.Move(0, 1, f, fr, a);
                    a.Draw(0, 1);
                    exception = 2;
                }
                if (q.Key == ConsoleKey.LeftArrow)
                {
                    if (exception == 4 && a.body.Count != 1) continue;
                    a.Move(-1, 0, f, fr, a);
                    a.Draw(-1, 0);
                    exception = 3;
                }
                if (q.Key == ConsoleKey.RightArrow)
                {
                    if (exception == 3 && a.body.Count != 1) continue;
                    a.Move(1, 0, f, fr, a);
                    a.Draw(1, 0);
                    exception = 4;
                }

                if (a.Collisionwithbody() == true || a.Collisionwithobstacle(f) == true)
                {
                    if (highscore < score) highscore = score;
                    string to = a.name;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("Your final score is " + score.ToString());
                    Console.WriteLine("Press R to restart or any other button to quit");
                    ConsoleKeyInfo w = Console.ReadKey();
                    if (w.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        level = 1;
                        f = new Field(level);
                        score = 0;
                        a = new Logic();
                        fr = new Fruit(f, a);
                        fr.MakeFood(f);
                        for (int i = 0; i < u.Length; i++)
                        {
                            Console.SetCursorPosition(i, f.k);
                            Console.Write(" ");
                        }
                        u = "Score: 0";
                        z = "Level: 1";
                        Console.SetCursorPosition(0, f.k);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(u);
                        Console.WriteLine(z);
                    }
                    else
                    {
                        if (Logic.occasion == 2)
                        {
                            System.IO.File.WriteAllText(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\week 4\" + to + ".txt", highscore.ToString());
                        }
                        else
                        {
                            if (a.compare < highscore)
                            {
                                System.IO.File.WriteAllText(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\week 4\" + to + ".txt", highscore.ToString());
                            }
                        }
                        break;
                    }
                }
                if (a.body.Count % 15 == 0)
                {
                    level++;
                    f = new Field(level);
                    a = new Logic();
                    fr = new Fruit(f, a);
                    Console.Clear();
                    a.Draw();
                    f.Draw();
                    fr.MakeFood(f);
                    for (int i = 0; i < z.Length; i++)
                    {
                        Console.SetCursorPosition(i, f.k + 1);
                        Console.Write(" ");
                    }
                    z = "Level: " + level.ToString();
                    Console.SetCursorPosition(0, f.k + 1);
                    Console.WriteLine(z);
                }
            }
        }
    }
}
