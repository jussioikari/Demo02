using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;
            //Kysy pisteitä
            Console.WriteLine("Give points");
            points = int.Parse(Console.ReadLine());
            if (points <= 1) Console.WriteLine("Koulunumero on 0");
            else if (points == 2 || points == 3) Console.WriteLine("Koulunumero on 1");
            else if (points == 4 || points == 5) Console.WriteLine("Koulunumero on 2");
            else if (points == 6 || points == 7) Console.WriteLine("Koulunumero on 3");
            else if (points == 8 || points == 9) Console.WriteLine("Koulunumero on 4");
            else if (points == 10 || points == 11 || points == 12) Console.WriteLine("Koulunumero on 5");
            else if (points >12) Console.WriteLine("Ei pisterajoissa");

        }
    }
}
