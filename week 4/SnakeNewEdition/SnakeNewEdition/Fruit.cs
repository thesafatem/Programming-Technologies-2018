using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeNewEdition
{
    [Serializable]

    public class Fruit
    {
        public Point Food;
        public ConsoleColor color;
        public char c;

        public Fruit()
        {
            c = '$';
            color = ConsoleColor.DarkGreen;
            
        }

        public void Make(Snake snake, Wall wall)
        {
            int x = new Random().Next(1, 61);
            int y = new Random().Next(1, 19);
            bool yes = true;
            while (yes)
            {
                yes = false;
                for (int i = 0; i < snake.body.Count; i++)
                {
                    if (snake.body[i].x == x && snake.body[i].y == y)
                    {
                        x = new Random().Next(1, 61);
                        y = new Random().Next(1, 19);
                        yes = true;
                        break;
                    }
                }
                foreach (var v in wall.body)
                {
                    if (v.x == x && v.y == y)
                    {
                        x = new Random().Next(1, 61);
                        y = new Random().Next(1, 19);
                        yes = true;
                        break;
                    }
                }
            }
            Food = new Point(x, y);
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(Food.x, Food.y);
            Console.ForegroundColor = color;
            Console.WriteLine(c);
        }

        public void Serialize(Fruit fruit)
        {
            if (File.Exists("savefruit.xml") == true)
            {
                File.Delete("savefruit.xml");
            }
            XmlSerializer save = new XmlSerializer(typeof(Fruit));
            FileStream fs = new FileStream("savefruit.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            save.Serialize(fs, fruit);
            fs.Close();
        }

        public Fruit Deserialize()
        {
            XmlSerializer open = new XmlSerializer(typeof(Fruit));
            FileStream fs = new FileStream("savefruit.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Fruit fruit = open.Deserialize(fs) as Fruit;
            fs.Close();
            return fruit;
            //fruit.Draw();
        }
    }
}
