using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie mycookie = Request.Cookies["userinfo"];
        if (mycookie != null)
        {
            TextBox1.Text = mycookie["name"];
            TextBox2.Text = mycookie["pass"];
        }
        else
        {
            TextBox1.Text = "Cookie Not Found...";
            TextBox2.Text = "Cookie Not Found...";
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
