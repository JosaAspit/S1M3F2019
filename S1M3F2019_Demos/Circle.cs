using System;
using System.Collections.Generic;
using System.Text;

namespace S1M3F2019_Demos
{
    class Circle
    {
        private readonly double radius;
        private double? circumference = null;

        public Circle()
        {
            
        }

        public double? Circumference
        {
            get {
                if (circumference == null)
                    circumference = radius * 2 * Math.PI;

                return circumference;
            }
        }

        public double Radius
        {
            get {
                return radius;
            }
        }

    }
}
