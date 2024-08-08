using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HTMLControl2 : System.Web.UI.Page
    {
        public void Page_Load(object s, EventArgs e)
        {
            // The value of text1 is set upon the first call to the page.  
            // Thereafter, the state is retained, unless changed by user.
            if (Page.IsPostBack)
            {
            }
            else
            {
                text1.Value = "abc";
            }
            Response.Write("In Page_Load, Page.IsPostBack = " + Page.IsPostBack + "<br>");
        }

        // This input text control event will be called only when the button is clicked
        public void text1_Change(object sender, System.EventArgs e)
        {
            Response.Write("In text1_Change, text1.Value = " + text1.Value + "<br>");
        }

        public void checkbox1_Change(object sender, System.EventArgs e)
        {
            Response.Write("In checkbox1_Change, checkbox1.Checked = " + checkbox1.Checked + "<br>");
        }

        public void radio_Change(object sender, System.EventArgs e)
        {
            HtmlInputRadioButton radio = (HtmlInputRadioButton)sender;
            Response.Write("In radio_Change, " + radio.ID + ".Checked = " + radio.Checked + "<br>");
        }

        public void select1_Change(object sender, System.EventArgs e)
        {
            Response.Write("In select1_Change, select1.Value = " + select1.Value + "<br>");
        }

        // This button control event will be called when the button is clicked
        public void button1_Click(object sender, System.EventArgs e)
        {
            Response.Write("In button1_Click, checkbox1.Checked = " + checkbox1.Checked + "<br>");
            div1.InnerText = "Hello, the time is now " + DateTime.Now.ToLongTimeString();
        }
    }
}