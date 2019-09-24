using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for DA_DANHMUC
/// </summary>
public class DA_DANHMUC {
    KETNOIDULIEU xuly;
	public DA_DANHMUC(String strPath){
        xuly = new KETNOIDULIEU(strPath);
 
	}
    public DataTable BangDanhmuc(String param) {
         string SQL= "Select * from tbDANHMUC ";
        if(param!=null)
         SQL += " where MADM="+param;
       return xuly.GetBangDuLieu(SQL);
    }
    public int ThemDanhmuc(String param) {
        String SQL = " Insert into tbDanhMuc(TenDM) values (N'" +param + "')";
        return (int)xuly.ThucThiSQL(SQL);
    }
    public int XoaDanhmuc(String param) {
        String SQL = " Delete from tbDanhMuc where MADM='" + param + "'";
        return (int)xuly.ThucThiSQL(SQL);
    }
    public int SuaDanhmuc(String TenDM,String MaDM){
        String SQL = " Update  tbDanhMuc set TenDM=N'" + TenDM + "'  where MADM="+MaDM;
        return (int)xuly.ThucThiSQL(SQL);
    }

}