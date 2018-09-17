using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormattingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John";
            var balance = 100000000;
            Console.WriteLine("Hello " + name + "Your Balance is" + balance);
            Console.WriteLine("Hello {0} Your Balance is : {1:C} Dollars", name, balance);
            var text = string.Format("Hello {0} Your Balance is : {1} Dollars", name, balance);
            Console.WriteLine(text);
            var newText = $"Hello {name} Your Balance is : {balance:###,#} Dollars";
            Console.WriteLine(newText);
            Console.WriteLine($"Hello {name} Your Balance is : {balance} Dollars");
            Console.ReadKey();
        }
    }
}
