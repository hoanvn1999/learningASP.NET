<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_QUANLY.master" AutoEventWireup="true" CodeFile="pageQUANLYSANPHAM.aspx.cs" Inherits="pageQUANLYSANPHAM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td colspan="2" style="text-align: center">QUẢN LÝ SẢN PHẨM</td>
        </tr>
        <tr>
            <td class="auto-style5">Danh mục</td>
            <td>
                <asp:DropDownList ID="drl_MaDM" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Mã Sản Phẩm</td>
            <td>
                <asp:TextBox ID="txtMASP" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Tên sản phẩm</td>
            <td>
                <asp:TextBox ID="txtTENSP" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Số lượng</td>
            <td>
                <asp:TextBox ID="txtSOLUONG" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Giá bán</td>
            <td>
                <asp:TextBox ID="txtGIABAN" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Ảnh mặt hàng</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">MÔ TẢ</td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">
                <asp:TextBox ID="txtMOTA" runat="server" Height="52px" TextMode="MultiLine" Width="365px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">
                <asp:GridView ID="GridView1" runat="server" Width="465px" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="MADM" HeaderText="Mã danh mục" />
                        <asp:BoundField DataField="TENSP" HeaderText="Tên sản phẩm" />
                        <asp:ImageField DataImageUrlField="HINHANH" HeaderText="Ảnh">
                            <ControlStyle Height="50px" Width="50px" />
                        </asp:ImageField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">
                <asp:Button ID="btn_Them" runat="server" Text="Thêm mới" OnClick="btn_Them_Click" /> 
                &nbsp;&nbsp;<asp:Button ID="btn_Xoa" runat="server" Text="Xóa" />
                &nbsp;&nbsp;<asp:Button ID="btnSua" runat="server" Text="Sửa" />
            &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

