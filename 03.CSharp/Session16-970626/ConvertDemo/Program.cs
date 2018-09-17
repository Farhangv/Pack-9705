using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + y);

            Console.ReadKey();
        }
    }
}
