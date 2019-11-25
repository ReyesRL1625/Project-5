<%@ Page Title ="Member Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Project_5_Web_App.Member" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="jumbotron">
        <h1>Member</h1>
        <p class="lead">This computing system is a travel destination reviewer which includes information on topics such as the weather.
            natural hazards and crime rate of two specific locations.
        </p>
    </div>
    <div class ="row">
        <h2>Weather</h2>
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
        <div>
        <tr ID="row0" runat="server"></tr><br />
        <tr ID="row1" runat="server"></tr><br />
        <tr ID="row2" runat="server"></tr><br />
        <tr ID="row3" runat="server"></tr><br />
        <tr ID="row4" runat="server"></tr><br />
        <tr id="row5" runat="server"></tr><br />
        </div>  
    </div>
    <div class="row">
            <h2>Natural Hazards</h2>
            <p>
                The Natural Hazards service takes in a latitude and longitude of a location and returns the natural hazard index (count) for that location.
            </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Latitude"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Longitude"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button1_Click" Text="Calculate" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Results"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>    
    </div>


</asp:Content>
