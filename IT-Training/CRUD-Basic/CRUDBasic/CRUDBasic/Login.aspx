<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CRUDBasic.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Enter following details
    <hr />
        Username <asp:TextBox  ID="txtUserName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
        <br />
        Password <asp:TextBox  ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox><br />
        <asp:Button id ="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />


    </div>
    </form>
</body>
</html>
