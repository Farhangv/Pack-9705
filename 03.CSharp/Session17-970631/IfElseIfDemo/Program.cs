using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Score:");
            var score = double.Parse(Console.ReadLine());
            //if (!(score > 20 || score < 0))
            if(score <= 20 && score >= 0)
            {
                if (score >= 19)
                    Console.WriteLine("A+");
                else if (score >= 18)
                    Console.WriteLine("A");
                else if (score >= 17)
                    Console.WriteLine("A-");
                else if (score >= 16)
                    Console.WriteLine("B+");
                else
                    Console.WriteLine("Failed");
            }
            else
                Console.WriteLine("Invalid Score!");


            switch (score)
            {
                case 0:
                case 0.01:
                case 0.02:
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
    }
}
