using System;
using System.Collections.Generic;
using System.IO;

namespace Boxdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = BoxToolBox.GetBoxes();

            Console.WriteLine("The largest box volume is: ");
            Console.WriteLine(BoxToolBox.FindLargestBoxByVolume(boxes).GetVolume());

            Console.ReadKey();
        }

    }
}
