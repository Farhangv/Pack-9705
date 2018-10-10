using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceDemo
{
    class Question : IComparable<Question>
    {
        public int CompareTo(Question other)
        {
            throw new NotImplementedException();
        }
    }
}
