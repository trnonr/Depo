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
    public partial class AdminPanel : System.Web.UI.Page
    {
        SqlConnection bag = new SqlConnection("Server=.;Database=MeowBook;Integrated Security=True");
        MeowbookEntities1 db = new MeowbookEntities1();
        Sinif klas = new Sinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            UyeGetir();
            SayiGetir();
            UyeSayisi();
        }
        protected void Cikis_Click(object sender, EventArgs e)
        {
            Response.Redirect("Giris.aspx");
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Çıkış Yapıldı", "<script>alert('Email Adresiniz veya Şifreniz Hatalı!');</script>");
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
        private void SayiGetir()
        {
            
            SqlDataAdapter MyAdp = new SqlDataAdapter("Select MesajId  From Mesaj", bag);
            DataTable MyTable = new DataTable();
            MyAdp.Fill(MyTable);
            bag.Open();
            Label1.Text = MyTable.Rows.Count.ToString();
            bag.Close();
        }

        UyeRepository ur = new UyeRepository();
        
        private void UyeGetir()
        {
            DataTable dtgrup = klas.getDataTable("SELECT * FROM Uye");
            rptUyeler.DataSource = dtgrup;
            rptUyeler.DataBind();

        }
        protected void rptUyeler_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "delete":
                    ur.Delete(Convert.ToInt32(e.CommandArgument));
                    UyeGetir();
                    
                    break;

                case "update":
                    Response.Redirect(string.Format("~/AdminPaneli/Category/CategoryUpdate.aspx?CategoryId={0}", e.CommandArgument));
                    break;
            }
        }
        
        
    }
}