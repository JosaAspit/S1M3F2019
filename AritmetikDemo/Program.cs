using System;

namespace AritmetikDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, jeg er en lommeregner der kan ligge 2 tal sammen :)");
            Console.WriteLine();

            Console.Write("Skriv det første tal: ");
            int valueOne = int.Parse(Console.ReadLine());

            Console.Write("Skriv det andet tal: ");
            int valueTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultatet er: " + (valueOne + valueTwo));

            Console.ReadKey();
        }
    }
}
