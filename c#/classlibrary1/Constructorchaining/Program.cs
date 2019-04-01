using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorchaining
{   
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.Read();
        }
    }
    public class Parent
    { public String s;
        public Parent()
        {
            Console.WriteLine("parent constructor");
        }
        public Parent(String z)
        {
            s = z;
            Console.WriteLine("child message {0}",s);
        }
    }
    public class Child :Parent
    {
        public Child():base("called from derived class")
        {
            Console.WriteLine("child constructor");
        }
    }


}
