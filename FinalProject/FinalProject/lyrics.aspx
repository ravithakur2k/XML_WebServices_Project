<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lyrics.aspx.cs" Inherits="FinalProject.lyrics" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <link rel="stylesheet" href="/css/bootstrap.css"/>
      <link rel="stylesheet" href="/css/font-awesome.min.css"/>
      <link rel="stylesheet" href="/css/weather_lyric.css"/>
      <title></title>
   </head>
   <body id="lyricImg">
      <form id="form1" runat="server">
         <nav class="navbar navbar-expand-sm navbar-dark bg-dark">
            <div class="container">
               <a href="#" class="navbar-brand">Lyrics Data</a>
               <button class="navbar-toggler" data-toggle="collapse" data-target="#navNavbar">
               <span class="navbar-toggler-icon"></span>
               </button>
               <div class="collapse navbar-collapse" id="navNavbar">
                  <ul class="navbar-nav ml-auto">
                     <li class="nav-item"><a href="weather.aspx" class="nav-link">Weather</a></li>
                     <li class="nav-item active"><a href="lyrics.aspx" class="nav-link">Lyrics</a></li>
                     <li class="nav-item"><a href="BandDetail.aspx" class="nav-link">Band Details JSON</a></li>
                  </ul>
               </div>
            </div>
         </nav>
           <section class="py-3">
            <div class="container">
               <div class="row">
                  <div class="col-md-6">
                     <h4 class="text-primary"><strong>Get the Lyrics of your favourite Song</strong></h4>
                     <div class="form-group">
                        <input id="artistName" type="text" class="form-control" placeholder="Artist Name" runat="server"/>
                        <input id="titleName" type="text" class="form-control" placeholder="Song Title" runat="server"/>
                     </div>
                     <asp:Button  runat="server" class="btn btn-primary" Text="Get Lyrics of the song" OnClick="BtnClk"/>
                     <br />
                     <asp:Label ID="Lyric_Info" runat="server" Text=""></asp:Label>
                  </div>
               </div>
            </div>
         </section>
      </form>
   </body>
</html>