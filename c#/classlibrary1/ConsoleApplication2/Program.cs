using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleApplication2.Employee emp = new ConsoleApplication2.fulltime();
            emp.full_name = "gaddam";
            emp.lastname = "maneesha";
            emp.email = "gaddammaneesha2@gmail.com";
              emp.print();
            ConsoleApplication2.fulltime emp1 = new ConsoleApplication2.fulltime();
            emp1.full_name = "abc";
            emp1.lastname = "def";
            emp1.email = "gaddammaneesha@gmail.com";
            emp1.print();
            ConsoleApplication2.contract emp2 = new ConsoleApplication2.contract();
            emp2.full_name = "pra";
            emp2.lastname = "mesh";
            emp2.email = "gaddamman@gmail.com";
            emp2.print();
            Console.Read();
        }
    }
    public class Employee
    {
        public string full_name;
        public string email;
        public string lastname;
        public void print()
        {
            Console.WriteLine(full_name + lastname);
        }

    }
    public class fulltime : Employee
    {
        public int year_sal;
        public new void print()
        {
            Console.WriteLine("fulltime:{0}",full_name + lastname);
        }
    }
    public class contract : Employee
    {
        public int month_sal;
    }




}
