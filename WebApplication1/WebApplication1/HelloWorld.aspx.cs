using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void B_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello, the time is " + DateTime.Now.ToLongTimeString();
        }
    }
}