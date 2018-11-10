using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CFModel ctx = new CFModel();
            ctx.People.Add(new Person() { Name = "John", Family = "Doe" });
            ctx.SaveChanges();
        }
    }
}
