using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = interfacedemo;    //alias name for namespace 
namespace  interfacedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            A.interfacedemo1 obj = new A.interfacedemo1();
            ((A.icustomer)(obj)).print();
            ((A.icustomer1)(obj)).print();
            Console.Read();
        }
    }
   
   public  class interfacedemo1:icustomer,icustomer1
    {
        void icustomer.print()
        {
            Console.WriteLine("interface1 ");
        }
        void icustomer1.print()
        {
            Console.WriteLine("interface2 ");
        }
    }
    interface icustomer
    {
        void print();
    }
    interface icustomer1
    {
        void print();
    }
}
