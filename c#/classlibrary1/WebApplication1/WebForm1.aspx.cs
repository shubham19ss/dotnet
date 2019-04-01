using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnres_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client s = new ServiceReference1.Service1Client();
            ServiceReference1.Employee emp = new ServiceReference1.Employee();
            emp=s.GetEmployeeData(int.Parse(eid.Text));
            ename.Text = emp.Name;
            egender.Text = emp.Gender;
        }
    }
}