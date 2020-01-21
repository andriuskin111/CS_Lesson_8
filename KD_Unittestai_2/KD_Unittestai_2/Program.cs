using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_Unittestai_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mokinys mokinys = new Mokinys();
            mokinys.trimestras1 = new List<int>();
            mokinys.trimestras2 = new List<int>();
            mokinys.trimestras3 = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                mokinys.trimestras1.Add(rnd.Next(1, 5));
                mokinys.trimestras2.Add(rnd.Next(1, 5));
                mokinys.trimestras3.Add(rnd.Next(1, 5));
            }

            Console.WriteLine($"Pirmo trimestro vidurkis: {mokinys.IsvestiPirmoTrimestroVidurki()}");

            Console.ReadLine();
        }
    }
}
