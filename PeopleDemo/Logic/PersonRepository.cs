using PeopleDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleDemo.Logic
{
    public class PersonRepository
    {
        public List<Person> GetAllPeople()
        {
            List<Person> people = new List<Person>();

            using(StreamReader reader = new StreamReader("C:/Output/people.txt"))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    people.Add(new Person(
                        int.Parse(values[1]),
                        values[0]
                    ));
                }
            }

            return people;
        }
    }
}
