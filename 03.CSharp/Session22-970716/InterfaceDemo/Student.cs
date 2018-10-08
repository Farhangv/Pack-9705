using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Student : IHasVolume
    {
        public double Height { get; set; }
        public double GetVolume()
        {
            return Math.Pow(50, 2) * Math.PI * this.Height;
        }
    }
}
