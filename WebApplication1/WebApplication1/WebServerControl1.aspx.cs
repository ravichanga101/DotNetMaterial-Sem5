using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebServerControl1 : System.Web.UI.Page
    {
        public void Page_Init(object s, EventArgs e)
        {
            Response.Write("In Page_Init<br>");
        }

        public void Page_Unload(object s, EventArgs e)
        {
            // The following line causes an error if uncommented
            //Response.Write("In Page_Unload<br>");
        }

        public void Page_Load(object s, EventArgs e)
        {
            // The value of text1 is set upon the first call to the page.  
            // Thereafter, the state is retained, unless changed by user.
            if (Page.IsPostBack)
            {
            }
            else
            {
                text1.Text = "abc";
            }
            Response.Write("In Page_Load, Page.IsPostBack = " + Page.IsPostBack + "<br>");
        }

        // This input text control event will be called only when the button is clicked
        public void text1_TextChanged(object sender, System.EventArgs e)
        {
            Response.Write("In text1_TextChanged, text1.Text = " + text1.Text + "<br>");
        }

        public void checkbox1_CheckedChanged(object sender, System.EventArgs e)
        {
            Response.Write("In checkbox1_CheckedChanged, checkbox1.Checked = " + checkbox1.Checked + "<br>");
        }

        public void radio_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            Response.Write("In radio_CheckedChanged, " + radio.ID + ".Checked = " + radio.Checked + "<br>");
        }

        public void dropdown1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Response.Write("In dropdown1_SelectedIndexChanged, dropdown1.SelectedItem.Text = " + dropdown1.SelectedItem.Text + "<br>");
        }

        public void listbox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Response.Write("In listbox1_SelectedIndexChanged, listbox1.SelectedItem.Text = " + listbox1.SelectedItem.Text + "<br>");
        }

        public void listbox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string s = "In listbox2_SelectedIndexChanged, listbox2.SelectedItems: ";
            foreach (ListItem li in listbox2.Items)
            {
                if (li.Selected)
                    s += li.Text + "(" + li.Value + ") ";
            }
            s += "<br>";
            Response.Write(s);
        }

        public void checkboxlist1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string s = "In checkboxlist1_SelectedIndexChanged, checkboxlist1.SelectedItems: ";
            foreach (ListItem li in checkboxlist1.Items)
            {
                if (li.Selected)
                    s += li.Text + "(" + li.Value + ") ";
            }
            s += "<br>";
            Response.Write(s);
        }

        public void radiobuttonlist1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Response.Write("In radiobuttonlist1_SelectedIndexChanged, radiobuttonlist1.SelectedItem.Text = " + radiobuttonlist1.SelectedItem.Text + "<br>");
        }

        // This button control event will be called when the button is clicked
        public void button1_Click(object sender, System.EventArgs e)
        {
            Response.Write("In button1_Click, checkbox1.Checked = " + checkbox1.Checked + "<br>");
            label1.Text = "Hello, the time is now " + DateTime.Now.ToLongTimeString();
        }
    }
}