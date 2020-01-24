using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointStruct;

namespace RectangleStruct
{
    public struct Rectangle
    {
        public Point topLeft;
        public Point bottomRight;

        public Point TopLeft {
            get { return topLeft; }
            set { }
        }

        public Point BottomRight
        {
            get { return bottomRight; }
            set { }
        }

        public bool IsPointInRectangle(Point taskas)
        {           
            if((taskas.KoordinateX < TopLeft.KoordinateX) || (taskas.KoordinateY < TopLeft.KoordinateY)
                || (taskas.KoordinateX > BottomRight.KoordinateX) || (taskas.KoordinateY > BottomRight.KoordinateY))
            {
                return false;
            }
            else
            {
                return true;
            }           
        }
    }
}
