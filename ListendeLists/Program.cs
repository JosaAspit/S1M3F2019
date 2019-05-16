using System;
using System.Collections.Generic;

namespace ListendeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarationen og initialiseringen af et string array med plads til 5 elementer
            string[] myStringArray = new string[5];

            myStringArray[0] = "Hej";
            myStringArray[1] = "Det";
            myStringArray[2] = "Er";
            myStringArray[3] = "Onsdag";
            myStringArray[4] = "I dag";

            //deklaration og initialisering af en string list med plads til n antal elementer
            List<string> myStringList = new List<string>();

            myStringList.Add("Og");
            myStringList.Add("I");
            myStringList.Add("Morgen");
            myStringList.Add("Er");
            myStringList.Add("Det");
            myStringList.Add("Torsdag");

            //deklartion og initialisering at et dictionary

            Dictionary<string, string> myDict = new Dictionary<string, string>();

            myDict.Add("Frø", "firbenet dyr der siger kvæk på de mest ubelejlige tidspunkter");
            myDict.Add("Hejre", "Der er en hejrehvisker i frederiksberg have");
            myDict.Add("And", "quack quack motherfuckers");

            Console.WriteLine(myDict["And"]);

            foreach (var kvp in myDict)
            {
                Console.WriteLine(kvp.Value);
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
