using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "John", Family = "Doe" };
            var product = new { Name = "Laptop", CPU = "Core i7" };


            Console.WriteLine(person.Name);
            Console.WriteLine(product.CPU);
            //Console.WriteLine(person.Age);
        }
    }
}
