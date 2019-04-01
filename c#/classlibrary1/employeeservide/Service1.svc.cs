using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace employeeservide
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Employee GetEmployeeData(int id)
        { Employee emp = new Employee();
            SqlConnection con = new SqlConnection("Server=DESKTOP-SS5H7HT;DataBase=ncr;Uid=ncr;Password=pass1234;");
            string command = "fetchform";
            SqlCommand cmd = new SqlCommand(command, con);
            SqlParameter p1 = new SqlParameter("@Id",id);
            cmd.Parameters.Add(p1);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds!=null)
            {
                DataRow rowData = ds.Tables[0].Rows[0];
                if(rowData!=null)
                {
                    
                    emp.Id = (int)rowData["Id"];
                    emp.Name = (string)rowData["Name"];
                    emp.Gender = (string)rowData["gender"];
                   
                    
                }

            }
            return emp;
        }
    }
}
