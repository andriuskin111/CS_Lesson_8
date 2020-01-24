using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiskasStruct;

namespace NdSavarankiskasDarbasKeturi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Miskas miskas;
            miskas.medziai = new List<int>();

            // tingisi po viena sodint, sodinam 10 iskarto
            for (int i = 0; i < 10; i++)
            {
                miskas.PasodintiMedi();
            }           

            Console.WriteLine(miskas.medziai.Count);

            Console.ReadLine();
        }
    }
}
