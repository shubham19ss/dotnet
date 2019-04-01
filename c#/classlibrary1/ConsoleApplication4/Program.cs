using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //DefferedExecution();
            //AggregateMethod();
            //employee();
            //Partitioning();
            //GroupingMethod();
            //ElementMethod();
            Quantifier();
            Console.Read();
        }
        public static void DefferedExecution()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var result = from num in numbers where num % 2 == 0 select num;
            numbers.Add(7);
            numbers.Add(8);
            foreach (var res in result)
                Console.WriteLine(res);
            Console.Read();
        }
        public static void AggregateMethod()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Min Number {0}", numbers.Min());
            Console.WriteLine("Max Number {0}", numbers.Max());
            Console.WriteLine("sum {0}", numbers.Sum());
            Console.WriteLine("count {0}", numbers.Count());
            Console.WriteLine("Average {0}", numbers.Average());
            Console.WriteLine("aggregate result {0}", numbers.Aggregate((a,b)=>a+b));
        }
        public static void employee()
        {
            List<Employee> employeelist = new List<Employee>();
            employeelist.Add(new Employee(1,"shubham"));
            employeelist.Add(new Employee(2, "singh"));
            employeelist.Add(new Employee(1, "niharika"));
            employeelist.Add(new Employee(4, "gunti"));

            var eset = employeelist.Where(emp => emp.Id == 1).Select(emp => new { Id = emp.Id, Name = emp.Name });
            foreach (var res in eset)
                Console.WriteLine(res);



        }
        public static void Partitioning()
        {
            List<string> strlist = new List<string>() {"one","two","three","Hi","four","five"};
            var takeList = strlist.Take(2);
            var skipList = strlist.Skip(2);
            var takewhilelist = strlist.TakeWhile(s => s.Length > 2);
            foreach (var res in takewhilelist)
                Console.WriteLine(res);
            foreach (var res in takeList)
                Console.WriteLine(res);
            foreach (var res in skipList)
                Console.WriteLine(res);


        }
        public static void GroupingMethod()
        {
            List<Employee> employeelist = new List<Employee>();
            employeelist.Add(new Employee(1, "shubham"));
            employeelist.Add(new Employee(2, "singh"));
            employeelist.Add(new Employee(1, "niharika"));
            employeelist.Add(new Employee(4, "gunti"));
            employeelist.Add(new Employee(4, "gunt"));
            employeelist.Add(new Employee(4, "gun"));
            var groupset = employeelist.GroupBy(emp => emp.Id);
            foreach (var group in groupset)
                Console.WriteLine("{0}-{1}", group.Key, group.Count());
        }
        public static void ElementMethod()
        {

            List<int> numbers = new List<int> {1,2,3,4,5,6 };
            Console.WriteLine("first element {0}", numbers.First());
            Console.WriteLine("first element {0}", numbers.FirstOrDefault());
            Console.WriteLine("first element {0}", numbers.ElementAt(1));
            Console.WriteLine("first element {0}", numbers.ElementAtOrDefault(1));
            //Console.WriteLine("first element {0}", numbers.Single());
           // Console.WriteLine("first element {0}", numbers.SingleOrDefault());
        }
        public static void Quantifier()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6,7 };
            if(numbers.All(x=>x<8))
            {
                Console.WriteLine("all elements are less than eight");
            }
            if(numbers.Any(x=>x>6))
            {
                Console.WriteLine("one or more elements greater than six");
            }
            if(numbers.Contains(3))
            {
                Console.WriteLine("contains 3");
            }

        }
    }
}
