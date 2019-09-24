<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_USER.master" AutoEventWireup="true" CodeFile="pageCART.aspx.cs" Inherits="pageCART" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="grd_CART" runat="server" AutoGenerateColumns="False" Width="570px" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" ShowFooter="True">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="MASP" HeaderText="Mã Sản phẩm" />
            <asp:BoundField DataField="TENSP" HeaderText="TÊN SẢN PHẨM" />
            <asp:BoundField DataField="SOLUONG" HeaderText="SỐ LƯỢNG" />
            <asp:BoundField DataField="DONGIA" HeaderText="ĐƠN GIÁ" />
            <asp:BoundField DataField="THANHTIEN" HeaderText="THÀNH TIỀN" />
            <asp:ImageField DataImageUrlField="HINHANH" HeaderText="ẢNH">
                <ControlStyle Height="50px" Width="50px" />
            </asp:ImageField>
           
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:CheckBox ID="ckb_Delete" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
           
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>
  
    <asp:Button ID="btn_Xoa" runat="server" Text="Xóa giỏ hàng" OnClick="btn_Xoa_Click"  />
</asp:Content>

