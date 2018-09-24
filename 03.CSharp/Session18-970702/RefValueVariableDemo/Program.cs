using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValueVariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);//10
            int b = a;
            b++;
            Console.WriteLine(a);//10

            Console.WriteLine("---------------------");
            int[] c = new int[] { 10 };
            Console.WriteLine(c[0]);//10
            int[] d = c;
            d[0]++;
            Console.WriteLine(c[0]);//10 //11
            Console.WriteLine("---------------------");
            string e = "Text";
            Console.WriteLine(e);//Text
            string f = e;
            f += " Changed";
            Console.WriteLine(e);//Text

            Console.ReadKey();
        }
    }
}
