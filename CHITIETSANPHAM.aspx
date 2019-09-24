<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_USER.master" AutoEventWireup="true" CodeFile="CHITIETSANPHAM.aspx.cs" Inherits="CHITIETSANPHAM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
             <table style="width:100%;" border="1">
            <tr>
                <td rowspan="4" style="vertical-align: top"> 
                    <img src="<%# Eval("HINHANH") %>" width="100%" height="200%"></td>
                <td style="vertical-align: top"><h3><%# Eval("TENSP") %>"</h3></td>
            </tr>
            <tr>
                <td style="vertical-align: top"><h3><%# Eval("DONGIA") %>"<h3></td>
            </tr>
            <tr>
                <td style="vertical-align: top"><%# Eval("MOTA") %>"</td>
            </tr>
            <tr>
                <td style="vertical-align: top">
                  
                </td>
            </tr>
        </table> 
            </ItemTemplate>           
    </asp:Repeater>  
    <br>
    <asp:DropDownList ID="drl_SOLUONG" runat="server" Height="16px" Width="86px" >
    </asp:DropDownList>
      <asp:Button ID="btn_CART" runat="server" Text="Giỏ hàng" OnClick="btn_CART_Click" />
</asp:Content>

