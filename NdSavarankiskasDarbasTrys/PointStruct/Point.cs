using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStruct
{
    public struct Point
    {
        private int _koordinateX;
        private int _koordinateY;

        public Point(int koordinateX, int koordinateY)
        {
            _koordinateX = koordinateX;
            _koordinateY = koordinateY;
        }
        public int KoordinateX {
            get {return _koordinateX; }
            private set { }
        }

        public int KoordinateY
        {
            get { return _koordinateY; }
            private set { }
        }
    }
}
