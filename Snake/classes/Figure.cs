using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.classes
{
    class Figure
    {
        protected  List<Point> pList;

        public void Draw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }

        public bool EqualityCoordinates(Figure figure)
        {
            foreach (var point in pList)
            {
                if (figure.EqualityCoordinates(point))
                    return true;
            }

            return false;
        }

        private bool EqualityCoordinates(Point point)
        {
            foreach (var p in pList)
            {
                if (p.EqualityCoordinates(point))
                    return true;
            }

            return false;
        }
    }
}
