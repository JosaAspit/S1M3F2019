using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesAndStuff
{
    class Program
    {

        static void Main(string[] args)
        {
            int vægt = int.Parse(Console.ReadLine());
            double pris = 0;
            if (vægt < 10)
            {
                pris = 10;
            } else if (vægt < 20)
            {
                pris = 20;
            } else
            {
                pris = 30;
            }

            Console.WriteLine("skal den være ekspres");
            if (Console.ReadLine().ToLower() == "ja")
            {
                pris = pris * 1.5;
            }

            Console.WriteLine("Prisen er: " + pris);
        }
    }
}
