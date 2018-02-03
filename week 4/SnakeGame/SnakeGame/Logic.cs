using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Logic
    {
        public List<Point> body;

        
        public Logic()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
        }
        public void Move(int ox, int oy, Field f, Fruit fr, Logic a)

        {
            for (int i = 0; i < body.Count; i++)
            {
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(' ');
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
                Console.WriteLine("o");
                cnt++;
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
    }
}
