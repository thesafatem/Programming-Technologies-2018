using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

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
            Console.SetWindowSize(f.columns, f.k + 3);
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
                Console.Write(z);
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
                if (q.Key == ConsoleKey.S)
                {
                    if (File.Exists("savelogic.xml") == true)
                    {
                        File.Delete("savelogic.xml");
                    }
                    if (File.Exists("savefield.xml") == true)
                    {
                        File.Delete("savefield.xml");
                    }
                    if (File.Exists("savefruit.xml") == true)
                    {
                        File.Delete("savefruit.xml");
                    }
                    XmlSerializer savelogic = new XmlSerializer(typeof(Logic));
                    FileStream fs = new FileStream("savelogic.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    savelogic.Serialize(fs, a);
                    fs.Close();
                    XmlSerializer savefield = new XmlSerializer(typeof(Field));
                    FileStream fss = new FileStream("savefield.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    savefield.Serialize(fss, f);
                    fss.Close();
                    XmlSerializer savefruit = new XmlSerializer(typeof(Fruit));
                    FileStream fsss = new FileStream("savefruit.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    savefruit.Serialize(fsss, fr);
                    fsss.Close();
                }
                if (q.Key == ConsoleKey.L)
                {
                    XmlSerializer openlogic = new XmlSerializer(typeof(Logic));
                    FileStream fs = new FileStream("savelogic.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    a = openlogic.Deserialize(fs) as Logic;
                    XmlSerializer openfield = new XmlSerializer(typeof(Field));
                    FileStream fss = new FileStream("savefield.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    f = openfield.Deserialize(fss) as Field;
                    XmlSerializer openfruit = new XmlSerializer(typeof(Fruit));
                    FileStream fsss = new FileStream("savefruit.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    fr = openfruit.Deserialize(fsss) as Fruit;
                    fs.Close();
                    fss.Close();
                    fsss.Close();
                    Console.Clear();
                    a.Draw();
                    f.Draw();
                    fr.MakeFood(f);
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
                    Field.level++;
                    f = new Field(Field.level);
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
                    z = "Level: " + Field.level.ToString();
                    Console.SetCursorPosition(0, f.k + 1);
                    Console.WriteLine(z);
                }
            }
        }
    }
}
