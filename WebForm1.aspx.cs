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
        int cnt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cnt = 1;

                Label1.Text = cnt.ToString();
                ViewState["x"] = cnt;
            }
           


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cnt = (int)ViewState["x"];

            cnt = cnt + 1;
            Label1.Text = cnt.ToString();
            ViewState["x"] = cnt;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx?id=" + Label1.Text);
        }
    }
}