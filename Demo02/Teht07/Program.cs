﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna vuosiluku");
            int vuosi;
            vuosi = int.Parse(Console.ReadLine());

            if (vuosi % 4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0)
            {
                Console.WriteLine("Karkausvuosi");

            }
            else
            {
                Console.WriteLine("Ei ole karkausvuosi");
            }
        }
    }
}
