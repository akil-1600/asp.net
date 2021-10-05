using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int qty = Int32.Parse(TextBox1.Text);
        int rs = Int32.Parse(TextBox2.Text); ;
        int amount = qty * rs;
        int disc = 0;
        if (amount >= 0 && amount <= 500)
        {
            disc = 5;
        }
        else if (amount > 500 && amount <= 1000)
        {
            disc = 10;
        }
        else if (amount > 1000 && amount <= 2000)
        {
            disc = 15;
        }
        else
        {
            disc = 20;
        }
        float discount = amount * disc / 100;
        TextBox3.Text = discount.ToString();
        TextBox4.Text = (amount - discount).ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "0";
        TextBox2.Text = "0";
        TextBox3.Text = "0";
        TextBox4.Text = "0000";
    }
}
