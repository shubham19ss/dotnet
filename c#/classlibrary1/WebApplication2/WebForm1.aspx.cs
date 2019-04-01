using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net.Http;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public object Client { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnget_Click(object sender, EventArgs e)
        {
            using (HttpClient hc = new HttpClient())
            {
                var response = hc.GetAsync("http://localhost:62697/api/Employee");
                response.Wait();
                var result = response.Result.Content.ReadAsStringAsync();
                L1.Text = result.ToString();

            }
        }
    }
}