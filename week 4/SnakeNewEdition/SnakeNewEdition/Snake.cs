using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SnakeNewEdition
{
    [Serializable]

    public class Snake
    {
        public char c;
        public ConsoleColor color;
        public List<Point> body;

        public Snake()
        { 
            c = 'o';
            color = ConsoleColor.DarkYellow;
            body = new List<Point>();
            body.Add(new Point(1, 1));
        }

        public void Move(int ox, int oy)
        {
            Console.SetCursorPosition(body[body.Count - 1].x, body[body.Count - 1].y);
            Console.Write(" ");
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += ox;
            body[0].y += oy;

            if (body[0].x == 0)
            {
                body[0].x = 60;
            }
            if (body[0].x == 61)
            {
                body[0].x = 1;
            }
            if (body[0].y == 0)
            {
                body[0].y = 18;
            }
            if (body[0].y == 19)
            {
                body[0].y = 1;
            }

            Draw();
        }

        public bool Eat(Fruit fruit)
        {
            if (body[0].x == fruit.Food.x && body[0].y == fruit.Food.y)
            {
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));

                return true;
            }
            else return false;
        }

        public bool Collision(Snake snake, Wall wall)
        {
            for (int i = 1; i < snake.body.Count - 1; i++)
            {
                if (body[0].x == snake.body[i].x && body[0].y == snake.body[i].y)
                {
                    return true;
                }
            }
            foreach(var v in wall.body)
            {
                if (body[0].x == v.x && body[0].y == v.y)
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            if (body.Count != 1)
            {
                Console.SetCursorPosition(body[0].x, body[0].y);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("o");
                Console.ForegroundColor = color;
                Console.SetCursorPosition(body[body.Count - 1].x, body[body.Count - 1].y);
                Console.Write("o");
                Console.SetCursorPosition(body[1].x, body[1].y);
                Console.Write("o");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(body[0].x, body[0].y);
                Console.Write("o");
            }
        }

        public bool Newlevel(Score score)
        {
            if (score.score % 10 == 0 && body.Count != 1) return true;
            return false;
        }

        public void Serialize(Snake snake)
        {
            if (File.Exists("savesnake.xml") == true)
            {
                File.Delete("savesnake.xml");
            }
            XmlSerializer save = new XmlSerializer(typeof(Snake));
            FileStream fs = new FileStream("savesnake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            save.Serialize(fs, snake);
            fs.Close();
        }

        public Snake Deserialize()
        {
            XmlSerializer open = new XmlSerializer(typeof(Snake));
            FileStream fs = new FileStream("savesnake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Snake snake = open.Deserialize(fs) as Snake;
            fs.Close();
            return snake;
        }
    }
}
