using System;
using System.Collections.Generic;
using System.Text;

namespace StreamReaderDemo
{
    public class Person
    {
        private int age;
        private string name;
        private string occupation;

        public Person(string occupation, string name, int age)
        {
            Occupation = occupation;
            Name = name;
            Age = age;
        }

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string GetSummary()
        {
            return $"{Name} is {Age} years old, and is working as a {Occupation}";
        }
    }
}
