<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="Meow.AdminPanel" EnableViewState="false" ViewStateMode="Disabled"%>

<!DOCTYPE html>
<html lang="en">

  <head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <meta name="description" content="">
    <meta name="author" content="">
    <title>MeowBook - Admin Panel</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom fonts for this template -->
    <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

    <!-- Plugin CSS -->
    <link href="vendor/datatables/dataTables.bootstrap4.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="Content/sb-admin.css" rel="stylesheet">

  </head>

  <body class="fixed-nav sticky-footer bg-dark" id="page-top">

    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top" id="mainNav">
      <a class="navbar-brand" href="#">Meowbook - Admin Panel</a>
      <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav navbar-sidenav" id="exampleAccordion">
          <li class="nav-item active" data-toggle="tooltip" data-placement="right" title="Uyeler">
            <a class="nav-link" href="AdminPanel.aspx">
              <i class="fa fa-fw fa-table"></i>
              <span class="nav-link-text">
                Uyeler</span>
            </a>
          </li>
          
          <li class="nav-item" data-toggle="tooltip" data-placement="right" title="Mesajlar">
            <a class="nav-link" href="AdminPanelMesaj.aspx">
              <i class="fa fa-fw fa-table"></i>
              <span class="nav-link-text">
                Mesajlar</span>
            </a>
          </li>
          
          
          
          
        </ul>
        
        <ul class="navbar-nav ml-auto">
         <form runat="server">
          <li class="nav-item">
            <a class="nav-link">
                <asp:Button ID="AdminPanelCikis" runat="server" class="w3-button w3-block w3-theme-l1 w3-left-align" OnClick="Cikis_Click" Text="Çıkış"/><asp:Button />
              </a>
          </li>
        </ul>
      </div>
    </nav>

    <div class="content-wrapper">

      <div class="container-fluid">


        <!-- Icon Cards -->
        <div class="row">
          <div class="col-xl-3 col-sm-6 mb-3">
            <div class="card text-white bg-primary o-hidden h-100">
              <div class="card-body">
                <div class="card-body-icon">
                  <i class="fa fa-fw fa-comments"></i>
                </div>
                <div >
                    Toplam Mesaj: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </div>
              </div>
              
            </div>
          </div>
          <div class="col-xl-3 col-sm-6 mb-3">
            <div class="card text-white bg-warning o-hidden h-100">
              <div class="card-body">
                <div class="card-body-icon">
                  <i class="fa fa-fw fa-list"></i>
                </div>
                <div class="mr-5">
                  Toplam Üye: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </div>
              </div>
              
            </div>
          </div>
          
        </div>
        <div class="row">

          <div class="col-lg-8">
         </div>

          <div class="col-lg-4">
            
            
            <!-- Example Notifications Card -->
           <%-- <div class="card mb-3">--%>
              <%--<div class="card-header">
                <i class="fa fa-bell-o"></i>
                Feed Example
              </div>--%>
              <%--<div class="list-group list-group-flush small">--%>
                <%--<a href="#" class="list-group-item list-group-item-action">
                  <div class="media">
                    <img class="d-flex mr-3 rounded-circle" src="http://placehold.it/45x45" alt="">
                    <div class="media-body">
                      <strong>David Miller</strong>
                      posted a new article to
                      <strong>David Miller Website</strong>.
                      <div class="text-muted smaller">Today at 5:43 PM - 5m ago</div>
                    </div>
                  </div>
                </a>--%>
                
                
                <%--<a href="#" class="list-group-item list-group-item-action">
                  <div class="media">
                    <img class="d-flex mr-3 rounded-circle" src="http://placehold.it/45x45" alt="">
                    <div class="media-body">
                      <i class="fa fa-code-fork"></i>
                      <strong>Monica Dennis</strong>
                      forked the
                      <strong>startbootstrap-sb-admin</strong>
                      repository on
                      <strong>GitHub</strong>.
                      <div class="text-muted smaller">Today at 3:54 PM - 2hrs ago</div>
                    </div>
                  </div>
                </a>--%>
                <%--<a href="#" class="list-group-item list-group-item-action">
                  View all activity...
                </a>--%>
              <%--</div>--%>
              
            <%--</div>--%>
          </div>
        </div>

        <!-- Example Tables Card -->
        <div class="card mb-3">
          <div class="card-header">
            <i class="fa fa-table"></i>
            Üyeler
          </div>
          <div class="card-body">
            <div class="table-responsive">
                
              <table class="table table-bordered" width="100%" id="dataTable" cellspacing="0">
                 
                            <thead>
                                <tr>
                                    <th>Üye Id</th>
                                    <th>Ad</th>
                                    <th>Soyad</th>
                                    <th>E-Mail</th>
                                     <th>Şifre</th>
                                    <th>Doğum Tarihi</th>
                                    <th>Okul</th>
                                    <th>Şehir</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tfoot>
                            </tfoot>
                            <tbody>
                                <asp:Repeater ID="rptUyeler" runat="server"  OnItemCommand="rptUyeler_ItemCommand">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("UyeId") %></td>
                                            <td><%#Eval("Ad") %></td>
                                            <td><%#Eval("Soyad") %></td>
                                            <td><%#Eval("Email") %></td>
                                            <td><%#Eval("Sifre") %></td>
                                            <td><%#Eval("DogumTarihi","{0:dd MMM yyyy}") %></td>
                                            <td><%#Eval("Okul") %></td>
                                            <td><%#Eval("Şehir") %></td>
                                            <td>
                                                <asp:ImageButton ImageUrl="~/Resimler/sil.png" runat="server" ID="imgbtnSil" AlternateText="Sil" CommandName="delete" CommandArgument='<%#Eval("UyeId") %>' OnClientClick="return confirm('Bu kişiyi silmek istediginizden emin misiniz?')" />
                                                <asp:ImageButton ImageUrl="~/Resimler/guncelle.png" runat="server" ID="imgbtnGuncelle" AlternateText="Guncelle" CommandName="update" CommandArgument='<%#Eval("UyeId") %>' />
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        
              </table>
                    </form>
            </div>
          </div>
          
        </div>

      </div>
      <!-- /.container-fluid -->

    </div>
    <!-- /.content-wrapper -->

    <footer class="sticky-footer">
      <div class="container">
        <div class="text-center">
          <small>MeowBook &copy; 2017</small>
        </div>
      </div>
    </footer>

    <!-- Scroll to Top Button -->
    <a class="scroll-to-top rounded" href="#page-top">
      <i class="fa fa-angle-up"></i>
    </a>

     <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/popper/popper.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>
    <script src="vendor/chart.js/Chart.min.js"></script>
    <script src="vendor/datatables/jquery.dataTables.js"></script>
    <script src="vendor/datatables/dataTables.bootstrap4.js"></script>

    <!-- Custom scripts for this template -->
    <script src="Script/sb-admin.min.js"></script>

  </body>

</html>

