using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var diff = DateTime.Now - DateTime.Now.AddDays(-3);
            Console.WriteLine(diff.TotalHours);
            Console.ReadKey();
        }
    }
}
