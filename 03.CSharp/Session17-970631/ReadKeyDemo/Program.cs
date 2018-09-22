using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKeyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int left = 0, top = 0;
            while (true)//Infinite Loop
            {
                var pressedKey = Console.ReadKey().Key;
                Console.BackgroundColor = ConsoleColor.Magenta;

                switch (pressedKey)
                {
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(left, --top);
                        Console.Write(" ");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(left, ++top);
                        Console.Write(" ");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(++left, top);
                        Console.Write(" ");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(--left, top);
                        Console.Write(" ");
                        break;

                    default:
                        break;
                }

            }
        }
    }
}
