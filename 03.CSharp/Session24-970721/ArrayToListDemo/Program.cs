using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "C#", "Java" };
            //List<string> namesList = new List<string>(names);
            List<string> namesList = names.ToList();
            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
