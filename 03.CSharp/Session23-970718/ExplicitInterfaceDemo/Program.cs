using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            //((IFirstInterface)mc)
            IFirstInterface fi = new MyClass();
            ISecondInterface si = new MyClass();

            
        }
    }
}
