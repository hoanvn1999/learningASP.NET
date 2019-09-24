using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GUI_GUI_DANGMUC : System.Web.UI.Page
{
    BL_DANHMUC NV;
    protected void Page_Load(object sender, EventArgs e)
    {
       
         NV = new BL_DANHMUC( this);
        NV.LoadDanhMuc();
    }
    protected void btnLuu_Click(object sender, EventArgs e)
    {
        NV.ThemmoiDanhMuc();
        NV.LoadDanhMuc();

    }
    protected void btn_Xoa_Click(object sender, EventArgs e)
    {
        NV.XoaDanhMuc();
        NV.LoadDanhMuc();

    }
}