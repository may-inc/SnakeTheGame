using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTheGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            HorizontalLine horLine = new HorizontalLine (15, 25, 20, '#');
            horLine.HorDraw();

            VerticalLine verLine = new VerticalLine(6, 13, 11, '*');
            verLine.VerDraw();

            Console.ReadKey();
        }

    }
}
