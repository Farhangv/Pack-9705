using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrawTable(13, 5, 5, 5);
            int X = 0, Y = 0;
            DrawTable(13, 5, 3, 3, selectedX: X, selectedY: Y);
            int tableSize = 3;
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Y != 0)
                        {
                            Console.Clear();
                            DrawTable(13, 5, 3, 3, selectedX: X, selectedY: --Y);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Y != tableSize - 1)
                        {
                            Console.Clear();
                            DrawTable(13, 5, 3, 3, selectedX: X, selectedY: ++Y);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (X != 0)
                        {
                            Console.Clear();
                            DrawTable(13, 5, 3, 3, selectedX: --X, selectedY: Y);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (X != tableSize - 1)
                        {
                            Console.Clear();
                            DrawTable(13, 5, 3, 3, selectedX: ++X, selectedY: Y);
                        }
                        break;

                }
            }
            
        }

        static void DrawBox(int width, 
            int height, 
            int left, 
            int top, ConsoleColor color = ConsoleColor.Cyan)
        {
            Console.BackgroundColor = color;
            Console.CursorVisible = false;
            for (int j = 0; j < height; j++)//Row
            {
                Console.SetCursorPosition(left, top++);
                for (int i = 0; i < width; i++)
                {
                    Console.Write(" ");
                }

            }

            Console.BackgroundColor = ConsoleColor.Black;

        }

        static void DrawTable(int cellWidth, 
            int cellHeight, 
            int left, 
            int top, 
            int size = 3, 
            ConsoleColor color = ConsoleColor.Cyan,
            int selectedX = 0,
            int selectedY = 0,
            ConsoleColor selectedColor = ConsoleColor.DarkGreen)
        {
            var initialLeft = left;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //DrawBox(cellWidth, cellHeight, left, top, color);
                    if(i == selectedY && j == selectedX)
                        DrawBox(cellWidth, cellHeight, left, top, selectedColor);
                    else
                        DrawBox(cellWidth, cellHeight, left, top, color);
                    left = left + (cellWidth + 1);
                }
                top = top + (cellHeight + 1);
                left = initialLeft;
            }
        }
    }
}
