using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
public class KETNOIDULIEU {
    SqlConnection con;
    public KETNOIDULIEU(String strPath)
    {
        con = new SqlConnection();
        con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+strPath+"bdQUANLYBANHANG.mdf;Integrated Security=True";
    }
    public void MoKetNoi(){
       
            if (con.State == ConnectionState.Closed)
                con.Open();     
       
    }
    public void DongKetNoi()
    {
        if (con.State == ConnectionState.Open)
            con.Close();
    }
    /// <summary>
    /// Thực thi SQL=select * from
    /// </summary>
    /// <param name="SQL"></param>
    /// <returns></returns>
    public DataTable GetBangDuLieu(String SQL) {
         DataTable tb = new DataTable();
        
          this.MoKetNoi();
        SqlDataAdapter adp = new SqlDataAdapter(SQL, this.con);      
        adp.Fill(tb);
        this.DongKetNoi();

        
        return tb;
    }
    /// <summary>
    /// Thực thi SQL=Insert into, Update, Delete, StoredProceuure
    /// </summary>
    /// <param name="SQL">String SQL</param>
    /// <returns></returns>
    public int ThucThiSQL(String SQL){
        this.MoKetNoi();
        SqlCommand cmd = new SqlCommand(SQL, this.con);
        int k = (int)cmd.ExecuteNonQuery();
        this.DongKetNoi();
        return k;
    }
    /// <summary>
    /// Thyuwcj thi SQL=Select Count(*) from 
    /// </summary>
    /// <param name="SQL"></param>
    /// <returns></returns>
    public object GetGiaTri(String SQL) {
        MoKetNoi();
        SqlCommand cmd = new SqlCommand(SQL, con);
        object Giatri = cmd.ExecuteScalar();
        DongKetNoi();
        return Giatri;
    }
}

