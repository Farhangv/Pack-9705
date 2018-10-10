using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>();
            //List<int> scores = new List<int>();

            //List<Person> people = new List<Person>();

            //Dictionary<string, Person> people = new Dictionary<string, Person>();
            //people.Add("STD01", new Person() { Id = 1, Name = "John", Family = "Doe" });
            //people.Add("STD02", new Person() { Id = 2, Name = "David", Family = "Smith" });
            //people.Add("STD03", new Person() { Id = 3, Name = "Ross", Family = "Geller" });

            //foreach (KeyValuePair<string,Person> item in people)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value.Name}");
            //}

            //Stack<int> s = new Stack<int>();
            //s.Push(1);
            //s.Push(2);
            //s.Push(3);

            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            

            Console.ReadKey();
        }
    }
}
