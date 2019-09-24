using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable tbKhoa = new DataTable();
        tbKhoa.Columns.Add("MaKH", typeof(int));
        tbKhoa.Columns.Add("TenKH", typeof(String));
        tbKhoa.Columns.Add("SDT", typeof(String));
        DataRow rowkhoa = tbKhoa.NewRow();
        rowkhoa[0] = 1;
        rowkhoa[1] = "Khoa CNTT";
        rowkhoa["SDT"] = "02361232";
        tbKhoa.Rows.Add(rowkhoa);
        for (int i = 0; i < tbKhoa.Rows.Count; i++)
            for (int j = 0; j < tbKhoa.Columns.Count; j++)
                Response.Write(tbKhoa.Rows[i][j].ToString()+"<br>");

        DataTable tbsv = new DataTable();
        tbsv.Columns.Add("MaSV", typeof(int));
        tbsv.Columns.Add("TenSV", typeof(String));
        tbsv.Columns.Add("MaKH", typeof(int));
        DataRow rowsv = tbsv.NewRow();
        rowsv["MaSV"] = 1;
        rowsv[1] = "Le Van A";
        rowsv[2] = 1;
        tbsv.Rows.Add(rowsv);
         
        DataSet ds = new DataSet();
        ds.Tables.Add(tbKhoa);
        ds.Tables.Add(tbsv);

        DataRelation relation = new DataRelation("Khoa-SV",
            ds.Tables[0].Columns["MaKH"], ds.Tables[1].Columns["MaKH"]);
       
          ds.Relations.Add(relation);
        ds.Tables[1].DefaultView.RowFilter="MASV=1";
        this.GridView1.DataSource = ds.Tables[1].DefaultView.ToTable();
        this.GridView1.DataBind();

    }
}