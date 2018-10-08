using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Samand s = new Samand();
            Samand.Manufacturer = "IKCO";
            Samand s2 = new Samand();
            
            Console.WriteLine(Samand.Manufacturer);
            //Math m = new Math();
            //SampleMethod();
            Program p = new Program();
            p.SampleMethod();
            Console.WriteLine();
            Console.ReadLine();
            Console.ReadKey();
        }

        void SampleMethod()
        {

        }

        
    }
}
