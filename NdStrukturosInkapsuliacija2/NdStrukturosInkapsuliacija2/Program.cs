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
            int veiksmas;
            int prekesNumeris;
            int prekesKiekis;
            int meniuPirmas = 1;
            int meniuNumeris = 2;
            int meniuKiekis = 3;

            while (vartotojasNepasirinkoIseiti)
            {                
                Console.WriteLine("Pasirinkite veiksma: [1]-Prideti preke, [2]-Parodyti visa sarasa," +
                    " [3]-Istrinti preke, [4]-Koreguoti kieki");

                veiksmas = GrazintiIvestusIntegerDuomenis(meniuPirmas);

                int ivedamasPrekesKiekis;
                decimal ivedamosPrekesKainaVieneto;

                if (veiksmas == 1)
                {
                    Console.WriteLine("Iveskite ivedamos prekes pavadinima:");

                    string ivedamosPrekesPavadinimas = Console.ReadLine();

                    Console.WriteLine("Iveskite ivedamos prekes kieki:");

                    ivedamasPrekesKiekis = GrazintiIvestusIntegerDuomenis(meniuKiekis);

                    Console.WriteLine("Iveskite ivedamos prekes vieneto kaina:");

                    ivedamosPrekesKainaVieneto = GrazintiIvestusDecimalDuomenis();

                    prekiuSarasas.Add(new Preke(ivedamosPrekesPavadinimas, ivedamasPrekesKiekis, ivedamosPrekesKainaVieneto));

                    ParodytiPrekiuSarasa(prekiuSarasas, prekes);
                    vartotojasNepasirinkoIseiti =  PasirinktiArIseitiIsProgramosArTesti();
                }
                else if (veiksmas == 2)
                {
                    ParodytiPrekiuSarasa(prekiuSarasas, prekes);
                    vartotojasNepasirinkoIseiti =  PasirinktiArIseitiIsProgramosArTesti();
                }
                else if (veiksmas == 3)
                {
                    ParodytiPrekiuSarasa(prekiuSarasas, prekes);

                    Console.WriteLine("Iveskite norimos istrinti prekes numeri:");

                    prekesNumeris = GrazintiIvestusIntegerDuomenis(meniuNumeris);

                    Console.WriteLine($"Preke Nr: {prekesNumeris} {prekiuSarasas.ElementAt(prekesNumeris - 1).PrekesPavadinimas} istrinta");

                    prekiuSarasas.Remove(prekiuSarasas.ElementAt(prekesNumeris - 1));
                    ParodytiPrekiuSarasa(prekiuSarasas, prekes);
                    vartotojasNepasirinkoIseiti = PasirinktiArIseitiIsProgramosArTesti();

                }
                else if (veiksmas == 4)
                {
                    ParodytiPrekiuSarasa(prekiuSarasas, prekes);

                    Console.WriteLine("Iveskite norimos koreguoti prekes numeri");

                    prekesNumeris = GrazintiIvestusIntegerDuomenis(meniuNumeris);

                    Console.WriteLine("Iveskite koreguojamos prekes nauja kieki");

                    prekesKiekis = GrazintiIvestusIntegerDuomenis(meniuKiekis);

                    string pasirinktosPrekePavadinimas = prekiuSarasas.ElementAt(prekesNumeris - 1).PrekesPavadinimas.ToString();
                    decimal pasirinktosPrekesKainaVieneto = prekiuSarasas.ElementAt(prekesNumeris - 1).KainaVieneto;

                    prekiuSarasas[prekesNumeris - 1] = new Preke(pasirinktosPrekePavadinimas, prekesKiekis, pasirinktosPrekesKainaVieneto);

                    Console.WriteLine($"Prekes Nr: {prekesNumeris} {prekiuSarasas.ElementAt(prekesNumeris - 1).PrekesPavadinimas} kiekis pakeistas");

                    ParodytiPrekiuSarasa(prekiuSarasas, prekes);

                }
                else
                {
                    Console.WriteLine("Nezinoma klaida, skambinkite 112 :)");
                }

            }

            Environment.Exit(0);
        }

        public static decimal GrazintiIvestusDecimalDuomenis()
        {
            bool ivestiDuomenysTeisingi = false;
            decimal ivestiDuomenys = 0;

            while (ivestiDuomenysTeisingi == false)
            {
                if (!decimal.TryParse(Console.ReadLine(), out ivestiDuomenys))
                {
                    Console.WriteLine("Ivesti neteisingi doumenys, pakartokite");

                    ivestiDuomenysTeisingi = false;
                }
                else if (ivestiDuomenys < 0)
                {
                    Console.WriteLine("Ivedamos prekes kaina negali buti neigiama, pakartokite");

                    ivestiDuomenysTeisingi = false;
                }
                else
                {
                    ivestiDuomenysTeisingi = true;
                }
            }

            return ivestiDuomenys;
        }

        public static int GrazintiIvestusIntegerDuomenis(int meniu)
        {
            bool ivestiDuomenysTeisingi = false;
            int ivestiDuomenys = 0;

            while (ivestiDuomenysTeisingi == false)
            {
                if (!int.TryParse(Console.ReadLine(), out ivestiDuomenys))
                {
                    Console.WriteLine("Ivesti neteisingi duomenys, pakartokite");

                    ivestiDuomenysTeisingi = false;
                }
                else if (meniu == 1)
                {
                    if (ivestiDuomenys < 1 || ivestiDuomenys > 4)
                    {
                        Console.WriteLine("Ivestas neteisingas skaicius, pakartokite");

                        ivestiDuomenysTeisingi = false;
                    }
                    else
                    {
                        ivestiDuomenysTeisingi = true;
                    }
                }
                else if (meniu == 2)
                {
                    if (ivestiDuomenys < 1)
                    {
                        Console.WriteLine("Prekes numeris negali buti mazesnis uz 1, pakartokite");

                        ivestiDuomenysTeisingi = false;
                    }
                    else
                    {
                        ivestiDuomenysTeisingi = true;
                    }
                }
                else if (meniu == 3)
                {
                    if (ivestiDuomenys < 0)
                    {
                        Console.WriteLine("Prekiu kiekis negali buti neigiamas, pakartokite");

                        ivestiDuomenysTeisingi = false;
                    }
                    else
                    {
                        ivestiDuomenysTeisingi = true;
                    }                   
                }
                else
                {
                    ivestiDuomenysTeisingi = true;
                }
            }

            return ivestiDuomenys;
        }

        public static bool PasirinktiArIseitiIsProgramosArTesti()
        {
            bool ivestiDuomenysTeisingi = false;
            bool iseitiIsProgramos;
            int veiksmas = 0;

            Console.WriteLine("Pasirinkite veiksma: [1]-Testi darba, [2]-Iseiti is programos");

            while (ivestiDuomenysTeisingi == false)
            {
                if (!int.TryParse(Console.ReadLine(), out veiksmas))
                {
                    Console.WriteLine("Ivesti neteisingi duomenys, pakartokite");

                    ivestiDuomenysTeisingi = false;
                }
                else if (veiksmas < 1 || veiksmas > 2)
                {
                    Console.WriteLine("Ivestas neteisingas skaicius, pakartokite");

                    ivestiDuomenysTeisingi = false;
                }
                else
                {
                    ivestiDuomenysTeisingi = true;
                }
            }

            if (veiksmas == 1)
            {
                iseitiIsProgramos = true;
            }
            else
            {
                iseitiIsProgramos = false;
            }

            return iseitiIsProgramos;
        }
        public static void ParodytiPrekiuSarasa(List<Preke> prekiuSarasas, PrekiuSarasas prekes)
        {
            Console.WriteLine("Prekiu sarasas:");

            for (int i = 0; i < prekiuSarasas.Count; i++)
            {
                Console.WriteLine($"Nr: {i +1}, Pavadinimas: {prekiuSarasas.ElementAt(i).PrekesPavadinimas}," +
                    $" Kiekis: {prekiuSarasas.ElementAt(i).Kiekis}," +
                    $" Vieneto kaina: {prekiuSarasas.ElementAt(i).KainaVieneto}");
            }

            Console.WriteLine($"Visu esamu prekiu kaina: {prekes.SuskaiciuotiVisaPrekiuKaina(prekiuSarasas)}\n");

        }
    }
}
