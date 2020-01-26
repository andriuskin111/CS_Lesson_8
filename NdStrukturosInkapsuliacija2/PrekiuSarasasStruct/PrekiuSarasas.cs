using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrekeStruct;

namespace PrekiuSarasasStruct
{
    public struct PrekiuSarasas
    {
        private List<Preke> _prekiuSarasas;

        public PrekiuSarasas(List<Preke> prekiuSarasas)
        {
            _prekiuSarasas = prekiuSarasas;
        }

        public decimal SuskaiciuotiVisaPrekiuKaina(List<Preke> prekiuSarasas)
        {
            decimal kainaViso = 0;

            for (int i = 0; i < prekiuSarasas.Count; i++)
            {
                kainaViso += prekiuSarasas.ElementAt(i).KainaVieneto * prekiuSarasas.ElementAt(i).Kiekis;
            }
            return kainaViso;
        }
    }

    


}
