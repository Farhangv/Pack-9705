using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] { 45,74,12,65,45,78,52,32,12,45,4,3,9,2,5,19 };
            //Array.Sort(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            Student[] students = new Student[]
                {
                    new Student() { Name = "Ross", Family = "Geller", Average = 80 },
                    new Student() { Name = "Chandler", Family = "Bing", Average = 70 },
                    new Student() { Name = "Monica", Family = "Geller", Average = 90 }
                };

            Array.Sort(students);
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}
