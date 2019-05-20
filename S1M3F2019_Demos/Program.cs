using System;

namespace S1M3F2019_Demos
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] input = new string[20];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = i.ToString();
            }

            Console.WriteLine(ConcatenateAll(input));

            Console.ReadKey();
        }

        public static string ConcatenateAll(string[] input)
        {
            return string.Join("ABC ", input);
        }
    }
}
