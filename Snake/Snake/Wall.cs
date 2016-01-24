using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        List<Figure> figurelist;

        public Wall(int maxWeight, int maxHeight, char sym)
        {
            figurelist = new List<Figure>();
            HorizontalLine topWall = new HorizontalLine(0, maxWeight - 2, 0, sym);
            HorizontalLine downWall = new HorizontalLine(0, maxWeight - 2, maxHeight - 1, sym);
            VerticalLine leftWall = new VerticalLine(0, maxHeight - 1, 0, sym);
            VerticalLine rightWall = new VerticalLine(0, maxHeight - 1, maxWeight - 2, sym);

            figurelist.Add(topWall);
            figurelist.Add(downWall);
            figurelist.Add(leftWall);
            figurelist.Add(rightWall);

        }

        public void Drow()
        {
            foreach(Figure figure in figurelist)
            {
                figure.Drow();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in figurelist)
            {
                if (wall.isHit(figure)) return true;
            }
            return false;
        }
    }
}
