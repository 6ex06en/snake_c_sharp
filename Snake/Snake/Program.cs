﻿using System;
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

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Drow(p1.x, p1.y, p1.sym);

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#'; 

            Drow(p2.x, p2.y, p2.sym);

            Console.ReadLine();
        }

        static void Drow(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
