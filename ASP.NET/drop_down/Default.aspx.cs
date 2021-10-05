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
        if (DropDownList1.SelectedIndex == 0)
        {
            Label1.Text = "Please Select Country...";
        }
        else
        {
            Label1.Text = DropDownList1.SelectedItem.ToString() + "<br>" + DropDownList1.SelectedIndex.ToString() + "<br>" + DropDownList1.SelectedValue.ToString();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
         
    }
}
