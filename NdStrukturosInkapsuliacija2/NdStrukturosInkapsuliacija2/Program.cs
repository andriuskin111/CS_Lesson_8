using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrekeStruct;
using PrekiuSarasasStruct;

namespace NdStrukturosInkapsuliacija2
{
    class Program
    {
        static void Main(string[] args)
        {
            Preke preke = new Preke();
            PrekiuSarasas prekes;
            List<Preke> prekiuSarasas = new List<Preke>();

            prekiuSarasas.Add(new Preke("Alus", 24, 1.6m));
            prekiuSarasas.Add(new Preke("Degtine", 10, 8.2m));
            prekiuSarasas.Add(new Preke("Viskis", 20, 28.4m));
            prekiuSarasas.Add(new Preke("Prezervatyvai", 100, 3.84m));
            prekiuSarasas.Add(new Preke("Batonas", 16, 0.8m));

            for (int i = 0; i < prekiuSarasas.Count; i++)
            {
                Console.WriteLine($"Pavadinimas: {prekiuSarasas.ElementAt(i).PrekesPavadinimas}," +
                    $" Kiekis: {prekiuSarasas.ElementAt(i).Kiekis}," +
                    $" Vieneto kaina: {prekiuSarasas.ElementAt(i).KainaVieneto}");
            }

            Console.WriteLine($"Visu esamu prekiu kaina: {prekes.SuskaiciuotiVisaPrekiuKaina(prekiuSarasas)}");

            Console.ReadLine();
        }
    }
}
