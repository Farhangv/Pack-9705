using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            while (num < 10)
            {
                Console.WriteLine("While");
            }

            do
            {
                Console.WriteLine("Do...While");
            } while (num < 10);

            Console.ReadKey();
        }
    }
}
