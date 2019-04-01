using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrial_calss
{
    class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            d.print();
        }
    }
    public partial class demo
    {
        private int id=2;
        partial void method();
        public void print()
        {
            method();
        }
    }
}
