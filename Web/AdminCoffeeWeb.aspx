<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCoffeeWeb.aspx.cs" Inherits="Web.AdminCoffeeWeb" %>

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
                        <asp:Label ID="Label1" runat="server" Text="Kategori Id:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_CategoryId" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Kahve Adi:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_Name" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                   <td>
                        <asp:Label ID="Label3" runat="server" Text="Fiyatı:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_UnitPrice" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                   <td>
                        <asp:Label ID="Label4" runat="server" Text="Stoktaki Adedi:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_UnitsInStock" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btn_Add" runat="server" Text="Ekle" OnClick="btn_Add_Click" /></td>
                </tr>

            </table>

             <table>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
             </table>



             <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Kahve Id:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_UpdatedCoffeeId" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>

                 <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Kategori Id:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_UpdatedCategoryId" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Kahve Adi:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_UpdatedName" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                   <td>
                        <asp:Label ID="Label8" runat="server" Text="Fiyatı:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_UpdatedUnitPrice" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                   <td>
                        <asp:Label ID="Label9" runat="server" Text="Stoktaki Adedi:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_UpdatedUnitsInStock" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btn_Update" runat="server" Text="Güncelle" /></td>
                </tr>

            </table>

            <table>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
             </table>
            
            <table style="width: 100%;">
                    <tr>
                        <td>
                        <asp:Label ID="Label5" runat="server" Text="Kahve Id:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_DeletedCoffeeId" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btn_Delete" runat="server" Text="Delete"  /></td>
                    </tr>
                    
            </table>

        </div>
    </form>
</body>
</html>
