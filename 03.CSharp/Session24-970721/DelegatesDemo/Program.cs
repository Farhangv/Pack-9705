using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void ArrayCalculator(int[] numbers);
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCalculator calculators = new ArrayCalculator(Sum);
            calculators += Min;
            calculators += Max;

            calculators(new int[] { 14, 15, 78, 52, 12, 23, 41, 21, 10, 8 });

            Console.ReadKey();
        }

        static void Sum(int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");
        }

        static void Min(int[] numbers)
        {
            var min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine($"Min: {min}");
        }

        static void Max(int[] numbers)
        {
            var max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            Console.WriteLine($"Max: {max}");
        }
    }
}
