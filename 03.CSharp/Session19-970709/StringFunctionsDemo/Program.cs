using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("         John       ".TrimEnd());
            Console.WriteLine("Doe");
            Console.WriteLine("Hello C#".Substring(3,1));
            Console.WriteLine("Hello C#"[1]);
            Console.WriteLine("C# and Java are Object Oriented Programming languages".Contains("PHP"));
            Console.WriteLine("C# and Java are Object Oriented Programming languages".Replace("C#","PHP"));

            Console.ReadKey();
        }
    }
}
