using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            object o = new object();
            
            Person p = new Person() { Name = "Ross", Family = "Geller", NationalCode = "1234567890" };
            Person p2 = new Person() { Name = "Ross", Family = "Geller", NationalCode = "1234567890" };
            Console.WriteLine(p.GetType());
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.Equals(p2));
            Console.ReadKey();
        }
    }
}
