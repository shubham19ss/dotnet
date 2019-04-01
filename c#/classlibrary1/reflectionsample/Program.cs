using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionsample
{
    class Program
    {
       
        static void Main(string[] args)
        {

            //reflectionsample.Class1.print();
            //Console.Read();
            if (Calculator<int>.compare(10, 10))
                Console.WriteLine("equal");
            Console.Read();
        }
        public void printMethod()
        {

        }
        public void gette()
        {

        }
        public void serrr()
        {

        }
        public void GetFullName(string str)
        {
            Console.WriteLine("{0}", str);
        }
    }
    public class Calculator<T>
    {
        public static bool compare(T x,T y)
        {
            return x.Equals(y);
        }
    }
}
