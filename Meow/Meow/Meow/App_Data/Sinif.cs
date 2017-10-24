using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Sinif
/// </summary>
public class Sinif
{
    public Sinif()
    {

        //
        // TODO: Add constructor logic here
        //
    }
    public SqlConnection baglan()
    {
        SqlConnection baglanti = new SqlConnection(@"Server =.; Database = Meowbook; Trusted_Connection = True;");
        baglanti.Open();
        return (baglanti);
    }
    public int cmd(string sqlCumle)
    {
        SqlConnection baglanti = this.baglan();
        SqlCommand cmd = new SqlCommand(sqlCumle, baglanti);
        int sonuc = 0;
        try
        {
            sonuc = cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {

             throw new Exception(ex.Message + "(" + sqlCumle + ")");
        }
        cmd.Dispose();
        baglanti.Close();
        baglanti.Dispose();
        return (sonuc);
    }
    public DataTable getDataTable(string sqlCumle)
    {
        SqlConnection baglanti = this.baglan();
        SqlDataAdapter dta = new SqlDataAdapter(sqlCumle,baglanti);
        DataTable dt = new DataTable();
        try
        {
            dta.Fill(dt);
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message + "(" + sqlCumle + ")");
        }
        dta.Dispose();
        baglanti.Close();
        baglanti.Dispose();
        return (dt);
    }
    public DataRow getDataRow(string sqlCumle)
    {
        DataTable dt = getDataTable(sqlCumle);
        if (dt.Rows.Count == 0)
        {
            return null;
        }
        else
        {
            return dt.Rows[0];
        }
    }
    public string getDataCell(string sqlCumle)
    {
        DataTable dt = getDataTable(sqlCumle);
        if (dt.Rows.Count == 0)
        {
            return null;
        }
        else
        {
            return dt.Rows[0][0].ToString();
        }

    }
}