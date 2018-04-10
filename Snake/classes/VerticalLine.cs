using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.classes;

namespace Snake
{
    class VerticalLine : Figure
    {

        public VerticalLine(int yUp, int yDown, int x, char symbl)
        {
            pList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbl);
            }
        }


    }
}
