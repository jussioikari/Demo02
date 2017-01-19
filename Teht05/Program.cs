using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna sekunnit: ");
            int num;
            num = int.Parse(Console.ReadLine());

            int hour = num / 3600;
            int min = num / 60 - hour * 60;
            int sec = num % 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: \n" + hour + "h " + min + "min " + sec + "sec");          
        }
    }
}
