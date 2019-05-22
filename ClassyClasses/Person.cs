using System;
using System.Collections.Generic;
using System.Text;

namespace ClassyClasses
{
    public class Person
    {
        //Instance members
        public string name;
        public string occupation;
        public DateTime birthday;

        public Person(string name, string occupation, DateTime birthday)
        {
            this.name = name;
            this.occupation = occupation;
            this.birthday = birthday;
        }

        public string GetSummary()
        {
            return $"{name} was born in {birthday.Year}, and is working as a {occupation}";
        }

        public static Person NewPerson(string name, string occupation, DateTime birthday)
        {
            return new Person(name, occupation, birthday);
        }
    }
}
