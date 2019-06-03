using System;

namespace S1M3F2019_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(1, 7));
            }
        }
    }
}
