using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());

            int luku2;
            Console.WriteLine("Anna luku");
            luku2 = int.Parse(Console.ReadLine());

            int luku3;
            Console.WriteLine("Anna luku");
            luku3 = int.Parse(Console.ReadLine());

            Console.WriteLine(("Summa ") + (luku1 + luku2 + luku3));
            Console.WriteLine(("Keskiarvo ") + (luku1 + luku2 + luku3) / 3);
        }
    }
}
