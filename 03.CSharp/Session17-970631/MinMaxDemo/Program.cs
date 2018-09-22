using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers Count:");
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            Console.Clear();
            //int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------------");
            int min = numbers[0], max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];

                if (numbers[i] > max)
                    max = numbers[i];
            }

            Console.WriteLine($"Min:{min} | Max:{max}");
            Console.ReadKey();
        }
    }
}
