<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PPMS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <script src="assets/js/jquery-1.10.2.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 0 auto;">
            <div class="container">
                <div class="alert alert-danger">
                    Provide valid user name and password
                </div>

                <div class="panel panel-info">
                    <div class="panel-heading">
                        Valid User name and passord
                    </div>
                    <div class="panel-body">
                        <table>
                            <tr>
                                <td>User Name</td>
                                <td>
                                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Password</td>
                                <td>
                                    <asp:TextBox ID="txtPassWord" TextMode="Password" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" CssClass="btn btn-primary" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>


            </div>
            Provide your details
    
        </div>
    </form>
</body>
</html>
