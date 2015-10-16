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

            List<int> myList = new List<int>();
            myList.Add(12354);
            myList.Add(2);
            myList.Add(5);

            int x = myList[0];
            int y = myList[1];
            int z = myList[2];

            Console.WriteLine();


            foreach(int i in myList)
            {
                Console.WriteLine(i + " - Success");
            }

            List<Point> myPointList = new List<Point>();
            myPointList.Add(p1);
            myPointList.Add(p2);

            Console.ReadKey();
        }

    }
}
