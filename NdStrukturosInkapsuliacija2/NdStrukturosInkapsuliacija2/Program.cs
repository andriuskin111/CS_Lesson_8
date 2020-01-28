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
        private static int operacijosTipasMeniu = 1;
        private static int operacijosTipasPrekesNumeris = 2;
        private static int operacijosTipasPrekesKiekis = 3;

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
            
            int ivedamasPrekesKiekis;
            decimal ivedamosPrekesKainaVieneto;

            while (vartotojasNepasirinkoIseiti)
            {                
                Console.WriteLine("Pasirinkite veiksma: [1]-Prideti preke, [2]-Parodyti visa sarasa," +
                    " [3]-Istrinti preke, [4]-Koreguoti kieki");

                veiksmas = ApdorotiVartotojoIvesti(operacijosTipasMeniu);
                
                if (veiksmas == 1)
                {
                    Console.WriteLine("Iveskite ivedamos prekes pavadinima:");

                    string ivedamosPrekesPavadinimas = Console.ReadLine();

                    Console.WriteLine("Iveskite ivedamos prekes kieki:");

                    ivedamasPrekesKiekis = ApdorotiVartotojoIvesti(operacijosTipasPrekesKiekis);

                    Console.WriteLine("Iveskite ivedamos prekes vieneto kaina:");

                    ivedamosPrekesKainaVieneto = ApdorotiVartotojoIvesti();

                    prekiuSarasas.Add(new Preke(ivedamosPrekesPavadinimas, ivedamasPrekesKiekis, ivedamosPrekesKainaVieneto));

                    Console.WriteLine("Preke prideta");

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

                    prekesNumeris = ApdorotiVartotojoIvesti(operacijosTipasPrekesNumeris);

                    Console.WriteLine($"Preke Nr: {prekesNumeris} {prekiuSarasas.ElementAt(prekesNumeris - 1).PrekesPavadinimas} istrinta");

                    prekiuSarasas.Remove(prekiuSarasas.ElementAt(prekesNumeris - 1));
                    ParodytiPrekiuSarasa(prekiuSarasas, prekes);
                    vartotojasNepasirinkoIseiti = PasirinktiArIseitiIsProgramosArTesti();

                }
                else if (veiksmas == 4)
                {
                    ParodytiPrekiuSarasa(prekiuSarasas, prekes);

                    Console.WriteLine("Iveskite norimos koreguoti prekes numeri");

                    prekesNumeris = ApdorotiVartotojoIvesti(operacijosTipasPrekesNumeris);

                    Console.WriteLine($"Iveskite prekes {prekiuSarasas.ElementAt(prekesNumeris - 1).PrekesPavadinimas} nauja kieki");

                    prekesKiekis = ApdorotiVartotojoIvesti(operacijosTipasPrekesKiekis);

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

        public static decimal ApdorotiVartotojoIvesti()
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

        public static int ApdorotiVartotojoIvesti(int operacijosTipas)
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
                else if (operacijosTipas == operacijosTipasMeniu)
                {
                   ivestiDuomenysTeisingi =  PatikrintiArIvestiSkaiciaiNustatytoseRibose(ivestiDuomenys);
                }
                else if (operacijosTipas == operacijosTipasPrekesNumeris)
                {
                    ivestiDuomenysTeisingi = PatikrintiArIvestiSkaiciaiDaugiauUzNuli(ivestiDuomenys);
                }
                else if (operacijosTipas == operacijosTipasPrekesKiekis)
                {
                    ivestiDuomenysTeisingi = PatikrintiArIvestasSkaiciusNeraNeigiamas(ivestiDuomenys);              
                }
                else
                {
                    ivestiDuomenysTeisingi = true;
                }
            }

            return ivestiDuomenys;
        }

        public static bool PatikrintiArIvestiSkaiciaiNustatytoseRibose(int ivestiDuomenys)
        {
            bool ivestiDuomenysTeisingi;

            if (ivestiDuomenys < 1 || ivestiDuomenys > 4)
            {
                Console.WriteLine("Ivestas neteisingas skaicius, pakartokite");

                ivestiDuomenysTeisingi = false;
            }
            else
            {
                ivestiDuomenysTeisingi = true;
            }

            return ivestiDuomenysTeisingi;
        }

        public static bool PatikrintiArIvestiSkaiciaiDaugiauUzNuli(int ivestiDuomenys)
        {
            bool ivestiDuomenysTeisingi;

            if (ivestiDuomenys < 1)
            {
                Console.WriteLine("Prekes numeris negali buti mazesnis uz 1, pakartokite");

                ivestiDuomenysTeisingi = false;
            }
            else
            {
                ivestiDuomenysTeisingi = true;
            }

            return ivestiDuomenysTeisingi;
        }

        public static bool PatikrintiArIvestasSkaiciusNeraNeigiamas(int ivestiDuomenys)
        {
            bool ivestiDuomenysTeisingi;

            if (ivestiDuomenys < 0)
            {
                Console.WriteLine("Prekiu kiekis negali buti neigiamas, pakartokite");

                ivestiDuomenysTeisingi = false;
            }
            else
            {
                ivestiDuomenysTeisingi = true;
            }

            return ivestiDuomenysTeisingi;
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
