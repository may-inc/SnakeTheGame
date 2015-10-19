﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTheGame
{
    class VerticalLine : Figure
    {
        public VerticalLine (int yLeft, int yRight, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
               Point v = new Point(x, y, sym);
                pList.Add(v);
            }
        }        
    }
}
