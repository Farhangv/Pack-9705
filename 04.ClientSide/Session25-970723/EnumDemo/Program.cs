using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgrammingLanguages language = ProgrammingLanguages.جاواـاسکریپت;
            Console.WriteLine((int)language);
            Console.WriteLine((ProgrammingLanguages)4);
            Console.ReadKey();
            
        }
    }
}
