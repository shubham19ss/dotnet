using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client a = new ServiceReference1.Service1Client();
            Console.WriteLine(a.GetData(10));
            Console.Read();

        }
    }
}
