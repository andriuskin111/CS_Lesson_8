using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaskaitaStruct
{
    public struct Saskaita
    {
        public string gavejas;
        public string siuntejas;
        public double moketiViso;
        public int saskaitosNumeris;

        public string Gavejas {
            get { return gavejas; }
            set { } 
        }

        public string Siuntejas {
            get { return siuntejas; } 
            set { } 
        }

        public double MoketiViso {
            get { return moketiViso; }
            set { } 
        }

        public int SaskaitosNumeris {
            get { return saskaitosNumeris + 1; }
            set { } 
        }

    }
}
