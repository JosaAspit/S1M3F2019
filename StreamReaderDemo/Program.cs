using System;
using System.Collections.Generic;
using System.IO;
namespace StreamReaderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Console.WriteLine("Reading Objects from file");

            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    people.Add(
                        new Person(
                            data[1],
                            data[0],
                            int.Parse(data[2])
                        )
                    );
                }
            }
        }
    }
}
