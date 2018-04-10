using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            symbl = point.symbl;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    y -= offset;
                    break;

                case Direction.RIGHT:
                    x += offset;
                    break;

                case Direction.DOWN:
                    y += offset;
                    break;

                case Direction.LEFT:
                    x -= offset;
                    break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x < 1 ? x = 97 : x > 97 ? x = 1 : x, y < 1 ? y = 28 : y > 28 ? y = 2 : y );
            Console.Write(symbl);
        }

        public bool EqualityCoordinates(Point point)
        {
            return point.x == this.x && point.y == this.y;
        }

        public void Delete()
        {
            symbl = ' ';
            Draw();
        }
    }
}