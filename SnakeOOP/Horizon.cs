using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Horizon : Figure
    {
        

        public Horizon(int xLeft, int xRight, int y, char symb)
        {
            pointList = new List<Point>();

            for(int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, symb);
                pointList.Add(p);
            }

            // ###########

            //Point p1 = new Point(6, 6, '#');
            //Point p2 = new Point(7, 6, '#');
            //Point p3 = new Point(8, 6, '#');

            //pointList.Add(p1);
            //pointList.Add(p2);
            //pointList.Add(p3);

        }
    }
}
