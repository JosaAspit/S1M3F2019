using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S1M3F2019_Demos
{
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
    }

    public class SearchDemo
    {
        static List<Car> cars = new List<Car>
        {
            new Car{Color = "Red",Year = 1989},
            new Car{Color = "blue",Year = 2001},
            new Car{Color = "yelloe",Year = 2005}
        };

        public static void Search()
        {
            string mySearchParam = "blue";
            Car myFoundCar = null;

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Color == mySearchParam)
                {
                    myFoundCar = cars[i];
                }
            }
            Console.WriteLine(myFoundCar.Color);

            foreach (var item in cars)
            {
                if (item.Color == mySearchParam)
                {
                    myFoundCar = item;
                }
            }

            //ez snyde måde i LINQ
            var res = cars.Where(x => x.Color == mySearchParam).ToList();

            var res2 = from c in cars
                       where c.Color == mySearchParam
                       select c;
        }
    }
}
