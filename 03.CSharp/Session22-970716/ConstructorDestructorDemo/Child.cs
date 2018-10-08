using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorDemo
{
    class Child:Parent
    {
        //public Child()
        //    :base("David","Doe")
        public Child(string _name, string _family)
            : base(_name, _family)
        {
            Console.WriteLine("Child Instanciated");
        }
    }
}
