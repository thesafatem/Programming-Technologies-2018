using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    public class Catalog
    {
        public static List<Product> shop;
        public Catalog()
        {
            shop = new List<Product>();
            /*FileStream fs = new FileStream(@"C:\KBTU\COURSE I\SEMESTER II\PROGRAMMING PRINCIPLES II\labcheck\catalog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string d = sr.ReadToEnd();
            string[] s = d.Split('\n');
            foreach(var v in s)
            {
                string[] v1 = v.Split(' ');
                shop.Add(new Product(v1[0], double.Parse(v1[1]), int.Parse(v1[2])));
            }
            fs.Close();
            sr.Close();*/
            shop.Add(new Product("potato", 160, 30));
            shop.Add(new Product("cheese", 1600, 27));
            shop.Add(new Product("bread", 80, 100));
        }

        public void Menu(int cursor, int right)
        {
            string[] k = new string[2];
            k[0] = "Show Basket";
            k[1] = "Add Product";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < shop.Count; i++)
            {
                if (cursor == i && right == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(0, i);
                Console.WriteLine(shop[i].all);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 2; i++)
            {
                if (cursor % 2 == 0 && right == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(40, i);
                Console.WriteLine(k[i]);
            }
        }

        public void Plus()
        {
            Console.Clear();
            Console.WriteLine("Enter the information about product");
            string s = Console.ReadLine();
            string[] s1 = s.Split(' ');
            shop.Add(new Product(s1[0], double.Parse(s1[1]), int.Parse(s1[2])));
            Console.Clear();
        }

        public void AddBasket(int cursor)
        {
            bool b = true;
            for (int i = 0; i < Basket.basket.Count; i++)
            {
                if (Basket.basket[i].name == shop[cursor].name)
                {
                    Basket.basket[i].amount++;
                    b = false;
                    break;
                }
            }
            if (b) Basket.basket.Add(new Product(shop[cursor].name, shop[cursor].cost, 1));
            shop[cursor].amount--;
        }
    }
}
