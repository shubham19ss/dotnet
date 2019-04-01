using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            employee m = new employee();
            //m.Id = 10;
            //m.Name = "gunti";
            //m.gender = "FeMale";
            //dc.employees.InsertOnSubmit(m);
            //dc.SubmitChanges();
            var ds = dc.employees;



            //System.Data.Linq.Table<employee> t = dc.employees;
            foreach (var d in ds)
            {
                Console.WriteLine(d.Id);
                Console.WriteLine(d.Name);
                Console.WriteLine(d.gender);
            }

            Console.Read();
        }
    }
}
