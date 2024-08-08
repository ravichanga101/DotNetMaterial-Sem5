using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ValidationControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello, the time is now " + DateTime.Now.ToLongTimeString()
  + "<br>Page.IsValid = " + Page.IsValid;
        }
        void ServerValidate(object sender, ServerValidateEventArgs args)
        {
            int num = Int32.Parse(args.Value);
            if ((num % 2) == 0)
                args.IsValid = true;
            else
                args.IsValid = false;
        }
    }
}