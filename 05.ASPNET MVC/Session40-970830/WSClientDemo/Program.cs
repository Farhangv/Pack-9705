using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSClientDemo.MathServiceReference;

namespace WSClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServiceSoapClient client = new MathServiceSoapClient();
            var result = client.Sum(25,10);
            //
            //
            //
            //
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
