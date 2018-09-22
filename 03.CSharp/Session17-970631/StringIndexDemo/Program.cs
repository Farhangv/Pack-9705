using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello C#, How Are You?";
            Console.WriteLine(text[4]);
            Console.WriteLine(text.Length);
            //Console.WriteLine($"{123456.3456789:G5}");
            //Console.WriteLine($"{123456.3456789:E5}");

            Console.ReadKey();
        }
    }
}
