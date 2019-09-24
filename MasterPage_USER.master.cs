using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class MasterPage_USER : System.Web.UI.MasterPage
{
    KETNOIDULIEU XULY;
    protected void Page_Load(object sender, EventArgs e){
        String strPath = Server.MapPath("App_Data\\");
        XULY = new KETNOIDULIEU(strPath); 

        String SQL = "select * from tbDANHMUC";
        this.Repeater1.DataSource = XULY.GetBangDuLieu(SQL);
        this.Repeater1.DataBind();

          HttpCookie CookieUser =Request.Cookies["USERNAMR"];
        HttpCookie CookiePass =Request.Cookies["PASSWORD"];
        if (CookiePass != null && CookieUser != null)
        {
            loginUser.Visible = false;//Đối tượng logi ẩn
        }
       
    }
    protected void loginUser_Authenticate(object sender, AuthenticateEventArgs e)
    {
        try{

             String SQL = "select * from tbLOGIN WHERE USERNAME='"
            + loginUser.UserName + "' AND PASSWORD='" + loginUser.Password + "'";
        DataTable tbLogin = XULY.GetBangDuLieu(SQL);
        if(tbLogin.Rows.Count>0)
        {
            HttpCookie CookieUser = new HttpCookie("USERNAMR", loginUser.UserName);
            HttpCookie CookiePass = new HttpCookie("PASSWORD", loginUser.Password);
            Response.Cookies.Add(CookieUser);
            Response.Cookies.Add(CookiePass);
            loginUser.Visible = false;//Đối tượng logi ẩn
        }
        }
        catch(Exception ex)
        {}
       

    }
}
