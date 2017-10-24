using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data;
using Owin;

namespace Meow
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
    public partial class Giris : System.Web.UI.Page
    {

        Sinif klas = new Sinif();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btngiris_Click(object sender, EventArgs e)
        {
            DataRow drGiris = klas.getDataRow("Select * from Uye Where Email='" + txtkadi.Text + "'and Sifre='" + txtsifre.Text + "'");
            DataRow drAdmin = klas.getDataRow("Select * from Uye Where Email='" + txtkadi.Text + "'and Sifre='" + txtsifre.Text + "' and UyeId= '"+1+"'");
            if (drAdmin != null)
            {
                Session["UyeId"] = drAdmin["UyeId"].ToString();
                Response.Redirect("AdminPanel.aspx");
            }
            else
            {
                if (drGiris != null)
                {
                    Session["UyeId"] = drGiris["UyeId"].ToString();
                    Response.Redirect("Default.aspx");
                }

                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Giriş Yapılmadı", "<script>alert('Email Adresiniz veya Şifreniz Hatalı!');</script>");
                }
            }

            string imgId = Request.QueryString["Resim"];

            SqlDataSource db = new SqlDataSource();

            db.SelectCommand = "SELECT Resim FROM Uye WHERE = id" + imgId;
        }
    }
}