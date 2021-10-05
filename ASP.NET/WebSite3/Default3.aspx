<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border-style: solid;
            border-width: 2px;
            background-color: #00FFFF;
        }
        .style2
        {
            text-align: center;
            height: 101px;
        }
        .style3
        {
            width: 36px;
        }
        .style4
        {
            height: 98px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style4" colspan="2" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" BackColor="Lime" Font-Size="XX-Large" 
                        Text="Multiple Cookies Example in Asp.Net..."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" BackColor="Lime" Font-Size="X-Large" 
                        Text="Username:-"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label3" runat="server" BackColor="Lime" Font-Size="X-Large" 
                        Text="Password:-"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    <asp:Button ID="Button3" runat="server" BackColor="Lime" Font-Size="X-Large" 
                        onclick="Button3_Click" Text="Go to Next Page -&gt;-&gt;" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
