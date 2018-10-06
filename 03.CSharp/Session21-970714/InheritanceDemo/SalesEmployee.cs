using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class SalesEmployee:Employee
    {
        public double Percentage { get; set; }
        public int TotalSales { get; set; }

        public override double GetBalance()
        {
            return base.GetBalance() + (Percentage * TotalSales);
        }
    }
}
