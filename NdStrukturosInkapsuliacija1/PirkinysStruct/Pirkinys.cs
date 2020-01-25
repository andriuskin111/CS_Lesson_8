﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PirkinysStruct;

namespace PirkinysStruct
{
    public struct Pirkinys
    {
        private string _prekesPavadinimas;
        private int _kiekis;
        private double _kainaVieneto;

        public Pirkinys(string prekesPavadinimas, int kiekis, double kainaVieneto)
        {
            _prekesPavadinimas = prekesPavadinimas;
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
            private set { }
        }

        public double KainaVieneto
        {
            get { return _kainaVieneto; }
            private set { }
        }

        public double KainaViso
        {
            get { return KainaVieneto * Kiekis; }
            private set { }
        }
    }
}
