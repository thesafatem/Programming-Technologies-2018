using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Fruit
    {
        public Point Food;
        public Fruit(Field f, Logic a)
        {
            Random x1 = new Random();
            Random y1 = new Random();
            int _x = x1.Next(1, f.columns - 2);
            int _y = y1.Next(1, f.k - 2);
            bool yes = true;
            while (yes)
            {
                yes = false;
                for (int i = 0; i < a.body.Count; i++)
                {
                    if (a.body[i].x == _x && a.body[i].y == _y)
                    {
                        _x = x1.Next(1, f.columns - 2);
                        _y = y1.Next(1, f.k - 2);
                        yes = true;
                        break;
                    }
                }
            }
            yes = true;
            while (yes)
            {
                yes = false;
                foreach (Point p in Field.fild)
                {
                    if (p.x == _x && p.y == _y )
                    {
                        _x = x1.Next(1, f.columns - 2);
                        _y = y1.Next(1, f.k - 2);
                        yes = true;
                        break;
                    }
                }
            }
            Food = new Point(_x, _y);
        }
        public void MakeFood(Field f)
        {
            Console.SetCursorPosition(Food.x, Food.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine('$');
        }
    }
}