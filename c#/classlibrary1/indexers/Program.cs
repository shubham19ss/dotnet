using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            indexers.sample s = new indexers.sample();
            Console.WriteLine(s[1]);
            Console.WriteLine(s[2]);
            Console.Read();
        }
    }
    public class employee
    {
        public int Id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
    }
    class sample
    {
        List<employee> list = new List<employee>();
        public sample()
        {
            list.Add(new indexers.employee { Id = 1, name = "shubham" });
            list.Add(new indexers.employee { Id = 2, name = "maneesha" });
            list.Add(new indexers.employee { Id = 2, name = "ram" });
        }
        public string this[int id]
        {
            get { return list.FirstOrDefault(emp => emp.Id == id).name; }
            set
            {
                list.FirstOrDefault(emp => emp.Id == id).name = value;
            }
        }
    }
}
