using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for CART
/// </summary>
public class CART:DataTable {
    DataColumn clMaSP, clTenSP, clSoluong, clDongia, clThanhTien, clHinhAnh,clDelete;
	public CART()
	{
        clMaSP = new DataColumn("MASP", typeof(int));
        clTenSP = new DataColumn("TENSP", typeof(string));
        clSoluong = new DataColumn("SOLUONG", typeof(int));
        clDongia = new DataColumn("DONGIA", typeof(double));
        clThanhTien = new DataColumn("THANHTIEN", typeof(double),"SOLUONG * DONGIA");
        clHinhAnh = new DataColumn("HINHANH", typeof(string));
        clDelete = new DataColumn("DELETE", typeof(Boolean));
       
        this.Columns.AddRange(new DataColumn[] { clMaSP, clTenSP, clSoluong, 
            clDongia, clThanhTien, clHinhAnh,clDelete });
	}
    public void AddCart(int masp, string tensp, int soluong, double dongia,
        string hinhanh)
    {
        bool found=false; 
        for(int i=0;i<this.Rows.Count &&!found;i++)
            {
                if(Convert.ToInt16(this.Rows[i]["MASP"].ToString())==masp)
                { 
              this.Rows[i]["SOLUONG"] = Convert.ToInt16(this.Rows[i]["SOLUONG"]) 
                + soluong;//cộng dồn số lượng
                 found=true;
                }
            }      
        if(!found){// không tìm thấy sản phẩm trong giỏ hàng
            DataRow row = this.NewRow();
            row[0] = masp;
            row[1] = tensp;
            row[2] = soluong;
            row[3] = dongia;
            row[4] = soluong * dongia;
            row[5] = hinhanh;
            row[6] = false;
            this.Rows.Add(row);
        }
    }
    public void DeleteCart(String masp) {
         bool found=false; 
         for(int i=0;i<this.Rows.Count &&!found;i++)  {
                if (this.Rows[i]["MASP"].ToString().Equals(masp))   {
                    this.Rows.RemoveAt(i);
                    found = true;
                }
        }
    }
    public double Total() {
        double tongtien = 0;
        for (int i = 0; i < this.Rows.Count; i++)  {
            tongtien +=Convert.ToDouble( this.Rows[i]["THANHTIEN"].ToString());
        }
        return tongtien;
    }
}