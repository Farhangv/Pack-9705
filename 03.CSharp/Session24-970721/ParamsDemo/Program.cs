using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            sum(new int[] { 10, 54, 12, 13, 4, 7, 85, 9, 6 });
            sum(10, 54, 12, 13, 4, 7, 85, 9, 6);

        }

        static int sum(params int[] numbers)
        {
            var sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}
