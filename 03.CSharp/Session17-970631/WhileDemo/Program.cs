using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter valid number:");
            var number = int.Parse(Console.ReadLine());
            double result = 1;
            while (number > 1)
            {
                result *= number--;
            }

            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}
