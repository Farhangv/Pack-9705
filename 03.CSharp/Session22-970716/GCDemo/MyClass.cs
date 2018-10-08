using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo
{
    class MyClass
    {
        public static int InstanceCount { get; set; }

        public MyClass()
        {
            MyClass.InstanceCount++;
        }

        ~MyClass()
        {
            MyClass.InstanceCount--;
        }
    }
}
