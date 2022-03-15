<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculation.aspx.cs" Inherits="DemoApp1.Calculation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 59%;
            height: 300px;
            border-style: solid;
            border-width: 3px;
        }
        .auto-style2 {
            width: 242px;
            height: 69px;
        }
        .auto-style3 {
            width: 242px;
            height: 49px;
        }
        .auto-style4 {
            height: 49px;
        }
        .auto-style6 {
            height: 54px;
        }
        .auto-style7 {
            height: 69px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="5" cellspacing="6" class="auto-style1">
                <tr>
                    <td class="auto-style2">First Number</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtFirstNumber" runat="server" Height="29px" Width="167px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstNumber" ErrorMessage="Please Enter First Number"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Second Number</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtSecondNumber" runat="server" Height="29px" Width="169px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSecondNumber" ErrorMessage="Please Enter Second Number"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Result</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtResult" runat="server" Height="37px" Width="174px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnSum" runat="server" OnClick="btnSum_Click" Text="Sum" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSub" runat="server" OnClick="btnSub_Click" Text="Sub" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnMult" runat="server" OnClick="btnMult_Click" Text="Mult" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
