using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person(1, "David", 32),
                new Person(2, "Lena", 30),
                new Person(3, "Maximilian", 4),
                new Person(4, "Teddy", 3),
                new Person(5, "Hasi", 4),
            };

            Console.WriteLine($"### Erwachsene ({persons.Count(p => p.Age >= 18)}) ###");
            persons.Where(p => p.Age >= 18).ToList().ForEach(p => Console.WriteLine(p.Name));

            Console.WriteLine($"### Kinder ({persons.Count(p => p.Age < 18)}) ###");
            persons.Where(p => p.Age < 18).ToList().ForEach(p => Console.WriteLine(p.Name));

            Console.ReadKey();
        }
    }

    internal class Person
    {
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
