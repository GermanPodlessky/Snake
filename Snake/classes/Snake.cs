using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.classes;

namespace Snake
{
    enum Direction
    {
        UP,
        RIGHT,
        DOWN,
        LEFT
    }
    class Snake : Figure
    {
        public Snake(Point tail,int length, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i <= length; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                pList.Add(point);
            }
        }
    }
}
