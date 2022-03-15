<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="DemoApp1.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 55%;
            height: 114px;
            border-style: solid;
            border-width: 3px;
        }
        .auto-style2 {
            width: 255px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td class="auto-style2">Select Names</td>
                    <td>
                        <asp:DropDownList ID="ddlNames" runat="server" AutoPostBack="True" Height="98px" OnSelectedIndexChanged="ddlNames_SelectedIndexChanged" Width="199px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
