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

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        HttpCookie mycookie = new HttpCookie("userinfo");
        mycookie["name"] = TextBox1.Text;
        mycookie["pass"] = TextBox2.Text;
        Response.Cookies.Add(mycookie);
        TextBox1.Text="";
        TextBox2.Text="";
        Response.Redirect("Default4.aspx");


    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
