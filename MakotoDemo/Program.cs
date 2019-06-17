using System;

namespace MakotoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv et tal:");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv et tal mere");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultatet af de to tal lagt sammen er: ");
            Console.WriteLine(input1+input2);

            Console.ReadKey();
        }
    }
}
