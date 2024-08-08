using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HTMLControl1 : System.Web.UI.Page
    {


        public void Page_Init(object s, EventArgs e)
        {
            Response.Write("In Page_Init<br>");
        }

        public void Page_Load(object s, EventArgs e)
        {
            // The value of text1 is set upon the first call to the page.  
            // Thereafter, the state is retained, unless changed by user.
            if (Page.IsPostBack)
            {

                Response.Write("Page is postback");
            }
            else
            {
                text1.Value = "Page is Load";
            }
            Response.Write("In Page_Load, Page.IsPostBack = " + Page.IsPostBack + "<br>");
        }

        public void Page_Unload(object s, EventArgs e)
        {
            //  Response.Write("In Page_Unload<br>");  // Causes error
        }

        // This input text control event will be called only when the button is clicked
        public void text1_Change(object sender, System.EventArgs e)
        {
            Response.Write("In text1_Change<br>");
        }

        // This button control event will be called when the button is clicked
        public void button1_Click(object sender, System.EventArgs e)
        {
            Response.Write("In button1_Click<br>");
            div1.InnerText = "Hello, the time is now " + DateTime.Now.ToLongTimeString();
        }


    }
}