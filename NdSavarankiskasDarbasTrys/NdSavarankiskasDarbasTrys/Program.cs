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
            Point point = new Point(10, 20);            
            Point topLeft = new Point(1, 8);
            Point bootomRight = new Point(20, 40);
            Rectangle rectangle = new Rectangle(topLeft, bootomRight);

            Console.WriteLine($"Point is in Rectangle: {rectangle.IsPointInRectangle(point)}");

            Console.ReadLine();
        }

    }
}
