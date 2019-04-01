using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public
            int x;
        String s;
        Program(int a,String b)
        {
            x = a;
            s = b;
        }
        void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(s);
        }
        void print1(ref int a)
        {
            a = 25;
        }
      public static int add(int x,int y,params int[] valueset)
        {
          if(valueset!=null)
            {
                foreach (var a in valueset)
                    Console.WriteLine(a);
       
            }
            return x + y;
        }
        public static int sub(int x,int y=3,int z=5)
        {
            return x - y-z;
        }
        static void Main(string[] args)
        {
            Program obj=new ConsoleApplication1.Program(20,"manee");
            obj.print();
            int z = 5;
            Console.WriteLine(z);
            obj.print1(ref z);
            Console.WriteLine(z);
            int a;
            int b = add(10, 20,30,40,50);
            Console.WriteLine(b);
            int d=sub(5,z:2);
            Console.WriteLine(d);
            Console.Read();
        }
       
    }
}
