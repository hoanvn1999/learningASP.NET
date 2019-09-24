<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_USER.master" AutoEventWireup="true" CodeFile="pageDANGKYTHANHVIEN.aspx.cs" Inherits="pageDANGKYTHANHVIEN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style4 {
        width: 113px;
    }
    .auto-style5 {
        width: 113px;
        height: 23px;
    }
    .auto-style6 {
        height: 23px;
    }
        .auto-style7 {
        width: 113px;
        height: 26px;
    }
        .auto-style8 {
            height: 26px;
        }
    .auto-style9 {
        width: 202px;
    }
    .auto-style10 {
        height: 26px;
        width: 202px;
    }
    .auto-style11 {
        height: 23px;
        width: 202px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
    <tr>
        <td colspan="3" style="text-align: center">ĐĂNG KÝ THÀNH VIÊN&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">Địa chỉ Email</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtEmail" runat="server" Width="191px"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Nhập sai địa chỉ Email" ForeColor="#FF6699" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Mật khẩu</td>
        <td class="auto-style10">
            <asp:TextBox ID="txtMatkhau" runat="server" Width="189px"></asp:TextBox>
        </td>
        <td class="auto-style8">
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtMatkhau" ControlToValidate="txtNhaplaiMatkhau" ErrorMessage="Mật khẩu không khớp" ForeColor="#FF6666"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Nhập lại mật khẩu</td>
        <td class="auto-style10">
            <asp:TextBox ID="txtNhaplaiMatkhau" runat="server" Width="185px"></asp:TextBox>
        </td>
        <td class="auto-style8"></td>
    </tr>
    <tr>
        <td class="auto-style5">Họ tên</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtHoten" runat="server" Width="183px"></asp:TextBox>
        </td>
        <td class="auto-style6"></td>
    </tr>
    <tr>
        <td class="auto-style4">Ngày sinh</td>
        <td class="auto-style9">
            <asp:DropDownList ID="drp_Ngay" runat="server">
                <asp:ListItem>Ngày</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="drp_Thang" runat="server">
                <asp:ListItem>Tháng</asp:ListItem>
                <asp:ListItem Value="1"></asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="drp_Nam" runat="server">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">Giới Tính</td>
        <td class="auto-style9">
            <asp:RadioButtonList ID="rbl_Gioitinh" runat="server" Height="16px" RepeatDirection="Horizontal" Width="104px">
                <asp:ListItem Selected="True">Nam</asp:ListItem>
                <asp:ListItem>Nữ</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">Địa Chỉ</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtDiachi" runat="server" Width="185px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">Tỉnh/Thành phố</td>
        <td class="auto-style10">
            <asp:DropDownList ID="drl_TinhThanhpho" runat="server" OnSelectedIndexChanged="drl_TinhThanhpho_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td class="auto-style8"></td>
    </tr>
    <tr>
        <td class="auto-style4">Quận/Huyện</td>
        <td class="auto-style9">
            <asp:DropDownList ID="drl_QuanHuyen" runat="server">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">Số điện thoại</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtSodienthoai" runat="server" Width="183px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">Mã bảo vệ</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtHoten2" runat="server" Width="181px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style9">
            <asp:Button ID="btn_Dangky" runat="server" Text="Đăng ký" OnClick="btn_Dangky_Click"  />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

