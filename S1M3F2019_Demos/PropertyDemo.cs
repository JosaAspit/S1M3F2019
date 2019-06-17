using System;
using System.Collections.Generic;
using System.Text;

namespace S1M3F2019_Demos
{
    public static class PropertyDemo
    {
        public static void Foo()
        {
            Ventilator v = new Ventilator("Den sejeste ventilator som alle de cool kids vil have fat i");

            v.DescProp = "Total skrald ventilator";

            Console.WriteLine(v.DescProp);
        }
    }

    public class Ventilator
    {
        private string descField;

        public Ventilator(string descParam)
        {
            DescProp = descParam;
        }

        public string DescProp
        {
            get {
                return descField;
            }
            set {
                if (value != descField)
                {
                    descField = value;
                }
            }
        }
    }
}
