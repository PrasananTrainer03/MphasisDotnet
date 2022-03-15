<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployInsert.aspx.cs" Inherits="EmpSpExample.EmployInsert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 54%;
            height: 255px;
            border-style: solid;
            border-width: 3px;
        }
        .auto-style2 {
            width: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">Employ Number</td>
                    <td>
                        <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Employ Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Department</td>
                    <td>
                        <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Designation</td>
                    <td>
                        <asp:TextBox ID="txtDesig" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Basic</td>
                    <td>
                        <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" Width="100px" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
