using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 4);
            Console.WriteLine(10 / 3);
            Console.WriteLine(10.0 / 3.0);
            Console.WriteLine(10.0 / 3);
            Console.WriteLine(10 % 3);
            Console.WriteLine(3 * 5);
            Console.WriteLine(10 - -9);
            var x = 10;
            x = x - 3;
            Console.WriteLine(x);
            x -= 2;
            /*
             * += *= /=
             */
            Console.WriteLine(x);
            //x--;
            --x;
            //x = x - 1;
            Console.WriteLine(x);
            Console.WriteLine("---------------------");
            Console.WriteLine(++x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
