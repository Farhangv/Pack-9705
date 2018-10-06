using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsUsageDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Id = 1, Name = "John", Family = "Doe" });
            people.Add(new Person() { Id = 2, Name = "Monica", Family = "Geller" });
            people.Add(new Person() { Id = 3, Name = "Barney", Family = "Stinson" });
            people.Add(new Person() { Id = 4, Name = "Ross", Family = "Geller" });

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].Name);
            }
            Console.WriteLine("-----");
            people.Remove(new Person() { Id = 2, Name = "Monica", Family = "Geller" });
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].Name);
            }
            Console.WriteLine("-----");
            Console.WriteLine(people.Contains(new Person() { Id = 4, Name = "Ross", Family = "Geller" }));
            Console.WriteLine("----------------------");
            List<string> names = new List<string>();
            names.Add("C#");
            names.Add("Java");
            names.Add("PHP");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("-----");
            names.Remove("Java");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();
        }
    }
}
