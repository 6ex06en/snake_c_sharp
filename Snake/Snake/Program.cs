using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            VerticalLine vert_line_left = new VerticalLine(24, 0, 79, '%');
            vert_line_left.Drow();

            VerticalLine vert_line_right = new VerticalLine(24, 0, 0, '%');
            vert_line_right.Drow();

            HorizontalLine hor_line_bottom = new HorizontalLine(0, 78, 24, '%');
            hor_line_bottom.Drow();

            HorizontalLine hor_line_top = new HorizontalLine(0, 78, 0, '%');
            hor_line_top.Drow();

            Point start = new Point(15, 5, '*');
            Snake snake = new Snake(start, 8, Direction.RIGHT);
            snake.Drow();

            FoodCreator createfood = new FoodCreator(80, 25, '$');
            Point food = createfood.CreateFood();
            food.Drow();

            while(true)
            {
                if(snake.Eat(food))
                {
                    food = createfood.CreateFood();
                    food.Drow();
                }
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
