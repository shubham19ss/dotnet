using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqIntroMethod();
        }
        public static void LinqIntroMethod()
        {
            string path = @"C:\Windows";
            DirectoryInfo info = new DirectoryInfo(path);
            FileInfo[] files = info.GetFiles();
            // var result = files.OrderByDescending(file => files.Length).Take(5);
            var result = (from file in files orderby file.Length descending select file).Take(10);
            foreach(var res in result)
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
