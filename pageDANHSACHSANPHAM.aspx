<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_USER.master" AutoEventWireup="true" CodeFile="pageDANHSACHSANPHAM.aspx.cs" Inherits="pageDANHSACHSANPHAM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server"  RepeatColumns="5">
        <ItemTemplate>
            <div >
           <a href="CHITIETSANPHAM.aspx?MASP=<%# Eval("MASP") %>">
               <img src="<%# Eval("HINHANH") %>" width="100px" height="100px"/>
            </a> 
               <BR>
            Tên SP:<%# Eval("TENSP") %><BR>
            Đơn giá:<%# Eval("DONGIA") %></div>
                </ItemTemplate>
    </asp:DataList>
     
</asp:Content>

