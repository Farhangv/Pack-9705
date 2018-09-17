using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("family?");
            var family = Console.ReadLine();

            Console.WriteLine($"Hello {name} {family}");

            Console.ReadKey();
        }
    }
}
