using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace classlibrary1
{
    class Program
    {
        void print()
        {
            Console.WriteLine("cdac");
        }
        static void Main(string[] args)
        {
             ClassLibrary2.Class1.test();
            Console.WriteLine("training");
            printdata();                  //writeline->method
            Console.Read();

        }
        public static void printdata()
        {
            bool b = true;
            int days = 10;
            float c = 2.34f;
            int[] arr = new int[] { 1,2,3,4,5};
            
            int i;
            Console.WriteLine(b);
              //print blank
            Console.WriteLine(c);
            Console.WriteLine(days);
            Console.WriteLine("int max{0}", int.MaxValue);
            Console.WriteLine("int max{0}", int.MinValue);
            Console.WriteLine("int max{0}", days.GetType());
            Console.WriteLine("int max{0}", b.GetType());
            Console.WriteLine("int max{0}", c.GetType());
            //Console.WriteLine("int max{0}", i.GetType());
            
            foreach(var q in arr)
            {
                Console.WriteLine(q);
            }
        }
    }
}
