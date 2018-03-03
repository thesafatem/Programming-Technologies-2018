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
            bool active = true;
            int mod = 1;
            int cursor = 0;
            int right = 0;
            Console.CursorVisible = false;
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
                            if (cursor < 1) cursor = Catalog.shop.Count - 1;
                            catalog.Menu(cursor, right);
                            break;
                        case ConsoleKey.DownArrow:
                            cursor++;
                            if (cursor == Catalog.shop.Count) cursor = 0;
                            catalog.Menu(cursor, right);
                            break;
                        case ConsoleKey.Enter:
                            if (right == 0) catalog.AddBasket(cursor);
                            else if (cursor % 2 == 0)
                            {
                                Console.Clear();
                                cursor = 0;
                                mod = 2;
                            }
                            else
                            {
                                mod = 3;
                            }
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
                    basket.Menu(cursor);
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            cursor--;
                            if (cursor < 1) cursor = Basket.basket.Count - 1;
                            basket.Menu(cursor);
                            break;
                        case ConsoleKey.DownArrow:
                            cursor++;
                            if (cursor == Basket.basket.Count) cursor = 0;
                            basket.Menu(cursor);
                            break;
                        case ConsoleKey.Escape:
                            Console.Clear();
                            cursor = 0;
                            mod = 1;
                            break;
                    }
                }
                if (mod == 3)
                {
                    catalog.Plus();
                    mod = 1;
                }
            }
        }
    }
}
