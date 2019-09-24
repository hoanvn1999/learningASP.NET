using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class CHITIETSANPHAM : System.Web.UI.Page
{
    KETNOIDULIEU xuly;
    DataTable tbSANPHAM;
    protected void Page_Load(object sender, EventArgs e)
    {
        String strPath = Server.MapPath("App_Data\\");
        xuly = new KETNOIDULIEU(strPath);
      
        string MASP = Request.QueryString.Get("MASP");
        String SQL = "select * from tbSANPHAM WHERE MASP="+MASP;

        this.tbSANPHAM = xuly.GetBangDuLieu(SQL);     
     
        this.Repeater1.DataSource = tbSANPHAM;
        this.Repeater1.DataBind();

        int intSoluong = Convert.ToInt16(tbSANPHAM.Rows[0]["SOLUONG"]);
        for (int i = 1; i <= intSoluong; i++)
        {
            this.drl_SOLUONG.Items.Add(i.ToString());

        }    
    }
   
    protected void btn_CART_Click(object sender, EventArgs e)
    {
        HttpCookie CookieUser =Request.Cookies["USERNAMR"];
        HttpCookie CookiePass =Request.Cookies["PASSWORD"];
        if (CookiePass != null && CookieUser != null) {

            CART cart;
            Session.Timeout = 1;
            if (Session["CART"] != null){
                cart = (CART)Session["CART"];
            }
            else{
                cart = new CART();

            }
            cart.AddCart(Convert.ToInt16(tbSANPHAM.Rows[0]["MASP"].ToString()),
                   tbSANPHAM.Rows[0]["TENSP"].ToString(),
                   Convert.ToInt16(drl_SOLUONG.SelectedValue),
                   Convert.ToDouble(tbSANPHAM.Rows[0]["DONGIA"].ToString()),
                   tbSANPHAM.Rows[0]["HINHANH"].ToString());
            Session["CART"] = cart;
            Response.Redirect("pageCART.aspx");
        }
    }
}