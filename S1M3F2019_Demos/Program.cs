using System;

namespace S1M3F2019_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Array.Resize(ref arr, arr.Length + 1);

            Console.WriteLine(arr.Length);
            Console.ReadKey();
        }
    }
}
