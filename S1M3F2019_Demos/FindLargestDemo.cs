using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S1M3F2019_Demos
{
    public static class FindLargestDemo
    {
        public static int FindLargest(int[] input)
        {
            int largest = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > largest)
                {
                    largest = input[i];
                }
            }

            return largest;

            return input.Aggregate((x1, x2) => x1 > x2 ? x1 : x2);
        }
    }
}
