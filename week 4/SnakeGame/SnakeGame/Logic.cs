using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeGame
{
    public class Logic
    {
        public List<Point> body;
        public string name;
        public static int occasion = 2;
        public string maxscore;
        public int compare;
        public Logic()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
        }
        public void Move(int ox, int oy, Field f, Fruit fr, Logic a)
        {
            if (Collisionwithfruit(fr, f) != true)
            {
                Console.SetCursorPosition(body[body.Count - 1].x, body[body.Count - 1].y);
                Console.Write(" ");
            }
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += ox;
            body[0].y += oy;
            if (body[0].x == 0)
            {
                body[0].x = f.columns - 2;
            }
            if (body[0].x == f.columns - 1)
            {
                body[0].x = 1;
            }
            if (body[0].y == 0)
            {
                body[0].y = f.k - 2;
            }
            if (body[0].y == f.k - 1)
            {
                body[0].y = 1;
            }
            Draw(ox, oy);
        }


        
        public void Draw()
        {
            int cnt = 0;
            foreach (Point p in body)
            {
                if (cnt == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.SetCursorPosition(p.x, p.y);
                Console.Write("o");
                cnt++;
            }
        }
        public void Draw (int ox, int oy)
        {
            if (body.Count != 1)
            {
                Console.SetCursorPosition(body[0].x, body[0].y);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("o");
                Console.SetCursorPosition(body[body.Count - 1].x, body[body.Count - 1].y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("o");
                Console.SetCursorPosition(body[1].x, body[1].y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("o");
            }
            else
            {
                Draw();
            }
        }
        public bool Collisionwithbody()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y) return true;
            }
            return false;
        }
        public bool Collisionwithfruit(Fruit fr, Field f)
        {
            if (body[0].x == fr.Food.x && body[0].y == fr.Food.y)
            {
                return true;
            }
            return false;
        }
        public bool Collisionwithobstacle(Field f)
        {
            foreach (Point p in Field.fild)
            {
                if (body[0].x == p.x && body[0].y == p.y && p.x != 0 && p.y != 0 && p.x != f.columns && p.y != f.k) return true;
            }
            return false;
        }
        public void askme()
        {
            string hello = "Please, enter your name to start the game";
            Console.WriteLine(hello);
            Console.CursorVisible = false;
            name = Console.ReadLine();
            if (File.Exists(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\week 4\" + name + ".txt") == true)
            {
                occasion = 1;
            }
            else occasion = 2;
            if (occasion == 2)
            {
                Console.Clear();
                Console.WriteLine("Hello, " + name + "!");
                Console.WriteLine("Wow, it's your first play!");
                Console.WriteLine("Good luck!");
            }
            if (occasion == 1)
            {
                Console.Clear();
                StreamReader sr = new StreamReader(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\week 4\" + name + ".txt");
                maxscore = sr.ReadToEnd();
                compare = int.Parse(maxscore);
                Console.WriteLine("Hello, " + name + "!");
                Console.WriteLine("Wow, your previous maximal score is " + maxscore + "!");
                Console.WriteLine("Good Luck!");
                sr.Close();
            }
            Console.WriteLine("*Press any button to start*");
            Console.ReadKey();
        }
    }
}
