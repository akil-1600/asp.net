<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 50%;
            border: 1px solid #000000;
            background-color: #FFFF00;
        }
        .style3
        {
            text-align: center;
            height: 42px;
            width: 493px;
        }
        .style4
        {
            text-align: center;
            height: 45px;
            width: 493px;
        }
        .style5
        {
            text-align: center;
            height: 58px;
            width: 493px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" bgcolor="Yellow" align="center">
            <tr>
                <td class="style3">
                    <asp:Label ID="Label1" runat="server" Text="Welcome To WebPage2" 
                        Font-Size="X-Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Delete Cookie" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
