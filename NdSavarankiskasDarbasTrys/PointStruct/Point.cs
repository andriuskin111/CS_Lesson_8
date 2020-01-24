using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStruct
{
    public struct Point
    {
        public int koordinateX;
        public int koordinateY;

        public int KoordinateX {
            get {return koordinateX; }
            set { }
        }

        public int KoordinateY
        {
            get { return koordinateY; }
            set { }
        }
    }
}
