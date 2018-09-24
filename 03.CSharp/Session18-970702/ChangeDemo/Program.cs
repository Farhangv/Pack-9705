using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            Console.WriteLine(x);//10
            ChangeInt(ref x);
            Console.WriteLine(x);//10
            Console.WriteLine("------------------");
            var dt = DateTime.Now;
            Console.WriteLine(dt);
            ChangeDateTime(ref dt);
            Console.WriteLine(dt);
            Console.WriteLine("------------------");
            var txt = "Sample text";
            Console.WriteLine(txt);
            ChangeString(ref txt);
            Console.WriteLine(txt);
            Console.WriteLine("------------------");
            var y = new int[] { 10 };
            Console.WriteLine(y[0]);//10
            ChangeArray(ref y);
            Console.WriteLine(y[0]);//11

            Console.ReadKey();

        }

        static void ChangeInt(ref int num)
        {
            num++;
        }

        static void ChangeDateTime(ref DateTime dt)
        {
            dt = dt.AddDays(10);
        }

        static void ChangeString(ref string text)
        {
            text = text + " Changed From Function";
        }

        static void ChangeArray(ref int[] nums)
        {
            nums[0]++;
        }
    }
}
