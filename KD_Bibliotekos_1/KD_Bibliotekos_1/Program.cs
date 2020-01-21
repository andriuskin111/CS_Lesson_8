using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStruct;

namespace KD_Bibliotekos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book knyga;
            knyga.Name = "Knyga";
            knyga.Id = "1234";

            

            Console.WriteLine(knyga.LocalId);

            Console.ReadLine();
        }
    }
}
