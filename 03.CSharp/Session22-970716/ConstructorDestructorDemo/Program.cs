using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConstructorDestructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent("John", "Doe");
            Child c = new Child("Ross", "Geller");

            Console.ReadKey();
        }
    }
}
