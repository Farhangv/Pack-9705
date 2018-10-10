using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter sw = new StreamWriter(@"mydata.txt", true))
            //{
            //    //sw.AutoFlush = true;
            //    while (true)
            //    {
            //        var input = Console.ReadLine();
            //        if (input == "exit")
            //            break;
            //        sw.WriteLine(input);
            //        //sw.Flush();
            //    }
            //}//sw.Close();

            List<string> names = new List<string>();
            using (StreamReader sr = new StreamReader(@"mydata.txt"))
            {
                //Console.WriteLine((char)sr.Read());
                //Console.WriteLine((char)sr.Read());
                //Console.WriteLine((char)sr.Read());
                //Console.WriteLine((char)sr.Read());
                //Console.WriteLine(Convert.ToChar(sr.Read()));

                //while (sr.Peek() != -1)
                //{
                //    Console.Write((char)sr.Read());
                //}

                while (sr.Peek() != -1)
                {
                    //Console.WriteLine(sr.ReadLine());
                    names.Add(sr.ReadLine());
                }
                //Console.WriteLine(sr.ReadToEnd());

            }
            Console.ReadKey();
        }
    }
}
