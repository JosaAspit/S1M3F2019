using System;
using System.Collections.Generic;
using System.Text;

namespace S1M3F2019_Demos
{
    public static class ArrayDemos
    {
        public static void Foo()
        {
            //Datatype - variabelnavn = værdi
            //string vare = "Løg";

            //datatype - variabel = nyt array. Datatypen her værende string[] (string array)
            string[] varer = new string[5];

            //Arrays er begrænsede til deres deklarede antal pladser
            varer[0] = "Ristede løg";
            varer[1] = "Spegepølse";
            varer[2] = "Rugbrød";
            varer[3] = "Remoulade";
            varer[4] = "Karse";

            //den følgende linje giver mig en fejl
            //varer[5] = "Ost"
            Console.WriteLine();
            Console.WriteLine("med en for-løkke");
            for (int i = 0; i < varer.Length; i++)
            {
                Console.WriteLine(i + ". " +varer[i]);
            }

            Console.WriteLine();
            Console.WriteLine("med en foreach: ");
            foreach (string vare in varer)
            {
                Console.WriteLine(vare);
            }
        }
    }
}
