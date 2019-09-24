<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_USER.master" AutoEventWireup="true" CodeFile="pageCHITIETSANPHAM.aspx.cs" Inherits="pageCHITIETSANPHAM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            width: 224px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <asp:Repeater ID="Repeater2" runat="server">
     <ItemTemplate>
           <table style="width:100%;" border="2">
        <tr>
            <td class="auto-style5" rowspan="4" style="text-align: center">
                <img src="<%# Eval("HINHANH")%>">
                </td>
            <td style="vertical-align: top; text-align: center">
               <H3> <%# Eval("TENSP")%></H3></td>
        </tr>
        <tr>
            <td style="text-align: left; vertical-align: top">
                 Đơn giá:<%# Eval("DONGIA")%>
                </td>
        </tr>
        <tr>
            <td>
                <%# Eval("MOTA")%>
                </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="drl_SOLUONG" runat="server">
                </asp:DropDownList>
                <asp:Button ID="btn_GIOHANG" runat="server" Text="Giỏ hàng" />
               
            </td>
        </tr>
    </table>
     </ItemTemplate>           
     
     </asp:Repeater>
</asp:Content>

