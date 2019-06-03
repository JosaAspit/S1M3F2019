using System;
using System.Collections.Generic;
using System.Text;

namespace S1M3F2019_Demos
{
    public static class LoopDemo
    {
        public static void Loop()
        {
            for (int j = 1; j <= 25; j++)
            {
                for (int i = 1; i <= 50; i++)
                {
                    if (j + i > 25)
                    {
                        Console.Write("#");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Demo of fancy for loops");
            int padding = 2;
            int width = 7;
            int height = 4;
            int count = 1;
            for (int j = 1; j <= height; j++)
            {
                for (int i = 1; i <= width; i++)
                {
                    var round = Math.Round((decimal)width / 2);

                    if (
                        j + i > round 
                        &&
                        width + j-1 >= (width/2)+i
                        && 
                        (i+j) % 2 == 1
                        )
                    {
                        Console.Write($"{count}".PadRight(padding));
                        count++;
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
