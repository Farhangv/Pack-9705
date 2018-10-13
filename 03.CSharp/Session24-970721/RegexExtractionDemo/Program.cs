using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExtractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(re.IsMatch("09126785214"));
            WebClient client = new WebClient();
            var pageContent = client.DownloadString("https://stackoverflow.com/");
            using (StreamWriter sw = new StreamWriter("content.txt"))
            {
                sw.WriteLine(pageContent);
            }

            using (StreamWriter sw = new StreamWriter("links.txt"))
            {
                Regex re = new Regex("href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))");
                var matches = re.Matches(pageContent);
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Groups[1]);
                    sw.WriteLine(match.Groups[1]);
                }
            }
            client.DownloadFile("https://tpc.googlesyndication.com/simgad/12560694895221210840", "dl.jpg");
            Console.ReadKey();

        }
    }
}
