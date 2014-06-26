<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Controls.aspx.cs" Inherits="TagTest2.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" >name</asp:TextBox>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Educated?" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender" />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Width="100px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="2">+2</asp:ListItem>
            <asp:ListItem Value="1">SLC</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblSelected" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
