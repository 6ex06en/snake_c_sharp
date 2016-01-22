using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Point p1 = new Point(1,3,'*');
            p1.Drow();

            Point p2 = new Point(4,5,'#');
            p2.Drow();

            HorizontalLine hor_line = new HorizontalLine(2, 6, 8, '%');
            hor_line.Drow();

            VerticalLine vert_line = new VerticalLine(20, 4, 10, '^');
            vert_line.Drow();

            Console.ReadLine();
        }
    }
}
