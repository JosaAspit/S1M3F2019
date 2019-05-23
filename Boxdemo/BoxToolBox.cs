using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Boxdemo
{
    public static class BoxToolBox
    {
        public static Box FindLargestBoxByVolume(List<Box> boxes)
        {
            Box largest = boxes[0];
            foreach (var box in boxes)
            {
                if (box.GetVolume() > largest.GetVolume())
                {
                    largest = box;
                }
            }

            return largest;
        }

       public static List<Box> GetBoxes()
        {
            List<Box> boxes = new List<Box>();

            using (StreamReader reader = new StreamReader("boxes.txt"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    boxes.Add(new Box(
                        int.Parse(values[0]),
                        int.Parse(values[1]),
                        int.Parse(values[2])
                    ));
                }
            }

            return boxes;
        }

    }
}
