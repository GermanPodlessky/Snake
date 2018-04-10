using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.classes
{
    class Walls : Figure
    {
        private List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontLine upLine = new HorizontLine(0, mapWidth - 2, 0, '-');
            HorizontLine downLine = new HorizontLine(0, mapWidth - 2 , mapHeight - 1, '-');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '|');
            VerticalLine rigLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '|');
                
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rigLine);
        }

        //public bool EqualityCoordinates(Figure figure)
        //{
               
        //    foreach (var wall in wallList)
        //    {
        //        if (wall.EqualityCoordinates(figure))
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}
