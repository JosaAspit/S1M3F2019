using System;

namespace ExtMethods
{
    class Cat
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            print("Dav");

            "Print Mig".P();
            1234.P();

            true.P();

            Cat c = new Cat();

            c.P();

            Console.ReadLine();
        }

        static void print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
