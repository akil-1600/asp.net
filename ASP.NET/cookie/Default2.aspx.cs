﻿using System;
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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["uname"] == null)
        {
            Label2.Text = "cookie not found...";

        }
        else
        {
            Label2.Text = Request.Cookies["uname"].Value;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Cookies["uname"].Expires = DateTime.Now.AddMinutes(-1);
        Response.Redirect("Default2.aspx");
    }
}
