using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInheritanceDemo
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }

        public override int GetHashCode()
        {
            return NationalCode.GetHashCode();
        }

        public override string ToString()
        {
            return $"{NationalCode}, {Name} {Family}";
        }

        public override bool Equals(object obj)
        {
            //return GetHashCode() == obj.GetHashCode();
            //var other = obj as Person;
            //if (obj is Person)
            //{
            //    var other = (Person)obj;
            //    return this.Name == other.Name && this.Family == other.Family;
            //}
            //else
            //    return false;

            var other = obj as Person;
            if (other != null)
                return this.Name == other.Name && this.Family == other.Family;
            else
                return false;
        }
    }
}
