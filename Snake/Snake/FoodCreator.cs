﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapHeight;
        int mapWidth;
        char symbol;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char symbol)
        {
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.symbol = symbol;
        }

        public Point CreateFood()
        {
            int x = random.Next(3, mapWidth - 3);
            int y = random.Next(3, mapHeight - 3);
            return new Point(x, y, symbol);
        }
    }
}
