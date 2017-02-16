using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna km");
            double km;
            km = double.Parse(Console.ReadLine());

            double bensa = km * 0.0702;
            double raha = bensa * 1.595;
            Console.WriteLine("Bensaa kuluu " + bensa + " litraa, " + "kustannus " + raha + " euroa" );
        }
    }
}
