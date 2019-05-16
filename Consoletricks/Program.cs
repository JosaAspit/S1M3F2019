using System;

namespace Consoletricks
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Skriv et tal");

                int input = 0;

                while(!int.TryParse(Console.ReadLine(),out input))
                {
                    Console.WriteLine("Skriv et tal!!!");
                }

                Console.WriteLine("du skrev tallet: " + input);

                Console.ReadKey();

                Console.Clear();
            }
        }
    }
}
