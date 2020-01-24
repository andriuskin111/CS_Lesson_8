using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointStruct;
using RectangleStruct;

namespace NdSavarankiskasDarbasTrys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point point;            
            point.koordinateX = 10;
            point.koordinateY = 20;

            Rectangle rectangle = new Rectangle();
            rectangle.topLeft.koordinateX = 1;
            rectangle.topLeft.koordinateY = 8;
            rectangle.bottomRight.koordinateX = 20;
            rectangle.bottomRight.koordinateY = 40;

            Console.WriteLine($"Point is in Rectangle: {rectangle.IsPointInRectangle(point)}");

            Console.ReadLine();
        }

    }
}
