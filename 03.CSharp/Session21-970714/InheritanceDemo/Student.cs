using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Student:Person
    {
        public int UnitCount { get; set; }
        public int UnitBaseRate { get; set; }

        public override double GetBalance()
        {
            return UnitCount * UnitBaseRate;
        }
    }
}
