using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IComputerDevice
    {
        string CPUModel { get; set; }
        int RAM { get; set; }
    }
}
