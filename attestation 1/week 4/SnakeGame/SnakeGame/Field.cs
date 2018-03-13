using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SnakeGame
{
    [Serializable]

    public class Field
    {
        public static List<Point> fild;
        string s;
        public int k;
        public int columns;
        public static int level;
        public Field()
        {

        }
        public Field (int q)
        {
            level = q;
            fild = new List<Point>();
            Dofield(level);
        }
        public void Dofield (int level)
        {
            StreamReader sr = new StreamReader(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\week 4\level" + level + ".txt");
            k = int.Parse(sr.ReadLine());
            for (int i = 0; i < k; i++)
            {
                s = sr.ReadLine();
                for (int j=0; j<s.Length; j++)
                {
                    if (s[j] == '*')
                    {
                        fild.Add(new Point(j, i));
                    }
                }
            }
            sr.Close();
            columns = s.Length;
        }
        public void Draw()
        {
            foreach (Point p in fild)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(p.x, p.y);
                Console.WriteLine("#");
            }
        }
    }
}
