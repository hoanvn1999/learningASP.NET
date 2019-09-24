<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_QUANLY.master" AutoEventWireup="true" CodeFile="pageDANHMUC.aspx.cs" Inherits="pageDANHMUC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style4 {
        text-align: center;
    }
    .auto-style5 {
        text-align: center;
    }
    .auto-style7 {
        width: 142px;
        height: 26px;
    }
    .auto-style8 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
    <tr>
        <td colspan="2" style="text-align: center">QUẢN LÝ DANH MỤC</td>
    </tr>
    <tr>
        <td class="auto-style7">Mã danh mục</td>
        <td class="auto-style8">
            <asp:TextBox ID="txtMADM" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Tên danh mục</td>
        <td class="auto-style8">
            <asp:TextBox ID="txtTENDM" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="2">
            <asp:Button ID="btn_Them" runat="server" Text="Thêm mới" OnClick="btn_Them_Click" />
            <asp:Button ID="btn_XOA" runat="server" Text=" Xóa " OnClick="btn_XOA_Click" />
            <asp:Button ID="btn_Sua" runat="server" Text=" Sửa " OnClick="btn_Sua_Click" />
            <asp:Button ID="btn_Tim" runat="server" Text=" Tìm " />
        </td>
    </tr>
    <tr>
        <td class="auto-style5" colspan="2">
            <asp:GridView ID="grdDanhmuc" runat="server" Width="407px" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  PageSize="5" Height="75px" OnPageIndexChanging="grdDanhmuc_PageIndexChanging" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="MADM" HeaderText="Mã danh mục" />
                    <asp:BoundField DataField="TENDM" HeaderText="Tên danh mục" />
                    <asp:TemplateField HeaderText="Xóa">
                        <ItemTemplate>
                            <asp:CheckBox ID="ckb_XOA" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>

