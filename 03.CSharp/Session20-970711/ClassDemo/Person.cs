using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Person
    {
        protected internal string name;
        protected internal string family;
        protected int age;
        internal string nationalCode;
        public string phone;

        public void writeMyName()
        {
            Console.WriteLine($"{name} {family}");
        }
    }
}
