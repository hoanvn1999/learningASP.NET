using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageQUANLYSANPHAM : System.Web.UI.Page
{
    KETNOIDULIEU xuly;
    String SQL;
    public void LoadDanhMuc() {
        SQL = "select MADM,TENDM from tbDANHMUC ";
        this.drl_MaDM.DataSource = xuly.GetBangDuLieu(SQL);
        this.drl_MaDM.DataTextField = "TENDM";//Trường hiển thị
        this.drl_MaDM.DataValueField = "MADM";//Trường lấy dữ liệu
        this.drl_MaDM.DataBind();
    }
    public void LoadSanPham() {
        SQL = "select * from tbSANPHAM ";
        this.GridView1.DataSource = xuly.GetBangDuLieu(SQL);
        this.GridView1.DataBind();
    }
    public String FileUpload()  {
        String fileName = null;
        if(FileUpload1.HasFile)    {
            fileName = "\\IMAGES\\" + FileUpload1.FileName;           
            FileUpload1.PostedFile.SaveAs(Server.MapPath(fileName));
        }
        return fileName;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        String strPath = Server.MapPath("App_Data\\");
        xuly = new KETNOIDULIEU(strPath);
        LoadDanhMuc();
        LoadSanPham();
    }
    protected void btn_Them_Click(object sender, EventArgs e)
    {
        String file=FileUpload();
        SQL = " insert into tbSANPHAM(TENSP,DONGIA,SOLUONG,HINHANH,MOTA,MADM)"
            + " VALUES (N'" + txtTENSP.Text + "'," + txtGIABAN.Text + "," 
            + txtSOLUONG.Text + ",'" + file + "','" 
            + txtMOTA.Text + "'," + drl_MaDM.SelectedValue + ")";
        xuly.ThucThiSQL(SQL);
        LoadSanPham();
        
    }
    protected void btn_Xoa_Click(object sender, EventArgs e)
    {

    }
    protected void btnSua_Click(object sender, EventArgs e)
    {

    }
}