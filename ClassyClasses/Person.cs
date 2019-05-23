using System;
using System.Collections.Generic;
using System.Text;

namespace ClassyClasses
{
    public class Person
    {
        //Fields
        public string name;
        public string occupation;
        public DateTime birthday;

        //properties - Indkapsling/Encapsulation
        private int age;

        public int Age
        {
            get { return age; }
            set {
                age = value;
            }
        }


        public Person(string name, string occupation, DateTime birthday)
        {
            int derp = 0;
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
