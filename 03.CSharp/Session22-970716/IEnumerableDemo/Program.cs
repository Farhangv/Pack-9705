using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam exam = new Exam()
            {
                Name = "MCSD Exam",
                Questions = new Question[]
                {
                    new Question() {Id = 1 , Text = "What's your name" },
                    new Question() {Id = 2 , Text = "Describe OOP" },
                    new Question() {Id = 3, Text = "Describe GC" },
                    new Question() {Id = 4 , Text = "What's the difference between Interface and Abstract Class" }

                }
            };
            foreach (Question q in exam)
            {
                Console.WriteLine(q);
            }
            Console.ReadKey();
        }
    }
}
