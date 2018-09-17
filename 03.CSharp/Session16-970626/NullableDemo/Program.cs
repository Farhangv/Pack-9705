using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            //int? age = null;
            Nullable<int> age = null;
            string name = null;
            int a, b;


            Console.WriteLine(age);
            Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
