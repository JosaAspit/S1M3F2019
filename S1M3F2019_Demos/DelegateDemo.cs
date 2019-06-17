using System;
using System.Collections.Generic;
using System.Text;

namespace S1M3F2019_Demos
{
    public class DelegateDemo
    {

        public static void Foo()
        {
            Console.WriteLine("Mit program til at give kvadrater af et tal: ");

            Console.WriteLine(Square(5));
            Console.WriteLine(Square(10));
        }

        private static int Square(int num) => num * num;
    }
}
