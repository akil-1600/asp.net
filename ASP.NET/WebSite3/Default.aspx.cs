using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Cookies["uname"].Value = TextBox1.Text;
        Label2.Text = "cookies succesfully created...";
        TextBox1.Text = "";


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["uname"] == null)
        {
            Label3.Text = "cookies not found...";
            TextBox2.Text = "cookies not found...";
           /* TextBox2.Text = "";
            Label3.Text = "";*/
        }
        else
        {
            TextBox2.Text = Request.Cookies["uname"].Value;
            Label3.Text = "cookies succesfully retrived...";

        }
            
        
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
}
