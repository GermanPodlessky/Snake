using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.classes
{
    class Food
    {
        int xMax;
        int yMax;
        char symbl;

        Random random = new Random();

        public Food(int _xMax, int _yMax, char _symbl)
        {
            xMax = _xMax;
            yMax = _yMax;
            symbl = _symbl;
        }

        
        public Point CreateFood()
        {
            int x = random.Next(2, xMax - 2);
            int y = random.Next(2, yMax - 2);
            return new Point(x, y, symbl);
        }
    }
}
