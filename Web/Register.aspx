<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web.Register" %>

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
                        <asp:Label ID="Label1" runat="server" Text="Ad:"></asp:Label></td>
                    <td> <asp:TextBox ID="tbx_FirstName" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                   <td>
                        <asp:Label ID="Label2" runat="server" Text="Soyad:"></asp:Label></td>
                    <td> <asp:TextBox ID="tbx_LastName" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                      <asp:Label ID="Label3" runat="server" Text="Telefon Numarasi:"></asp:Label></td>
                    <td> <asp:TextBox ID="tbx_PhoneNumber" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                 <tr>
                 <td>
                    <asp:Label ID="Label5" runat="server" Text="Email:"></asp:Label></td>
                    <td> <asp:TextBox ID="tbx_Email" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                 <td>
                    <asp:Label ID="Label6" runat="server" Text="Şifre:"></asp:Label></td>
                    <td> <asp:TextBox ID="tbx_Password" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                 <tr>
                 <td>
                    <asp:Label ID="Label4" runat="server" Text="Adres:"></asp:Label></td>
                    <td> <asp:TextBox ID="tbx_Address" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="Btn_Register" runat="server" Text="Kaydol" OnClick="Btn_Register_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
