using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReaderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
                
            }
            else
            {
                Console.WriteLine("No Arguments Passed!");
            }

            Console.ReadKey();
        }
    }
}
