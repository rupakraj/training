<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewStudent.aspx.cs" Inherits="CRUDBasic.NewStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                Name
            </td>
            <td>
                <asp:TextBox ID ="txtName" runat="server" required ="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Address
            </td>
            <td>
                <asp:TextBox ID ="txtAddress" runat="server" required ="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                RollNo
            </td>
            <td>
                <asp:TextBox TextMode="Number"  ID ="txtRollNo" runat="server" required ="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <div style ="float:right;">
                    <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" />
                </div>

            </td>
        </tr>
         
    </table>
    </div>
    </form>
</body>
</html>
