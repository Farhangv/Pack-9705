using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortIfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary Operator
            var num = int.Parse(Console.ReadLine());
            if(num > 10)
                Console.WriteLine("Greater Than 10");
            else
                Console.WriteLine("Less Than 10");

            Console.WriteLine(num > 10 ? ">10" : "<10");

            Console.ReadKey();

        }
    }
}
