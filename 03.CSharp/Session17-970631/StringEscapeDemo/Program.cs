using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEscapeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ross\tGeller");
            Console.WriteLine("Ross\nGeller");
            Console.WriteLine("C:\\MyFolder\\MyFile.txt");
            Console.WriteLine(@"C:\MyFolder\MyFile.txt");
            Console.ReadKey();
        }
    }
}
