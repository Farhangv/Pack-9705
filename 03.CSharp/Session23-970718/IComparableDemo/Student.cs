using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Student:IComparable
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public double Average { get; set; }

        public int CompareTo(object obj)
        {
            var other = obj as Student;
            if (other != null)//Student
            {
                if (this.Family != other.Family)
                    return this.Family.CompareTo(other.Family);

                return this.Name.CompareTo(other.Name);
            }
            return -1;
        }

        public override string ToString()
        {
            return $"{Name} {Family} [{Average}]";
        }
    }

    class StudentAverageComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (((Student)x).Average).CompareTo(((Student)y).Average) * -1;
        }
    }
}
