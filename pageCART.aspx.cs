using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageCART : System.Web.UI.Page{
    CART cart;
    public void LoadCart(CART cart) {       
        this.grd_CART.DataSource = cart;
        this.grd_CART.DataBind();
        this.grd_CART.FooterRow.Cells[3].Text = "Tổng tiền";
        this.grd_CART.FooterRow.Cells[4].Text= cart.Total().ToString();
    }
    protected void Page_Load(object sender, EventArgs e) {
         if (Session["CART"] != null && !IsPostBack ) {
            cart = (CART)Session["CART"];
            LoadCart(cart);            
        }
    }   
    protected void btn_Xoa_Click(object sender, EventArgs e){
        cart = (CART)Session["CART"];
        foreach (GridViewRow row in this.grd_CART.Rows){
            CheckBox ckb = (CheckBox)row.FindControl("ckb_Delete");
            if (ckb.Checked == true) {
                cart.DeleteCart(row.Cells[0].Text);
            }
        }
        LoadCart(cart);
    }
}