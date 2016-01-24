using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake 
{
    class Figure
    {
        protected List<Point> points;

        public void Drow()
        {
            foreach (Point p in points)
            {
                p.Drow();
            }
        }

        internal bool isHit(Figure figure)
        {
            foreach(var point in points)
            {
                if (figure.isHit(point)) return true;
            }
            return false;
        }

        private bool isHit(Point point)
        {
            foreach(var p in points)
            {
                if (p.isHit(point)) return true;
            }
            return false;
        }
    }
}
