using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CountDownDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountDown(10, interval: 2);
            CountDown(interval: 2, start: 10);
            Console.ReadKey();
        }

        static void CountDown(int start, int end = 1, int interval = 1)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.CursorVisible = false;
            Random r = new Random();
            for (int i = start; i >= end ; i = i - interval)
            {
                Console.Clear();
                Console.SetCursorPosition(
                    Console.WindowWidth / 2 - 1, 
                    Console.WindowHeight / 2 - 1);
                Console.WriteLine(i);
                Console.Beep(r.Next(1000,10000), 500);
                Thread.Sleep(1000);
            }
        }
    }
}
