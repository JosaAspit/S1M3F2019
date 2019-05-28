using System;
using System.Collections.Generic;
using System.Text;

namespace S1M3F2019_Demos
{
    public static class LoopDemo
    {
        public static void Loop()
        {
            Console.WriteLine("Demo of fancy for loops");
            int padding = 5;
            int length = 10;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if ((i+j > length) && (i-j > 0))
                    {
                        Console.Write($"{i},{j}".PadRight(padding));
                    }
                    else
                    {
                        Console.Write(" ".PadRight(padding));
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Skriver den lille tabel ud: ");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((j * i).ToString().PadRight(3));
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Demo of while loops");
            string myString = "";
            while (!TryGetString(Console.ReadLine(), out myString))
            {
                Console.WriteLine("Du skrev en ugyldig streng");
            }

            Console.WriteLine("Dit input var: " + myString);
        }

        private static bool TryGetString(string input, out string output)
        {
            if (string.IsNullOrEmpty(input))
            {
                output = "";
                return false;
            }
            else
            {
                output = input;
                return true;
            }
        }
    }
}
