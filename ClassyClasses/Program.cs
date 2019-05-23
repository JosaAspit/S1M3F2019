using System;
using System.Collections.Generic;

namespace ClassyClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Jens-Ole", "Teacher", new DateTime(1989, 08, 10));
            Person person2 = new Person("Hans Karl", "Brick Slayer", new DateTime(1960, 03, 17));
            Person person3 = Person.NewPerson("Hanne", "Financial manager", new DateTime(1974, 10, 13));
            //person.name = "Jens-Ole";
            //person.occupation = "Teacher";
            //person.birthday = new DateTime(1989, 08, 10);

            List<Person> people = new List<Person>();
            
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);

            person1.Age = 20;

            person2.Age = -30;


            foreach (var person in people)
            {
                Console.WriteLine(person.GetSummary());
            }
            
            Console.ReadKey();
        }
    }
}
