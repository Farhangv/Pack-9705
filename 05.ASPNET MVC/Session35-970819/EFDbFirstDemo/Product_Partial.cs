using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirstDemo
{
    public partial class Product
    {
        public override string ToString()
        {
            return $"{this.ProductID}.{this.Name} : {this.ListPrice}";
        }
    }
}
