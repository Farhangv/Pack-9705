using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifetimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            if (true)
            {
                Console.WriteLine(name);
                var family = "Doe";
            }

            //Console.WriteLine(family);
            
        }
    }
}
