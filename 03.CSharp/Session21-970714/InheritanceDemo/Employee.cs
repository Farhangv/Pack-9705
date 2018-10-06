using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Employee:Person
    {
        public int WorkingHours { get; set; }
        public int BaseRate { get; set; }

        public override double GetBalance()
        {
            if (WorkingHours < 42)
                return WorkingHours * BaseRate * -1;
            else
                return (42 * BaseRate + (WorkingHours - 42) * 1.4 * BaseRate) * -1;

        }
    }
}
