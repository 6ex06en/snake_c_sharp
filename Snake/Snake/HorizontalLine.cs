using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {     
        public HorizontalLine(int _leftX, int _rightX, int _y, char _sym)
        {
            points = new List<Point>();

            for (int x = _leftX; x <= _rightX; x++)
            {
                points.Add(new Point(x, _y, _sym));
            }
        }
    }
}
