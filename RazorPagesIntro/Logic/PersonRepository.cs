using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesIntro.Logic
{
    public class PersonRepository
    {
        public List<Person> GetPeopleFromFile()
        {
            return null;
        }

        public Person GetPersonById(int id)
        {
            return GetPeopleFromFile().Where(x => x.id == id).FirstOrDefault();
        }
    }
}
