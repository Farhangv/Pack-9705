using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Text:");
                var text = Console.ReadLine();
                if (text == "exit")
                    break;
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    Console.Write(text[i]);
                }

                Console.ReadKey();
            }

        }
    }
}
