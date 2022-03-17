<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployDemo.aspx.cs" Inherits="EfExample.EmployDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            border-style: solid;
            border-width: 2px;
        }
        .auto-style2 {
            width: 191px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td class="auto-style2">Employ No</td>
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
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnAddEmploy" runat="server" OnClick="btnAddEmploy_Click" Text="Add Employ" Width="103px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSearchEmploy" runat="server" OnClick="btnSearchEmploy_Click" Text="Search Employ" Width="197px" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
