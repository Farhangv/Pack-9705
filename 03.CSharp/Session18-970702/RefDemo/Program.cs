using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 47, 45, 63, 25, 78, 96, 54, 125, 5, 11, 55 };
            int min = 0, max = 0;
            double avg = 0;
            var sum = Sum(nums, ref min, ref max, ref avg);

            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Min : {min}");
            Console.WriteLine($"Max : {max}");
            Console.WriteLine($"Average : {avg}");

            Console.ReadKey();

        }

        static int Sum(int[] numbers,ref int min,ref int max,ref double average)
        {
            var sum = 0;
            min = numbers[0];
            max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
                sum += numbers[i];
            }

            average = sum / numbers.Length;
            return sum;
        }
    }
}
