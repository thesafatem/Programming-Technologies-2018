using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    class Basket
    {
        public static List<Product> basket;
        public Basket()
        {
           basket = new List<Product>();
        }

        public void Menu(int cursor)
        {
            for (int i = 0; i < basket.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (cursor == i)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(basket[i].all);
            }
        }

        /*public void Delete(cursor)
        {

        }*/




    }
}
