using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Meow.Models;

namespace Meow
{
    public partial class AdminPanelMesaj : System.Web.UI.Page
    {
        SqlConnection bag = new SqlConnection("Server=.;Database=MeowBook;Integrated Security=True");
        MeowbookEntities1 db = new MeowbookEntities1();
        Sinif klas = new Sinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            MesajGetir();
            MesajSayisi();
            UyeSayisi();
        }

        private void UyeSayisi()
        {
            SqlDataAdapter Uye = new SqlDataAdapter("Select UyeId  From Uye", bag);
            DataTable MyUye = new DataTable();
            Uye.Fill(MyUye);
            bag.Open();
            Label2.Text = MyUye.Rows.Count.ToString();
            bag.Close();
        }
        protected void Cikis_Click(object sender, EventArgs e)
        {
            Response.Redirect("Giris.aspx");
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Çıkış Yapıldı", "<script>alert('Email Adresiniz veya Şifreniz Hatalı!');</script>");
        }
        private void MesajSayisi()
        {

            SqlDataAdapter Mesaj = new SqlDataAdapter("Select MesajId  From Mesaj", bag);
            DataTable MyMesaj = new DataTable();
            Mesaj.Fill(MyMesaj);
            bag.Open();
            Label1.Text = MyMesaj.Rows.Count.ToString();
            bag.Close();

        }

        UyeRepository ur = new UyeRepository();
        MesajRepository mr = new MesajRepository();
        private void MesajGetir()
        {
            DataTable dtgrup = klas.getDataTable("SELECT * FROM Mesaj ORDER BY MesajId DESC");
            rptMesajlar.DataSource = dtgrup;
            rptMesajlar.DataBind();

        }
        protected void rptMesajlar_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "delete":
                    mr.Delete(Convert.ToInt32(e.CommandArgument));
                    MesajGetir();

                    break;
                    
            }
        }


    }
}