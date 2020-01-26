using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PirkinysStruct;

namespace NdStrukturosInkapsuliacija1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirkinys pirkinys1 = new Pirkinys("Alus", 5, 1.5m);

            Console.WriteLine($"Preke: {pirkinys1.PrekesPavadinimas}, Kiekis: {pirkinys1.Kiekis}, KainaViso: {pirkinys1.KainaViso}");

            Console.ReadLine();
        }
    }
}
