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

    public class Score
    {
        public int score;
        ConsoleColor color = new ConsoleColor();

        public Score()
        {
            score = 0;
            color = ConsoleColor.DarkGreen;
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(0, 21);
            Console.Write("Score: " + score);
        }

        public void Serialize(Score score)
        {
            if (File.Exists("savescore.xml") == true)
            {
                File.Delete("savescore.xml");
            }
            XmlSerializer save = new XmlSerializer(typeof(Score));
            FileStream fs = new FileStream("savescore.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            save.Serialize(fs, score);
            fs.Close();
        }

        public Score Deserialize()
        {
            XmlSerializer open = new XmlSerializer(typeof(Score));
            FileStream fs = new FileStream("savescore.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Score score = open.Deserialize(fs) as Score;
            fs.Close();
            return score;
            //score.Draw();
        }
    }
}
