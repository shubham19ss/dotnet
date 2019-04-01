using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace time
{
    class Program
    {
        static void Main(string[] args)
        {
            times t = new time.times();
            t.hours = 20;
            Console.WriteLine(t.hours);
            Console.Read();
        }
    }
    class times
    {
        private double sec;
        public double hours
        {
            get { return sec/3600; }
            set
            {
                if(value<0||value>24)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)}must be between 0 and 24");
                }
                sec= value;
            }
        }
    }
}
