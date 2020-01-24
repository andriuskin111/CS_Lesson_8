using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaskaitaStruct;

namespace NdSavarankiskasDarbasVienas
{
    class Program
    {
        static void Main(string[] args)
        {
            Saskaita saskaita;
            saskaita.gavejas = "UAB Kosmonautas";
            saskaita.siuntejas = "UAB LietKosmosas";
            saskaita.moketiViso = 1000.25;
            saskaita.saskaitosNumeris = 0;

            Console.WriteLine($"Nr:{saskaita.SaskaitosNumeris} Data:{DateTime.Now.ToShortDateString()}");

            saskaita.saskaitosNumeris = saskaita.SaskaitosNumeris;

            Console.WriteLine($"Nr:{saskaita.SaskaitosNumeris} Data:{DateTime.Now.ToShortDateString()}");

            Console.ReadLine();
        }
    }
}
