using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    public static class Ext
    {
        public static void KillAnimal(this Animal root)
        {
            Console.WriteLine($"The {root.Race} is dead");
        }
    }
}
