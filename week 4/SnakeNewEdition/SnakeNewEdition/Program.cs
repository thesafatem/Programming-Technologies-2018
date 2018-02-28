using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeNewEdition
{
    class Program
    {
        static Snake snake = new Snake();
        static Wall wall = new Wall();
        static Fruit fruit = new Fruit();
        static bool gameover = false;
        static int direction = 1;
        static Level level = new Level();
        static Score score = new Score();
        public static int speed = 150;

        static void Threadgame()
        {
            while (!gameover)
            {
                switch (direction)
                {
                    case 1:
                        if (!(snake.body.Count != 1 && snake.body[0].x - snake.body[1].x == 0 && snake.body[0].y - snake.body[1].y == 1))
                        {
                            snake.Move(0, -1);
                        }
                        break;
                    case 2:
                        if (!(snake.body.Count != 1 && snake.body[0].x - snake.body[1].x == 0 && snake.body[0].y - snake.body[1].y == -1))
                        {
                            snake.Move(0, 1);
                        }
                        break;
                    case 3:
                        if (!(snake.body.Count != 1 && snake.body[0].x - snake.body[1].x == 1 && snake.body[0].y - snake.body[1].y == 0))
                        {
                            snake.Move(-1, 0);
                        }
                        break;
                    case 4:
                        if (!(snake.body.Count != 1 && snake.body[0].x - snake.body[1].x == -1 && snake.body[0].y - snake.body[1].y == 0))
                        {
                            snake.Move(1, 0);
                        }
                        break;
                }

                snake.Draw();
                wall.Draw();

                if (snake.Collision(snake, wall))
                {
                    gameover = true;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(26, 10);
                    Console.WriteLine("GAME OVER");
                }
                if (snake.Eat(fruit))
                {
                    score.score++;
                    score.Draw();
                    fruit.Make(snake, wall);
                }

                if (snake.Newlevel(score))
                {
                    Console.Clear();
                    level.lvl++;
                    level.Draw();
                    score.Draw();
                    wall.Make(level);
                    snake = new Snake();
                    fruit.Make(snake, wall);
                }

                Thread.Sleep(30);
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(62, 23);
            Console.CursorVisible = false;
            Console.Clear();

            Menu menu = new Menu();
            int cursor = 0;
            menu.Draw(cursor);
            while(true)
            {
                ConsoleKeyInfo kek = Console.ReadKey();
                if (kek.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    menu.Draw(cursor);
                }
                if (kek.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    menu.Draw(cursor);
                }
                if (kek.Key == ConsoleKey.Enter)
                {
                    if (cursor % 4 == 0)
                    {
                        menu.Hello();
                        Console.Clear();
                        wall.Make(level);
                        fruit.Make(snake, wall);
                        level.Draw();
                        score.Draw();
                        break;
                    }
                    if (cursor % 4 == 1)
                    {
                        Console.Clear();
                        level = level.Deserialize();
                        score = score.Deserialize();
                        snake = snake.Deserialize();
                        wall = wall.Deserialize();
                        fruit = fruit.Deserialize();
                        level.Draw();
                        score.Draw();
                        snake.Draw();
                        wall.Draw();
                        fruit.Draw();
                        break;
                    }
                    if (cursor % 4 == 2)
                    {
                        Console.Clear();
                        menu.Score();
                        Console.ReadKey();
                        Console.Clear();
                        menu.Draw(cursor);
                    }
                    if (cursor % 4 == 3)
                    {
                        gameover = true;
                        break;
                    }
                }
            }
            
            Thread thread = new Thread(Threadgame);
            thread.Start();

            while (!gameover)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = 1;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = 2;
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = 3;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = 4;
                        break;
                    case ConsoleKey.S:
                        level.Serialize(level);
                        score.Serialize(score);
                        snake.Serialize(snake);
                        wall.Serialize(wall);
                        fruit.Serialize(fruit);
                        break;
                    case ConsoleKey.L:
                        thread.Abort();
                        Console.Clear();
                        level = level.Deserialize();
                        score = score.Deserialize();
                        snake = snake.Deserialize();
                        wall = wall.Deserialize();
                        fruit = fruit.Deserialize();
                        level.Draw();
                        score.Draw();
                        snake.Draw();
                        wall.Draw();
                        fruit.Draw();
                        thread = new Thread(Threadgame);
                        thread.Start();
                        break;
                }
                Thread.Sleep(30);
            }
        }
    }
}
