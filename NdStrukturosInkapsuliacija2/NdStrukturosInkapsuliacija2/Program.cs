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
            PrekiuSarasas prekes;
            List<Preke> prekiuSarasas = new List<Preke>();

            prekiuSarasas.Add(new Preke("Alus", 24, 1.6m));
            prekiuSarasas.Add(new Preke("Degtine", 10, 8.2m));
            prekiuSarasas.Add(new Preke("Viskis", 20, 28.4m));
            prekiuSarasas.Add(new Preke("Prezervatyvai", 100, 3.84m));
            prekiuSarasas.Add(new Preke("Batonas", 16, 0.8m));

            

            bool vartotojasNepasirinkoIseiti = true;

            while (vartotojasNepasirinkoIseiti)
            {
                int veiksmas = 0;
                bool ivestiDuomenysTeisingi = false;

                ParodytiPrekiuSarasa(prekiuSarasas, prekes);

                Console.WriteLine("Pasirinkite veiksma: [1]-Prideti preke, [2]-Parodyti visa sarasa," +
                    " [3]-Istrinti preke, [4]-Koreguoti kieki");

                while (ivestiDuomenysTeisingi == false)
                {
                    if(!int.TryParse(Console.ReadLine(), out veiksmas))
                    {
                        Console.WriteLine("Ivesti neteisingi duomenys, pakartokite");

                        ivestiDuomenysTeisingi = false;
                    }
                    else if(veiksmas < 0 || veiksmas> 4)
                    {
                        Console.WriteLine("Ivestas neteisingas skaicius, pakartokite");

                        ivestiDuomenysTeisingi = false;
                    }
                    else
                    {
                        ivestiDuomenysTeisingi = true;
                    }
                }

                ivestiDuomenysTeisingi = false;

                string ivedamosPrekesPavadinimas = "";
                int ivedamasPrekesKiekis = 0;
                decimal ivedamosPrekesKainaVieneto = 0;

                if(veiksmas == 1)
                {
                    Console.WriteLine("Iveskite ivedamos prekes pavadinima:");

                    ivedamosPrekesPavadinimas = Console.ReadLine();

                    Console.WriteLine("Iveskite ivedamos prekes kieki:");

                    while (ivestiDuomenysTeisingi == false)
                    {
                        if(!int.TryParse(Console.ReadLine(), out ivedamasPrekesKiekis))
                        {
                            Console.WriteLine("Ivesti neteisingi duomenys, pakartokite");

                            ivestiDuomenysTeisingi = false;
                        }
                        else if(ivedamasPrekesKiekis < 0)
                        {
                            Console.WriteLine("Prekiu kiekis negali buti neigiamas, pakartokite");

                            ivestiDuomenysTeisingi = false;
                        }
                        else
                        {
                            ivestiDuomenysTeisingi = true;
                        }
                    }

                    ivestiDuomenysTeisingi = false;

                    Console.WriteLine("Iveskite ivedamos prekes vieneto kaina:");

                    while (ivestiDuomenysTeisingi == false)
                    {
                        if(!decimal.TryParse(Console.ReadLine(), out ivedamosPrekesKainaVieneto))
                        {
                            Console.WriteLine("Ivesti neteisingi doumenys, pakartokite");

                            ivestiDuomenysTeisingi = false;
                        }
                        else if(ivedamosPrekesKainaVieneto < 0)
                        {
                            Console.WriteLine("Ivedamos prekes kaina negali buti neigiama, pakartokite");

                            ivestiDuomenysTeisingi = false;
                        }
                        else
                        {
                            ivestiDuomenysTeisingi = true;
                        }
                    }

                    prekiuSarasas.Add(new Preke(ivedamosPrekesPavadinimas, ivedamasPrekesKiekis, ivedamosPrekesKainaVieneto));
                }

            }

            Environment.Exit(0);
        }

        public static void ParodytiPrekiuSarasa(List<Preke> prekiuSarasas, PrekiuSarasas prekes)
        {
            Console.WriteLine("Prekiu sarasas:");

            for (int i = 0; i < prekiuSarasas.Count; i++)
            {
                Console.WriteLine($"Pavadinimas: {prekiuSarasas.ElementAt(i).PrekesPavadinimas}," +
                    $" Kiekis: {prekiuSarasas.ElementAt(i).Kiekis}," +
                    $" Vieneto kaina: {prekiuSarasas.ElementAt(i).KainaVieneto}");
            }

            Console.WriteLine($"Visu esamu prekiu kaina: {prekes.SuskaiciuotiVisaPrekiuKaina(prekiuSarasas)}");

        }
    }
}
