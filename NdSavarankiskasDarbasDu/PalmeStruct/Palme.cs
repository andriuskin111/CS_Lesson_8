using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmeStruct
{
    public struct Palme
    {
        public int amzius;
        public int vaisiuKiekis;

        public int Amzius {
            get { return amzius; }
            set { }
        }

        public int VaisiuKiekis
        {
            get { return vaisiuKiekis; }
            set { }
        }

        public void PridetiVienaMenesiAmziaus()
        {
            if ((Amzius + 1) > 5 && (Amzius + 1) < 12)
            {
                vaisiuKiekis =  (Amzius + 1 - 5) * 3;
            }
            else
            {
                vaisiuKiekis = 0;
            }

        }
    }
}
