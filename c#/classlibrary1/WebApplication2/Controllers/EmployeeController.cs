using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class EmployeeController : ApiController
    {

        public List<EmployeeList> Get()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            List<EmployeeList> list = new List<EmployeeList>();
            employee e = new employee();
            //dc.SubmitChanges();
            var ds = dc.employees;
            foreach (var da in ds)
            {
                list.Add(new EmployeeList(da.Id,da.Name,da.gender));
            }

            return list;
        }

    }
    public class EmployeeList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public EmployeeList(int i,string n,string g)
        {
            ID = i;
            Name = n;
            Gender = g;
        }
        
    }
}
