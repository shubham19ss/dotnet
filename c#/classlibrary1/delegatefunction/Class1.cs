using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatefunction
{
   
    class Employee
    {
        public delegate bool PromoteDelegate(Employee emp);
        public String salary { get; set; }
        public void promotion(List<Employee> emp,PromoteDelegate promotedelegate)
        { foreach(var e in emp)
            if(promotedelegate(e))
                {
                    Console.WriteLine("salary is {0}", e.salary);
                }
        }  

    }
}
