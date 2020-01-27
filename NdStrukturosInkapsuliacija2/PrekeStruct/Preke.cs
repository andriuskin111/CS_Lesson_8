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
        private decimal _kainaVieneto;

        public Preke(string preke, int kiekis, decimal kainaVieneto)
        {
            _prekesPavadinimas = preke;
            _kiekis = kiekis;
            _kainaVieneto = kainaVieneto;
        }

        public string PrekesPavadinimas
        {
            get { return _prekesPavadinimas; }
            private set { }
        }

        public int Kiekis
        {
            get { return _kiekis; }
            set { Kiekis = value; }
        }

        public decimal KainaVieneto
        {
            get { return _kainaVieneto; }
            private set { }
        }
    }
}
