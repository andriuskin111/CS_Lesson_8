using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalmeStruct;

namespace NdSavarankiskasDarbasDu
{
    public class Program
    {
        static void Main(string[] args)
        {
            Palme palme;
            palme.amzius = 8;
            palme.vaisiuKiekis = 0;

            palme.PridetiVienaMenesiAmziaus();

            Console.WriteLine($"Vaisiu kiekis yra: {palme.VaisiuKiekis}");

            Console.ReadLine();
        }
    }
}
