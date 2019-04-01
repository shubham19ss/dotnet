using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
     class program
    {
        static void main(string[] args)
        {
            inheritance.Employee emp = new inheritance.Employee();
            emp.full_name = "gaddam";
            emp.lastname = "maneesha";
            emp.email = "gaddammaneesha2@gmail.com";
            emp.print();
            inheritance.fulltime emp1 = new inheritance.fulltime();
            emp1.full_name = "abc";
            emp1.lastname = "def";
            emp1.email = "gaddammaneesha@gmail.com";
            emp1.print();
            inheritance.contract emp2 = new inheritance.contract();
            emp2.full_name = "pra";
            emp2.lastname = "mesh";
            emp2.email = "gaddamman@gmail.com";
            emp2.print();

        }
    }
    public class Employee
    { 
        public  string full_name;
        public   string email;
        public string lastname;
        public void print()
        {
            Console.WriteLine(full_name + lastname);
        }

    }
   public  class fulltime:Employee
    {
        public int year_sal;
    }
    public class contract : Employee
    {
        public int month_sal;
    }
   
       
       
    
}
