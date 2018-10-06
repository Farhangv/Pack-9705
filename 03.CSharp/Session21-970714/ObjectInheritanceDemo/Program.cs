using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Name = "Ross", Family = "Geller" , NationalCode = "1234567890" };
            Person p2 = new Person() { Name = "Ross", Family = "Geller", NationalCode = "127890" };
            Console.WriteLine(p.GetType());
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p.ToString());
            Console.WriteLine(p);
            Console.WriteLine(p.Equals(123));

            Console.WriteLine("------------------");
            Console.WriteLine("Hello".GetHashCode());
            Console.WriteLine(123.GetHashCode());
            Console.WriteLine("Hello".GetHashCode());





            Console.ReadKey();
        }

        static void WriteLine(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
