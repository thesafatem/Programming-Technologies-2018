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

        public void Menu(int cursor, int right)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < basket.Count; i++)
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
                Console.WriteLine(basket[i].name + " " + basket[i].cost + " " + basket[i].amount);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (right == 1)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Buy");
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
            if (basket[cursor].amount == 9) Console.Clear();
        }

        public void Buy(Money money)
        {
            int total = 0;
            for (int i = 0; i < basket.Count; i++)
            {
                total += basket[i].cost * basket[i].amount;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (total <= money.money)
            {
                money.money -= total;
                Console.WriteLine("Thank you for purchasing! You current cash is " + money.money + ".");
                basket.Clear();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough money to pay for all things. Please, remove something from your basket.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
