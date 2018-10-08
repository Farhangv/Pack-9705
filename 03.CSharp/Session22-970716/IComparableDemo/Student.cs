using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Student
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public double Average { get; set; }

        public override string ToString()
        {
            return $"{Name} {Family} [{Average}]";
        }
    }
}
