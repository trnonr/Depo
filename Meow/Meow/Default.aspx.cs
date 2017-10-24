using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using Meow.Models;
using System.Collections;

namespace Meow
{
    public partial class Default : System.Web.UI.Page
    {
        MeowbookEntities1 db = new MeowbookEntities1();
        Sinif klas = new Sinif();
        MesajRepository mr = new MesajRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsPostBack) return;
            MesajGetir();
            PpGetir();
            
        }
        
        private void PpGetir()
        {
            DataTable dtpp = klas.getDataTable("SELECT * FROM Uye WHERE UyeId=" + Session["UyeId"]);
            rptpp.DataSource = dtpp;
            rptpp.DataBind();
        }
        

        private void MesajGetir()
        {

            DataTable dtgrup = klas.getDataTable("SELECT * FROM Mesaj ORDER BY MesajId DESC");
            rptmeow.DataSource = dtgrup;
            rptmeow.DataBind();
            
        }

        protected void meowla_Click(object sender, EventArgs e)
        {

            Mesaj m = new Mesaj();
            m.Mesaj1 = txtyaz.Text;
            m.Tarih = DateTime.Now;
            m.Begen = 1;
            m.FotografYol = "1.jpg";
            m.UyeId = 2;
            db.Mesaj.Add(m);
            db.SaveChanges();
            Response.Redirect("~/Default.aspx");

        }
            protected void Cikis_Click(object sender, EventArgs e)
        {
            Response.Redirect("Giris.aspx");
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Çıkış Yapıldı", "<script>alert('Email Adresiniz veya Şifreniz Hatalı!');</script>");
        }
        int sayi = 1;
        Mesaj guncelle;
        protected void btnbegen_Click(object sender, EventArgs e)
        {
            //guncelle.Begen = guncelle.Begen + sayi;
            //db.SaveChanges();
            //Response.Redirect("Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtyaz.Text = Button1.Text;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            txtyaz.Text = Button2.Text;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            txtyaz.Text = Button3.Text;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            txtyaz.Text = Button4.Text;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            txtyaz.Text = Button5.Text;
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            txtyaz.Text = Button6.Text;
        }
    
    }

}