using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassFunctionDemo
{
    public delegate bool NumberFilter(int number);
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5,14,12,3,14,78,41,21,32,1,14,79,65,42 };
            //WriteFilteredNumbers(numbers, OddFilter);
            //WriteFilteredNumbers(numbers, EvenFilter);
            //WriteFilteredNumbers(numbers, 
            //    (x) 
            //    => 
            //    {
            //        return x % 2 == 0;
            //    });

            //WriteFilteredNumbers(numbers, x => x % 2 == 0);
            WriteFilteredNumbers(numbers, x => x % 7 == 0 && x % 3 == 0);

            Console.ReadKey();
        }
        static bool OddFilter(int number)
        {
            return number % 2 != 0;
        }
        static bool EvenFilter(int number)
        {
            return number % 2 == 0;
        }
        static void WriteFilteredNumbers(int[] numbers, NumberFilter filter)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(filter(numbers[i]))
                    Console.WriteLine(numbers[i]);
            }
        }
    }
}
