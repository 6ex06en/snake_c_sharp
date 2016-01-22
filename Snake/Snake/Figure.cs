using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake 
{
    class Figure
    {
        protected List<Point> points = new List<Point>();

        public void Drow()
        {
            foreach (Point p in points)
            {
                p.Drow();
            }
        }
    }
}
