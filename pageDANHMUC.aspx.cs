using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pageDANHMUC : System.Web.UI.Page
{
    KETNOIDULIEU xuly;
    public void LoadDanhmuc()
    {
        String SQL = " select * from tbDanhmuc";
        this.grdDanhmuc.DataSource = xuly.GetBangDuLieu(SQL);
        this.grdDanhmuc.DataBind(); 
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        String strPath = Server.MapPath("App_Data\\");
        xuly = new KETNOIDULIEU(strPath);
        
       if(!IsPostBack)
        LoadDanhmuc();
    }
    protected void btn_Them_Click(object sender, EventArgs e)
    {
        string SQL = "insert into tbDANHMUC(TENDM) VALUES(N'" 
            + txtTENDM.Text + "')";
        xuly.ThucThiSQL(SQL);
        LoadDanhmuc();
    }
    protected void grdDanhmuc_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.grdDanhmuc.PageIndex = e.NewPageIndex;
        LoadDanhmuc();
    }
    protected void btn_XOA_Click(object sender, EventArgs e)
    {
       
           foreach(GridViewRow row in this.grdDanhmuc.Rows)
           {
               CheckBox ckb = (CheckBox)row.FindControl("ckb_XOA");
               if(ckb.Checked==true){
                   
                   string SQL = "delete from tbDANHMUC WHERE MADM=" 
                       + row.Cells[0].Text;
                   xuly.ThucThiSQL(SQL);
               }
           }
         
           LoadDanhmuc();
    }


    protected void btn_Sua_Click(object sender, EventArgs e)
    {

    }
    protected void grdDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void grdDanhmuc_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }
   
}