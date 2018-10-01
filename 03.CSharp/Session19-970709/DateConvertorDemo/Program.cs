using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConvertorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("PersianDate:");
                var persianDate = Console.ReadLine();
                var gregorianDate = ConvertFromPersianDate(persianDate);
                Console.WriteLine($"GregorianDate:{gregorianDate.ToString("yyyy/MM/dd")}");
                Console.ReadKey();
            }
        }

        static DateTime ConvertFromPersianDate(string persianDate)
        {
            var dateParts = persianDate.Split('/');
            var year = int.Parse(dateParts[0]);
            var month = int.Parse(dateParts[1]);
            var day = int.Parse(dateParts[2]);

            PersianCalendar pc = new PersianCalendar();
            return pc.ToDateTime(year, month, day, 0, 0, 0, 0);

        }
    }
}
