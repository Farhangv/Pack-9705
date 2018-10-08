using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Student() { Name = "Ross", Family = "Geller", UnitBaseRate = 1000, UnitCount = 20 },
                new Employee() { Name = "Monica", Family = "Geller", BaseRate = 2000, WorkingHours = 40},
                new SalesEmployee() { Name = "Chandler", Family = "Bing", BaseRate = 1000, WorkingHours = 40, TotalSales = 20000, Percentage = 0.02 },
                new Teacher() { Name = "Sheldon", Family = "Cooper", CourseCount = 5, CourseRate = 10000},
                new Student() { Name = "Leonard", Family = "Hofsteder", UnitBaseRate = 2000, UnitCount = 40 },
                //new Person() { Name = "Penni", Family = "" }
            };

            var sum = 0.0;
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i]);
                sum += people[i].GetBalance();
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
