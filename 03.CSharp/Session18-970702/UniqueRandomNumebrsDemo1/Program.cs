using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueRandomNumebrsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[1000000];
            Random r = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < randomNumbers.Length; /*i++*/)
            {
                var randomNumber = r.Next(1000000, 3000000);
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (randomNumbers[j] == randomNumber)
                    {
                        isUnique = false;
                        break;
                    }

                }
                if (isUnique)
                    randomNumbers[i++] = randomNumber;
            }
            sw.Stop();

            Array.Sort(randomNumbers);
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }

            Console.WriteLine("----------------");
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
