using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
 
    class Program
    { 
        public static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            Basket basket = new Basket();
            Console.CursorVisible = false;
            Console.WriteLine("Please, enter the amount of money that you would like to spend");
            Money money = new Money(Console.ReadLine());
            Console.Clear();
            bool active = true;
            int mod = 1;
            int cursor = 0;
            int right = 0;
            while (active)
            {
                if (mod == 1)
                {
                    catalog.Menu(cursor, right);
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            cursor--;
                            if (cursor < 0) cursor = Catalog.shop.Count - 1;
                            catalog.Menu(cursor, right);
                            break;
                        case ConsoleKey.DownArrow:
                            cursor++;
                            if (cursor == Catalog.shop.Count) cursor = 0;
                            catalog.Menu(cursor, right);
                            break;
                        case ConsoleKey.Enter:
                            if (right == 0)
                            {
                                catalog.AddBasket(cursor);
                                if (Catalog.shop[cursor].amount == 0 )
                                {
                                    Catalog.shop.RemoveAt(cursor);
                                    cursor--;
                                    if (cursor == -1) cursor = 0;
                                    Console.Clear();
                                }
                            }
                            else if (cursor % 2 == 0)
                            {
                                Console.Clear();
                                cursor = 0;
                                right = 0;
                                mod = 2;
                            }
                            else
                            {
                                mod = 3;
                            }
                            break;
                        case ConsoleKey.Escape:
                            active = false;
                            break;
                        case ConsoleKey.LeftArrow:
                            right--;
                            if (right == -1) right = 1;
                            catalog.Menu(cursor, right);
                            break;
                        case ConsoleKey.RightArrow:
                            right++;
                            if (right == 2) right = 0;
                            catalog.Menu(cursor, right);
                            break;
                    }
                }
                if (mod == 2)
                {
                    basket.Menu(cursor, right);
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            cursor--;
                            if (cursor < 0) cursor = Basket.basket.Count - 1;
                            basket.Menu(cursor, right);
                            break;
                        case ConsoleKey.DownArrow:
                            cursor++;
                            if (cursor == Basket.basket.Count) cursor = 0;
                            basket.Menu(cursor, right);
                            break;
                        case ConsoleKey.LeftArrow:
                            right--;
                            if (right == -1) right = 1;
                            basket.Menu(cursor, right);
                            break;
                        case ConsoleKey.RightArrow:
                            right++;
                            if (right == 2) right = 0;
                            basket.Menu(cursor, right);
                            break;
                        case ConsoleKey.Escape:
                            cursor = 0;
                            right = 0;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            mod = 1;
                            break;
                        case ConsoleKey.Enter:
                            if (right == 0)
                            {
                                basket.Delete(cursor);
                                if (Basket.basket[cursor].amount == 0)
                                {
                                    Basket.basket.RemoveAt(cursor);
                                    cursor--;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                basket.Buy(money);
                            }
                            break;
                    }
                }
                if (mod == 3)
                {
                    catalog.Plus();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    mod = 1;
                }
            }
        }
    }
}
