<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 71%;
            height: 313px;
        }
        .style2
        {
            text-align: center;
        }
        .style3
        {
            text-align: right;
        }
        .style4
        {
            height: 86px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table align="center" bgcolor="Blue" class="style1">
        <tr>
            <td class="style4" colspan="2" style="text-align: center">
                <asp:Label ID="Label1" runat="server" BackColor="White" Font-Size="XX-Large" 
                    style="text-align: center" Text="Multiple Cookies Retrive Example In Asp.Net"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label2" runat="server" BackColor="White" Font-Size="X-Large" 
                    style="text-align: left" Text="Username:-"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Font-Size="X-Large" 
                    ontextchanged="TextBox1_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label3" runat="server" BackColor="White" Font-Size="X-Large" 
                    Text="Password:-"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Font-Size="X-Large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:Button ID="Button1" runat="server" BorderColor="White" Font-Size="X-Large" 
                    onclick="Button1_Click" style="text-align: center" Text="Delete" />
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
