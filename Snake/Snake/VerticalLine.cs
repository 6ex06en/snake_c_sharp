using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> points = new List<Point>();

        public VerticalLine(int _bottomY, int _topY, int _x, char _sym)
        {
            for(int y = _bottomY; y >= _topY; y--)
            {
                points.Add(new Point(_x, y, _sym));
            }
        }
        public void Drow()
        {
            foreach(Point p in points)
            {
                p.Drow();
            }
        }
    }
}
