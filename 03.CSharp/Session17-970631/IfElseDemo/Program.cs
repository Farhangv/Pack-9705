using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username:");
            var username = Console.ReadLine().ToLower();
            Console.Write("Password:");
            var password = Console.ReadLine();

            if (username == "admin" && password == "q12q12")
                Console.WriteLine("Welcome Admin!");
            else
            {
                Console.WriteLine("Login Failed!");
            }

            Console.ReadKey();
        }
    }
}
