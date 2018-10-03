using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[10];
            for (int n = 0; n < people.Length; n++)
            {
                Console.Clear();
                for (int i = 0; i < people.Length; i++)
                {
                    if(people[i] != null)
                        //Console.WriteLine($"{people[i].getName()}\t{people[i].getFamily()}\t{people[i].getNationalCode()}\t{people[i].getBirthDate()}({people[i].getAge()})");
                        Console.WriteLine($"{people[i].Name}\t{people[i].Family}\t{people[i].NationalCode}\t{people[i].BirthDate}({people[i].Age})");
                }

                Console.WriteLine("------------------");

                people[n] = new Person();
                Console.WriteLine("Name:");
                //people[n].setName(Console.ReadLine());
                people[n].Name = Console.ReadLine();
                Console.WriteLine("Family:");
                //people[n].setFamily(Console.ReadLine());
                people[n].Family = Console.ReadLine();
                Console.WriteLine("NationalCode:");
                //people[n].nationalCode = Console.ReadLine();
                //people[n].setNationalCode(Console.ReadLine());
                people[n].NationalCode = Console.ReadLine();
                Console.WriteLine("BirthDate:");
                //people[n].setBirthDate(Console.ReadLine());
                people[n].BirthDate = Console.ReadLine();

                //people[n].Age = 10;
            }
        }
    }
}
