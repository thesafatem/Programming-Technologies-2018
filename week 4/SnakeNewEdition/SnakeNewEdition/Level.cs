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

    public class Level
    {
        public int lvl;
        ConsoleColor color = new ConsoleColor();

        public Level()
        {
            lvl = 1;
            color = ConsoleColor.DarkGreen;
        }

        public void Draw()
        {
            Console.SetCursorPosition(0, 20);
            Console.ForegroundColor = color;
            Console.Write("Level: " + lvl);
        }

        public void Serialize(Level level)
        {
            if (File.Exists("savelevel.xml") == true)
            {
                File.Delete("savelevel.xml");
            }
            XmlSerializer save = new XmlSerializer(typeof(Level));
            FileStream fs = new FileStream("savelevel.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            save.Serialize(fs, level);
            fs.Close();
        }

        public Level Deserialize()
        {
            XmlSerializer open = new XmlSerializer(typeof(Level));
            FileStream fs = new FileStream("savelevel.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Level level = open.Deserialize(fs) as Level;
            fs.Close();
            return level;
            //level.Draw();
        }
    }
}
