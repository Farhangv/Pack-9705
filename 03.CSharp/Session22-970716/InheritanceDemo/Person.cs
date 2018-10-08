using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public virtual double GetBalance()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{Name}\t{Family}\t{GetBalance()}";
        }

    }
}
