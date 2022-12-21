<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_Email" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td> <asp:Label ID="Label2" runat="server" Text="Şifre:"></asp:Label></td>
                    <td><asp:TextBox ID="tbx_Password" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_login" runat="server" Text="Giriş Yap" OnClick="btn_login_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
