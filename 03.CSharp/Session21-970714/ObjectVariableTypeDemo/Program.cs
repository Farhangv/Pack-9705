using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectVariableTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = new object();
            object p = new Product();//Boxing
            Product c = new Camera();//UpCasting
            object s = "Salaam";//Boxing
            object i = 123456;//Boxing
            object d = DateTime.Now;//Boxing

            Product p1 = p as Product;//UnBoxing
            Camera c1 = (Camera)c;//DownCasting
            string s1 = s as string;//UnBoxing
            int i1 = (int)i;//UnBoxing
            DateTime? d1 = d as DateTime?;//UnBoxing
            
        }
    }
}
