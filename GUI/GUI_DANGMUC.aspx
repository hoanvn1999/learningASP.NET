<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GUI_DANGMUC.aspx.cs" Inherits="GUI_GUI_DANGMUC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%;">
            <tr>
                <td>Tên Danh Mục</td>
                <td>
                    <asp:TextBox ID="txt_Tendanhmuc" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Mã danh mục</td>
                <td>
                    <asp:TextBox ID="txt_MADM" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnLuu" runat="server" OnClick="btnLuu_Click" Text="Thêm" />
                    <asp:Button ID="btn_Xoa" runat="server" OnClick="btn_Xoa_Click" Text="Xóa" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
    
        <asp:GridView ID="grd_Danhmuc" runat="server">
        </asp:GridView>
    
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
