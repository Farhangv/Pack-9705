using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Laptop : Product, IHasVolume, IComputerDevice
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public string CPUModel { get; set;}
        public int RAM { get; set; }
        public double GetVolume()
        {
            return this.Height * this.Width * this.Length;
        }
    }
}
