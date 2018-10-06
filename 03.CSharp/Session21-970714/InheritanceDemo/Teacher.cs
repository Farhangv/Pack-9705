using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Teacher:Person
    {
        public int CourseCount { get; set; }
        public int CourseRate { get; set; }

        public override double GetBalance()
        {
            return -1 * CourseCount * CourseRate;
        }
    }
}
