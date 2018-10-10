using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceDemo
{
    class MyClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.FirstMethod()
        {
            throw new NotImplementedException();
        }

        void IFirstInterface.MyMethod()
        {
            throw new NotImplementedException();
        }

        void ISecondInterface.MyMethod()
        {
            throw new NotImplementedException();
        }

        void ISecondInterface.SecondMethod()
        {
            throw new NotImplementedException();
        }
    }
}
