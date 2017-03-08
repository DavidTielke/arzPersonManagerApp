using System.Collections.Generic;
using System.Linq;
using ARZ.PersonManagerApp.CrossCutting.DataClasses;

namespace ARZ.PersonManagerApp.Data.DataStoring
{
    public class PersonRepository : IPersonRepository
    {
        public IQueryable<Person> LoadAll()
        {
            var persons = new List<Person>
            {
                new Person(1, "David", 32),
                new Person(2, "Lena", 30),
                new Person(3, "Maximilian", 4),
                new Person(4, "Teddy", 3),
                new Person(5, "Hasi", 4),
            };
            return persons.AsQueryable();
        }
    }
}