<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntry.aspx.cs" Inherits="TagTest2.StudentEntry" %>

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
                <td>ID</td>
                <td><asp:TextBox ID="txtID" runat="server"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>Name</td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblClass" Text="Class" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlClass" runat="server">
                        <asp:ListItem Value="1">ONE</asp:ListItem>
                        <asp:ListItem Value="2">TWO</asp:ListItem>
                        <asp:ListItem Value="3">THEEE</asp:ListItem>
                        <asp:ListItem Value="4">FOUR</asp:ListItem>
                        <asp:ListItem Value="5">FIVE</asp:ListItem>
                    </asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td>
                    Gender
                </td>
                <td>
                    <asp:RadioButton ID="rdoMale" runat="server"  Text="Male" GroupName ="gener"/>
                    <asp:RadioButton ID="rdoFeMale" runat="server"  Text="Female" GroupName="gener"/>
                </td>
            </tr>
            <tr>
                <td>

                </td>
                <td>
                    <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
