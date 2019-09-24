using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
public partial class pageDANGKYTHANHVIEN : System.Web.UI.Page
{
    KETNOIDULIEU ketnoi;
    protected void GETTINHTHANH() {
      string sql = "SELECT * FROM tbTTP";
      drl_TinhThanhpho.DataSource = ketnoi.GetBangDuLieu(sql);     
        drl_TinhThanhpho.DataTextField = "TENTTP";
        drl_TinhThanhpho.DataValueField = "MATTP";
        drl_TinhThanhpho.DataBind();
        drl_TinhThanhpho.SelectedIndex = 0;
        GetQUANHUYEN(drl_TinhThanhpho.SelectedValue);
    }
    public void GetQUANHUYEN(String MaTTP) {       
        String SQL = "select * from tbQH where MATTP='" + MaTTP + "'";
        drl_QuanHuyen.DataSource =ketnoi.GetBangDuLieu(SQL);
        drl_QuanHuyen.DataTextField = "TENQH";
        drl_QuanHuyen.DataValueField = "MAQH";
        drl_QuanHuyen.DataBind();
     }
    protected void Page_Load(object sender, EventArgs e){
        
      

        if (!IsPostBack)
        {
            GETTINHTHANH();

            DateTime nam = DateTime.Today.AddYears(-120);
            for (int i = 1; i <= 120; i++)
                this.drp_Nam.Items.Add(nam.AddYears(i).Year.ToString());
        }
      

    }
    protected void drl_TinhThanhpho_SelectedIndexChanged(object sender, EventArgs e)
    {
        String MaTTP = drl_TinhThanhpho.SelectedValue;//lấy MaTTP được chọn
        GetQUANHUYEN(MaTTP);
    }

    protected void btn_Dangky_Click(object sender, EventArgs e)
    {
       
        // Chèn dữ liệu vào bảng tbLOGIN
         String SQL = "insert into tbLOGIN(USERNAME,PASSWORD) "
             + " VALUES('" + txtEmail.Text + "','" + txtMatkhau.Text + "')";
         ketnoi.ThucThiSQL(SQL);
      //  Lấy giá trị ID vừa mới chèn từ lệnh trên của bảng tbLOGIN
         SQL = " select @@IDENTITY from tblogin";
         object ID = ketnoi.GetGiaTri(SQL);
        //  chèn dữ liệu vào bảng tbUSER
         String gioitinh="Nam";
         if (!rbl_Gioitinh.Items[0].Selected)
             gioitinh = "Nư";
         SQL = "insert into tbUSER(ID,HOTEN,NGAY,THANG,NAM,GIOITINH,DIACHI,"
             + " EMAIL,SODIENTHOAI,MAQH)"
             + " VALUES (" + ID + ",'" + txtHoten.Text + "'," 
             + drp_Ngay.SelectedItem.Text + "," 
             + drp_Thang.SelectedItem.Text + "," 
             + drp_Nam.SelectedItem.Text + ",'" 
             + gioitinh + "','"
             + txtDiachi.Text+"','"+txtEmail.Text+"','"
             + txtSodienthoai.Text+"','"
             + drl_QuanHuyen.SelectedValue + "')";
         ketnoi.ThucThiSQL(SQL);
    }
}