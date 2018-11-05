using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
                {
                    "C#",
                    "Java",
                    "PHP",
                    "JavaScript",
                    "Python",
                    "Perl",
                    "TypeScript",
                    "Ruby"
                };

            var filteredNames = from n in names
                                where n.ToLower().Contains("script")
                                select n;

            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
