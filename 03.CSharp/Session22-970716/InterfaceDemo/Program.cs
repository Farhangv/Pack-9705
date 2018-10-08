using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IHasVolume[] objects = new IHasVolume[]
                {
                    new Student() { Height = 180 },
                    new Camera(),
                    new Laptop() { Height = 15, Length = 50, Width = 35, RAM = 16, CPUModel = "Intel Core i5" },
                    new Student() { Height = 170 },
                    new Student() { Height = 160 },
                    new Laptop() { Height = 20, Length = 50, Width = 35, RAM = 8, CPUModel = "AMD" },
                };

            var sum = 0.0;
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] is Laptop)
                {
                    var laptop = objects[i] as Laptop;
                    Console.WriteLine($"{objects[i].GetVolume()} RAM:{laptop.RAM}, CPU:{laptop.CPUModel}");
                }
                else
                    Console.WriteLine(objects[i].GetVolume());

                sum += objects[i].GetVolume();
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
