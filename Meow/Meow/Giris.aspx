<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="Meow.Giris" %>

<!DOCTYPE html>
<html >
<head>
  <meta charset="UTF-8">
  <title>Flat Login Form</title>
  
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css">

  <link rel='stylesheet prefetch' href='https://fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900'>
<link rel='stylesheet prefetch' href='https://fonts.googleapis.com/css?family=Montserrat:400,700'>
<link rel='stylesheet prefetch' href='https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>

      <link rel="stylesheet" href="Content/style.css">

  <script src="Scripts/uyeol.js"></script>
</head>

<body>
  
<div class="container">
   <br />
    <br />
</div>
<div class="form">
  <div class="thumbnail"><img src="Resimler/header.png"></div>
  <%--<form class="login-form">
      
    <input type="text"  placeholder="Ad"/>
    <input type="text"  placeholder="Soyad"/>  
    <input type="text" placeholder="Email"/>
    <input type="password" placeholder="Şifre"/>
    <input type="password" placeholder="Şifre Tekrar"/>
    <button>Üye Ol</button>
    <p class="message"><a href="#">Giriş Yap</a></p>
  </form>--%>
    
  <form class="login-form" runat="server">
     
    <asp:TextBox ID="txtkadi" runat="server" placeHolder="Email"></asp:TextBox>
        <asp:TextBox ID="txtsifre" runat="server" placeHolder="Şifre"></asp:TextBox>
        <asp:Button ID="btngiris" runat="server" Text="Giriş" OnClick="btngiris_Click" BackColor="#EF3B3A"/>

    <p class="message">Üye Değil Misin? <a href="UyeOl.aspx">Yeni Hesap Oluştur</a></p>
  </form>
</div>
<video id="video" autoplay="autoplay" loop="loop" poster="polina.jpg">
  <source src="http://andytran.me/A%20peaceful%20nature%20timelapse%20video.mp4" type="video/mp4"/>
</video>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script src="Script/uyeol.js"></script>

</body>
</html>
