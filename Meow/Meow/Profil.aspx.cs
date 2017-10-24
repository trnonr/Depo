using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Meow.Models;

namespace Meow
{
    public partial class Profil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            MesajGetir();
            ProfilGetir();
        }
        MeowbookEntities1 db = new MeowbookEntities1();
        Sinif klas = new Sinif();
        MesajRepository mr = new MesajRepository();
        
        private void ProfilGetir()
        {
            DataTable dtpp = klas.getDataTable("SELECT * FROM Uye WHERE UyeId=" + Session["UyeId"]);
            profilpp.DataSource = dtpp;
            profilpp.DataBind();
        }


        private void MesajGetir()
        {

            DataTable dtgrup = klas.getDataTable("SELECT * FROM Mesaj WHERE UyeId=" + Session["UyeId"] + "ORDER BY MesajId DESC");
            rptmeow.DataSource = dtgrup;
            rptmeow.DataBind();

        }

        protected void meowla_Click(object sender, EventArgs e)
        {

            mr.Insert(new Mesaj
            {
                Mesaj1 = txtyaz.Text,
                Tarih = DateTime.Now,
                Begen = 1,
                FotografYol = "1.jpg",
                UyeId = 2

            });

            Response.Redirect("~/Profil.aspx");
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