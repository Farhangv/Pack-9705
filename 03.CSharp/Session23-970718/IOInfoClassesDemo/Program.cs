using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace IOInfoClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DriveInfo[] drives = DriveInfo.GetDrives();
            //for (int i = 0; i < drives.Length; i++)
            //{
            //    if(drives[i].IsReady)
            //        Console.WriteLine($"{i+1}.{drives[i].Name}({drives[i].VolumeLabel})-[{drives[i].DriveType}]\t{drives[i].AvailableFreeSpace/1024/1024/1024} GB / {drives[i].TotalSize/1024/1024/1024} GB");
            //    else
            //        Console.WriteLine($"{i+1}.{drives[i].Name}-[{drives[i].DriveType}]");
            //}

            //DirectoryInfo di = new DirectoryInfo(@"D:\");
            //DirectoryInfo[] subDirectories = di.GetDirectories();
            //foreach (var directory in subDirectories)
            //{
            //    Console.WriteLine($"{directory.Name}\t{directory.FullName}");
            //}

            //FileInfo[] fi = di.GetFiles();
            //foreach (var item in fi)
            //{
            //    Console.WriteLine($"{item.Name}");
            //}

            //DirectoryInfo di = new DirectoryInfo(@"D:\Development\Courses\CourseCodes\Pack-9705");
            //Console.WriteLine(di.Parent);

            //DirectoryInfo di = new DirectoryInfo(@"D:\");
            //Console.WriteLine(di.Parent);

            Process.Start(@"D:\EBooks\IllustratedCSharp7,5thEdition@farhangv_com.pdf");

            Console.ReadKey();
        }
    }
}
