﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleDemo.Models
{
    public class Person
    {
        private string name;
        private int age;

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
