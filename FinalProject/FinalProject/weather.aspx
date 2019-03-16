<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weather.aspx.cs" Inherits="FinalProject.weather" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <link rel="stylesheet" href="/css/bootstrap.css"/>
      <link rel="stylesheet" href="/css/font-awesome.min.css"/>
      <link rel="stylesheet" href="/css/weather_lyric.css"/>
      <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>    
    <script>
    $( function(){
        $("#CityName").autocomplete({
           source: "weatherAutoComplete.aspx",
          minLength : 2
        });
    });
  
  </script>
      <title>Weather Report</title>

   </head>
   <body id="weatherImg">
      <form id="form1" runat="server">
         <nav class="navbar navbar-expand-sm navbar-dark bg-dark">
            <div class="container">
               <a href="#" class="navbar-brand">Weather Data</a>
               <button class="navbar-toggler" data-toggle="collapse" data-target="#navNavbar">
               <span class="navbar-toggler-icon"></span>
               </button>
               <div class="collapse navbar-collapse" id="navNavbar">
                  <ul class="navbar-nav ml-auto">
                     <li class="nav-item active"><a href="weather.aspx" class="nav-link">Weather</a></li>
                     <li class="nav-item"><a href="lyrics.aspx" class="nav-link">Lyrics</a></li>
                     <li class="nav-item"><a href="BandDetail.aspx" class="nav-link">Band Details JSON</a></li>
                     
                  </ul>
               </div>
            </div>
         </nav>
         <section class="py-3">
            <div class="container">
               <div class="row">
                  <div class="col-md-6">
                     <h4 class="text-primary"><strong>Current Day Weather Report by City</strong></h4>
                     <div class="form-group">
                        <input id="CityName" type="text" class="form-control" placeholder="E.g.: London,UK" runat="server"/>
                     </div>
                     <asp:Button  runat="server" class="btn btn-primary" Text="Get Current Day Weather Report" OnClick="BtnClk"/>
                     <br />
                     <asp:Label ID="Weather_Info" runat="server" Text=""></asp:Label>
                  </div>
               </div>
            </div>
         </section>
      </form>
   </body>
</html>