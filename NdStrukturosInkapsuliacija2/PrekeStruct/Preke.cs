using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekeStruct
{
    public struct Preke
    {
        private string _prekesPavadinimas;
        private int _kiekis;
        private double _kainaVieneto;

        public Preke(string preke, int kiekis, double kaina)
        {
            _prekesPavadinimas = preke;
            _kiekis = kiekis;
            _kainaVieneto = kaina;               
        }

        public string PrekesPavadinimas
        {
            get { return _prekesPavadinimas; }
            private set { }
        }

        public int Kiekis
        {
            get { return _kiekis; }
            private set { }
        }
    }
}
