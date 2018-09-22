using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace RandomNumbersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ابزار تولید عدد رندم
            Random rnd = new Random();
            int[] numbers = new int[500000];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1000000, 3000000);
            }

            sw.Stop();
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine(sw.Elapsed);

            Console.ReadKey();

        }
    }
}
