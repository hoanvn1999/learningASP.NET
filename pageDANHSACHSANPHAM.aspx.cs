using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class pageDANHSACHSANPHAM : System.Web.UI.Page
{
    SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        String strPath = Server.MapPath("App_Data\\");
        con = new SqlConnection();
        con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="
            + strPath + "bdQUANLYBANHANG.mdf;Integrated Security=True";
        String SQL = "select top(10) * from tbSANPHAM ";
        string MADM = Request.QueryString.Get("MADM");
        if (MADM != null)
        {
            SQL += " where MADM=" + MADM;

        }
        con.Open();
        SqlDataAdapter ADP = new SqlDataAdapter(SQL, con);
        DataTable tbSANPHAM = new DataTable();
        ADP.Fill(tbSANPHAM);
        this.DataList1.DataSource = tbSANPHAM;
        this.DataList1.DataBind();
        con.Close();
    }
}