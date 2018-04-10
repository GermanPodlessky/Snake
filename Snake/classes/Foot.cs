using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.classes
{
    class Foot
    {
        private int xMax;
        private int yMax;
        private char symbl;

        public Foot(int _xMax, int _yMax, char _symbl)
        {
            xMax = _xMax;
            yMax = _yMax;
            symbl = _symbl;
        }
        
        Random random = new Random();

        public Point CreateFoot()
        {
            int x = random.Next(2, xMax - 2);
            int y = random.Next(2, yMax - 2);
            return new Point(x,y,symbl);
        }
    }
}
