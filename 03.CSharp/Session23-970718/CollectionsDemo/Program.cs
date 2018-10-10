using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(123);
            al.Add(456);
            al.Add("Test");
            al.Add(DateTime.Now);
            al.Add(new Person());
            al.Add(new Random());

            //al.Sort();

            //var result = al[0] is Person;
            //var p = al[0] as Person;
            //var result = p == null ? false : true;
            //var p = (Person)al[0];

            al.Remove(456);
            al.RemoveAt(0);
            Console.WriteLine(al.IndexOf("Test"));
            al.Insert(1, "Inserted member");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(al.Contains("Test"));
            al.Clear();
            Console.WriteLine(al.Count);
            
            Console.ReadKey();

        }
    }
}
