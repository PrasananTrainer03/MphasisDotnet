<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCookie.aspx.cs" Inherits="StateManagementExample.AddCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            border-style: solid;
            border-width: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="3" cellspacing="4" class="auto-style1">
                <tr>
                    <td>
                        <asp:Button ID="btnAddCookie" runat="server" OnClick="btnAddCookie_Click" Text="Add Cookie" Width="149px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnReadCookie" runat="server" OnClick="btnReadCookie_Click" Text="Read Cookie" Width="114px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
