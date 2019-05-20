using System;

namespace OOP_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer c1 = new Computer(15000, "dell","black","tgfd43tds");
            Computer c2 = new Computer(9001, "apple", "grey", "df2feafda3");

            //c1.color = "grey";
            //c1.manufacturer = "Dell";
            //c1.price = 15000.50;
            //c1.serialNumber = "23fdsf432ho";

            //c2.color = "black";
            //c2.manufacturer = "apple";
            //c2.price = 9001;
            //c2.serialNumber = "fgh43jv90az";

            c1.WriteInfo();
            c1.GoOnSale();
            c1.WriteInfo();
            c2.WriteInfo();

            Console.ReadKey();
        }
    }
}
