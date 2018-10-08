using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainArgumentsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args != null && args.Length > 0)
                Console.WriteLine(args[0]);

            Console.ReadKey();
        }
    }
}
