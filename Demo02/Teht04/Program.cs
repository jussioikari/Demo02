using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Anna ikasi");
            age = int.Parse(Console.ReadLine()); //"37" 37 Lukee numeron

            if (age < 18) Console.WriteLine("Alaikainen");
            else if (age >= 18 && age <= 65) Console.WriteLine("Aikuinen");
            else if (age > 65) Console.WriteLine("Seniori");

        }
    }
}
