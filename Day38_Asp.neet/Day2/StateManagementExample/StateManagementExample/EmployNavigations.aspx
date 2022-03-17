<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployNavigations.aspx.cs" Inherits="StateManagementExample.EmployNavigations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 55%;
            height: 268px;
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
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnFirst" runat="server" OnClick="btnFirst_Click" Text="First" />
&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnPrevious" runat="server" OnClick="btnPrevious_Click" Text="Previous" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnLast" runat="server" OnClick="btnLast_Click" Text="Last" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
