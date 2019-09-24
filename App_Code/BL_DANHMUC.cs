using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 using System.Web.UI;
using System.Web.UI.WebControls;
/// <summary>
/// Summary description for BL_DANHMUC
/// </summary>
public class BL_DANHMUC
{
    DA_DANHMUC da_danhmuc;
    Page gui_DanhMuc;
    String strPath;
	public BL_DANHMUC(Page P)
	{
      
        gui_DanhMuc = P;
        strPath = P.Server.MapPath("~\\App_Data\\");
        da_danhmuc = new DA_DANHMUC(this.strPath);
	}
    public void LoadDanhMuc(){
       
        ((GridView)this.gui_DanhMuc.FindControl("grd_Danhmuc")).DataSource = 
            da_danhmuc.BangDanhmuc(null);
        ((GridView)this.gui_DanhMuc.FindControl("grd_Danhmuc")).DataBind();
    }
    public int ThemmoiDanhMuc() { 
        TextBox txtTenDM =(TextBox)this.gui_DanhMuc.FindControl("txt_Tendanhmuc");        
        return da_danhmuc.ThemDanhmuc(txtTenDM.Text);
    }
    public int XoaDanhMuc()
    {
        TextBox txtMaDM= (TextBox)this.gui_DanhMuc.FindControl("txt_MADM");
        return da_danhmuc.XoaDanhmuc(txtMaDM.Text);
    }
}