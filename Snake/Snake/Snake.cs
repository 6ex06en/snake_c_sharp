using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
           for(int _x = 0; _x < length; _x++)
            {
                Point p = new Point(tail);
                p.Move(_x, direction);
                points.Add(p);
            }
        }
    }
}
