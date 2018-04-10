using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Snake.classes;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {   
            const int X = 100;
            const int Y = 30;
            Console.SetWindowSize(X, Y);
            Console.SetBufferSize(X, Y);
            Console.CursorVisible = false;

            new Walls(X, Y);
            
           
            Point point = new Point(5,4,'*');
            Snake snake = new Snake( point, 2, Direction.RIGHT);
            snake.Draw();

            Console.ForegroundColor = ConsoleColor.Red;
            Food foodCreate = new Food(80,25, '@');
            Point food = foodCreate.CreateFood();
            food.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {
                if ( snake.EqualityCoordinatesTail())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(X / 2 - 5, Y / 2);
                    Console.WriteLine("Game over!!");
                    Console.SetCursorPosition(X / 2 - 10, Y / 2 + 1);
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;
                }

                if (snake.Eat(food))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    food = foodCreate.CreateFood();
                    food.Draw();
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey();
                    snake.Motion(key.Key);
                }
            }
        }
       
    }
}