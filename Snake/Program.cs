using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize( 100, 25);
            Console.SetBufferSize( 100, 25);
            HorizontLine upLine = new HorizontLine(0, 98, 0, '+');
            HorizontLine downLine = new HorizontLine(0, 98, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rigLine = new VerticalLine(0, 24, 98, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rigLine.Draw();
            Point p = new Point(2,2,'3');
            p.Draw();
            Console.Read();
            

        }
       
    }
}