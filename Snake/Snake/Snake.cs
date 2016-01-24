using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
           points = new List<Point>();
           direction = _direction;
           for(int _x = 0; _x < length; _x++)
            {
                Point p = new Point(tail);
                p.Move(_x, direction);
                points.Add(p);
            }
        }

        public void Move()
        {
            Point head = GetNextPoint();
            points.Add(head);
            Point tail = points.First();
            points.Remove(tail);

            head.Drow();
            tail.Clear();
        }

        public Point GetNextPoint()
        {
            Point newpoint = new Point(points.Last());
            newpoint.Move(1, direction);
            return newpoint;
        }

        public void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key.Key == ConsoleKey.UpArrow)
                direction = Direction.TOP;
            else if (key.Key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key.Key == ConsoleKey.DownArrow)
                direction = Direction.BOTTOM;
        }

        public bool Eat(Point eats_point)
        {
            Point next_point = GetNextPoint();
            if (next_point.isHit(eats_point))
            {
                eats_point.sym = next_point.sym;
                eats_point.Drow();
                points.Add(eats_point);
                return true;
            }
            else return false;

        }
    }
}
