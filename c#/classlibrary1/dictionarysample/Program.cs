using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionarysample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionarysample.LoadDictionary();
            Console.Read();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
    public class Dictionarysample
    {
        public static void LoadDictionary()
        {
            Customer c1 = new Customer { Id = 1, Name = "shubham" };
            Customer c2 = new Customer { Id = 2, Name = "singh" };
            Customer c3 = new Customer { Id = 3, Name = "ssss" };
            Dictionary<int, Customer> val = new Dictionary<int, Customer>();
            val.Add(c1.Id, c1);
            val.Add(c2.Id, c2);
            val.Add(c3.Id, c3);
       
            foreach(KeyValuePair<int,Customer> value in val)
            {
                Console.WriteLine("customer Id--{0} and Customer name--{1}", value.Key, value.Value.Name);
            }
            Console.WriteLine("only keys");
            foreach (int value in val.Keys)
                    Console.WriteLine("customer Id--{0}", value);
            
        }
    }
}
