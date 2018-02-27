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

    public class Wall
    {
        public List<Point> body;
        public char c;
        public ConsoleColor color;

        public Wall()
        {
            c = '#';
            color = ConsoleColor.DarkCyan;
            body = new List<Point>();
        }

        public void Make(Level level)
        {
            StreamReader sr = new StreamReader(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\week 4\level" + level.lvl + ".txt");
            for (int i = 0; i < 20; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < 62; j++)
                {
                    if (s[j] == '*')
                    {
                        body.Add(new Point(j, i));
                    }
                }
            }
            sr.Close();
        }

        public void Draw()
        {
            foreach (var v in body)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(v.x, v.y);
                Console.Write(c);
            }
        }

        public void Serialize(Wall wall)
        {
            if (File.Exists("savewall.xml") == true)
            {
                File.Delete("savewall.xml");
            }
            XmlSerializer save = new XmlSerializer(typeof(Wall));
            FileStream fs = new FileStream("savewall.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            save.Serialize(fs, wall);
            fs.Close();
        }

        public Wall Deserialize()
        {
            XmlSerializer open = new XmlSerializer(typeof(Wall));
            FileStream fs = new FileStream("savewall.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Wall wall = open.Deserialize(fs) as Wall;
            fs.Close();
            return wall;
            //wall.Draw();
        }
    }
}
