using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Enter Number 1:");
            //var num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number 2:");
            //var num2 = int.Parse(Console.ReadLine());

            //WriteSum(num1, num2);

            int[] nums = new int[] { 14,16,85,42,86,94,75,21,9,61,44 };
            var min = GetMin(nums); //9
            Console.WriteLine($"Min: {min}");
            WriteSum(nums);
            Console.WriteLine("Odd Numbers:");
            WriteOddNumbers(nums);
            Console.WriteLine("Even Numbers:");
            WriteEvenNumbers(nums);
            Console.ReadKey();
        }

        static void WriteSum(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
        }
        static int GetMin(int[] numbers)
        {
            var result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < result)
                    result = numbers[i];
            }

            return result;
        }

        static void WriteSum(int[] numbers)
        {
            var result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine($"Sum: {result}");
        }

        static void WriteOddNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 != 0)
                    Console.WriteLine(numbers[i]);
            }
        }
        static void WriteEvenNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i]);
            }
        }
    }
}
