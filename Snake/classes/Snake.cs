using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        Direction direction;

        public Snake(Point tail,int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i <= length; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                pList.Add(point);
            }
        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = NextPoint();
            pList.Add(head);

            tail.Delete();
            head.Draw();

        }

        public Point NextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void Motion(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;

                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;

                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;

                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
            }
        }
            
        public bool Eat(Point food)
        {
            Point head = NextPoint();

            if (head.EqualityCoordinates(food))
            {
                food.symbl = head.symbl;
                food.Draw();
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EqualityCoordinatesTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.EqualityCoordinates(pList[i]))
                    return true;
            }

            return false;
        }
    }
}
