using System;
using System.Collections.Generic;
using System.Text;

namespace Boxdemo
{
    public class Box
    {
        private int height;
        private int width;
        private int length;

        public Box(int height, int width, int length)
        {
            this.height = height;
            this.width = width;
            this.length = length;
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int GetVolume()
        {
            return length * height * width;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

    }
}
