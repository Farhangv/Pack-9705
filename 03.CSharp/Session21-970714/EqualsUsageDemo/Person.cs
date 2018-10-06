using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsUsageDemo
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object obj)
        {
            //return GetHashCode() == obj.GetHashCode();
            if (obj is Person)
            {
                var other = obj as Person;
                return other.Name == this.Name && other.Family == this.Family;
            }
            else
                return false;
        }
    }
}
