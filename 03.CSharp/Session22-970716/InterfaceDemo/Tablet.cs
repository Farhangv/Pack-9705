using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Tablet : Product, IComputerDevice
    {
        public string CPUModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RAM { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
