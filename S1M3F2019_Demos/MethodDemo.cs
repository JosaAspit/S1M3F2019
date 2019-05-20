using System;
using System.Collections.Generic;
using System.Text;

namespace S1M3F2019_Demos
{
    class MethodDemo
    {
        static void Mayn(string[] args)
        {
            Console.WriteLine(MyAdder(20, 5));

            Console.WriteLine(MultiplyMyName(5, "Jens-Ole"));

            Console.ReadLine();
        }
        //access modifier - keyword (optional) - returtype - method name - parameters - method body
        static int MyAdder(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        static string MultiplyMyName(int times, string name)
        {
            string n = "";

            for (int i = 0; i < times; i++)
            {
                n += name;
            }

            return n;
        }
    }
}
