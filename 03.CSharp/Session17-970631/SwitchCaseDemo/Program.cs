using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add Recipe\n2.Show Recipe\n3.Edit Recipe\n4.Remove Recipe");
            var selectedItem = int.Parse(Console.ReadLine());


            //if (selectedItem == 1)
            //    ;
            //else if (selectedItem == 2)
            //    ;
            //else if (selectedItem == 3)
            //    ;
            //else if (selectedItem == 4)
            //    ;
            //else
            //    ;
            switch (selectedItem)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Add New Recipe!");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("List Of Recipes!");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Edit Recipe!");
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Remove Recipe!");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Menu Item!");
                    break;
            }

            Console.ReadKey();

        }
    }
}
