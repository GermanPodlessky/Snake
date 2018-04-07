using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbl;

        public Point(int x, int y, char symbl)
        {
            this.x = x;
            this.y = y;
            this.symbl = symbl;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(symbl);
        }
    }
}