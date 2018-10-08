using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Camera : Product, IHasVolume
    {
        public double GetVolume()
        {
            return 50;
        }
    }
}
