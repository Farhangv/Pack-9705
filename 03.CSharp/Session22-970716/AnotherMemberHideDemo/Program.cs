using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherMemberHideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();

            c.WriteText();

            Console.ReadKey();
        }
    }
}
