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
    public partial class UyeOl : System.Web.UI.Page
    {
        MeowbookEntities1 db = new MeowbookEntities1();
        Sinif klas = new Sinif();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnuyeol_Click(object sender, EventArgs e)
        {
            Uye u = new Uye();
            u.Ad = txtad.Text;
            u.Soyad = txtsoyad.Text;
            u.Email = txtemail.Text;
            u.Resim = "1.jpg";
            u.Sifre = txtsifre.Text;
            db.Uye.Add(u);
            db.SaveChanges();
            Response.Redirect("~/Giris.aspx");
            //if (Session["Email"] == txtemail.Text || txtsifre.Text != txtsifretekrar.Text)
            //{

            //    txtemail.Text = "";
            //    txtsifre.Text = "";
            //    txtsifretekrar.Text = "";
            //    Response.Write("<script LANGUAGE='JavaScript' >alert('Email Kullanılmakta veya Şifreler Aynı Değil')</script>");

            //}
            //else
            //{
            //    u.Sifre = txtsifre.Text;
            //    u.Ad = txtad.Text;
            //    u.Soyad = txtsoyad.Text;
            //    u.Email = txtemail.Text;
            //    u.Resim = "header.png";
            //    db.Uye.Add(u);
            //    db.SaveChanges();
            //    Response.Redirect("~/Giris.aspx");

            //}

        }
    }
}