<%@ Page Title ="Member Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Weather.aspx.cs" Inherits="Project_5_Web_App.Weather" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="jumbotron">
        <h1>Member</h1>
        <p class="lead">This computing system lets you view a weather forecast or compare the weather of two zip codes.
        </p>
    </div>
    <div class ="row">
        <h2>Weather and Crime</h2>
        <div class="col-md-4">
            <h3>Local Weather</h3>
            <p>A 5-day weather forecast service based on zip code </p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
            <asp:Button ID="Button1" runat="server" OnClick="btn_weather" Text="Submit" />
        </div>
        <div class="col-md-4">
            <h3>Weather Comparator</h3>
            <p> A service that compares two zip codes’ weather and shows the results</p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
            <asp:Button ID="Button2" runat="server" OnClick="btn_weather_compare" Text="Submit" />
        </div>
    </div>
    <div>
        <tr ID="row0" runat="server"></tr><br />
        <tr ID="row1" runat="server"></tr><br />
        <tr ID="row2" runat="server"></tr><br />
        <tr ID="row3" runat="server"></tr><br />
        <tr ID="row4" runat="server"></tr><br />
        <tr id="row5" runat="server"></tr><br />
    </div>
</asp:Content>
