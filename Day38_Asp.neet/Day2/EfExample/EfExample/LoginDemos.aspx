<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginDemos.aspx.cs" Inherits="EfExample.LoginDemos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            border-style: solid;
            border-width: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td>
                        <asp:Login ID="Login1" runat="server" BackColor="#FFFBD6" BorderColor="#FFDFAD" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="131px" OnAuthenticate="Login1_Authenticate" TextLayout="TextOnTop" Width="289px">
                            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                            <LoginButtonStyle BackColor="White" BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" />
                            <TextBoxStyle Font-Size="0.8em" />
                            <TitleTextStyle BackColor="#990000" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                        </asp:Login>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
