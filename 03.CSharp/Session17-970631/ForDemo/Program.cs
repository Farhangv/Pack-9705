using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            for (int num = int.Parse(Console.ReadLine()); num > 0; num--)
            {
                result += num;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
