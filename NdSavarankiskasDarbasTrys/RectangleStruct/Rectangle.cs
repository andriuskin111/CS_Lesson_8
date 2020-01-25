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
        private Point _topLeft;
        private Point _bottomRight;

        public Rectangle(Point topLeft, Point bootomRight)
        {
            _topLeft = topLeft;
            _bottomRight = bootomRight;
        }
        public Point TopLeft {
            get { return _topLeft; }
            private set { }
        }

        public Point BottomRight
        {
            get { return _bottomRight; }
            private set { }
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
