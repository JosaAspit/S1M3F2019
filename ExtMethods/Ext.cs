using System;
using System.Collections.Generic;
using System.Text;

namespace ExtMethods
{
    public static class Ext
    {
        public static void P(this object root)
        {
            Console.WriteLine(root.ToString());
        }

        public static int Square(this int root)
        {
            return root * root;
        }
    }
}
