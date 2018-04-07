using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.classes;

namespace Snake
{
    class HorizontLine : Figure
    {

          

        public HorizontLine(int xLeft, int xRight, int y, char symbl)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,symbl);
                pList.Add(p);
            }
        }


    }
}
