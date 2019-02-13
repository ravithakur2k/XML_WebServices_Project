<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weather.aspx.cs" Inherits="FinalProject.weather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="/css/weather.css"/>
    <title>Weather Report</title>
</head>
<body>
    <form id="form1" runat="server">
       <header>
        <nav class="navbar navbar-default">
            <div class="container">
                <div class="navbar-header">
                    <a class="navbar-brand" href="/"> Weather Report </a>
                </div>

                <ul class="nav navbar-nav navbar-right">
                    <li><a href="#"><i class="fa fa-home"></i> Home </a></li>
                </ul>
            </div>
        </nav>
    </header>

    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h4 class="text-info"><strong>Current Day Weather Report by City</strong></h4>
                <div class="form-group">
                    <input id="CityName" type="text" class="form-control" placeholder="E.g.: London,UK" runat="server"/>
                </div>
                <asp:Button  runat="server" class="btn btn-info" Text="Get Current Day Weather Report" OnClick="BtnClk"/>

                <br></br>
                 <asp:Label ID="Weather_Info" runat="server" Text=""></asp:Label> 
            </div>
        </div>
    </div>
    </form>
</body>
</html>
