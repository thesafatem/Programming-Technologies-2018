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
                //if (basket[i].amount == 0) continue;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (cursor == i)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(0, i);
                Console.WriteLine(basket[i].name + " " + basket[i].cost + " " + basket[i].amount);
            }
        }

        public void Delete(int cursor)
        {
            bool b = true;
            for (int i = 0; i < Catalog.shop.Count; i++)
            {
                if (basket[cursor].name == Catalog.shop[i].name)
                {
                    Catalog.shop[i].amount++;
                    b = false;
                    break;
                }
            }
            if (b) Catalog.shop.Add(new Product(basket[cursor].name, basket[cursor].cost, 1));
            basket[cursor].amount--;
            
            /*if (basket[cursor].amount == 0)
            {
                basket.Remove(basket[cursor]);
            }*/
        }
    }
}
