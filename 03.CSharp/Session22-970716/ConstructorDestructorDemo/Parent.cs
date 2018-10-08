using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorDemo
{
    class Parent
    {
        public Parent(string _name, string _family)
        {
            Name = _name;
            Family = _family;
            Console.WriteLine("Parent Instanciated!");
        }

        public string Name { get; set; }
        public string Family { get; set; }

        ~Parent()
        {

        }
    }
}
