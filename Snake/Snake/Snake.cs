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
            Point head = GetNextPoint(points.Last());
            points.Add(head);
            Point tail = points.First();
            points.Remove(tail);

            head.Drow();
            tail.Clear();
        }

        public Point GetNextPoint(Point p)
        {
            p.Move(1, direction);
            return p;
        }
    }
}
