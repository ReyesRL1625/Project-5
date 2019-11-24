<%@ Page Title ="Member Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Project_5_Web_App.Member" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="jumbotron">
        <h1>Member</h1>
        <p class="lead">This computing system is a travel destination reviewer which includes information on topics such as the weather.
            natural hazards and crime rate of two specific locations.
        </p>
    </div>
    <div class ="row">
        <h2>Weather and Crime</h2>
        <div class="col-md-4">
            <h3>Local Weather</h3>
            <p>A 5-day weather forecast service based on zip code </p>
        </div>
        <div class="col-md-4">
            <h3>Weather Comparator</h3>
            <p> A service that compares two zip codes’ weather and shows the results</p>
        </div>
        <div class="col-md-4">
            <h3>Local Crime</h3>
            <p>A service that returns crime data for a given zip code. Can be used to publish crime reports and statistics</p>
        </div>
        <div class="col-md-4">
            <h3>Crime Comparator</h3>
            <p>A service that compares two zip codes’ crime history and shows the results.</p>
        </div>
        <p>
            <asp:Button ID="WeatherAndCrime" runat="server" Text="Go" Width="200px" />
        </p>
        <p>
            <asp:Button ID="Subscribe" runat="server" Text="Subscribe" Width="200px" />
        </p>
    </div>
    <div class="row">
        <h2>Natural Hazards</h2>
        <div class="col-md-4">
            <h3>Local Natural Hazards</h3>
            <p>A service that returns the natural hazards (Tsunamis, earthquakes, volcanoes) index of a given position (latitude, longitude).</p>
            <p>
                <asp:Button ID="GetNaturalHazards" runat="server" Text="Get Natural Hazards" Width="200px" />
            </p>
            <p>
                <asp:Button ID="SubscribeNaturalHazards" runat="server" Text="Subscribe" Width="200px" />
            </p>
        </div>
        <div class="col-md-4">
            <h3>Natural Hazards Comparator</h3>
            <p>A service that compares natural hazards (Tsunamis, earthquakes, volcanoes) index of between to given positions (latitude, longitude).</p>
            <p>
                <asp:Button ID="NaturalHazardsComparator" runat="server" Text="Compare Natural Hazards" Width="200px" />
            </p>
            <p>
                <asp:Button ID="SubscribeNaturalHazardsCompare" runat="server" Text="Subscribe" Width="200px" />
            </p>
        </div>
    </div>

    <div class="row">
        <h2>Air Quality</h2>
        <div class="col-md-4">
            <h3>Local Air Quality</h3>
            <p>This service returns a string with the o3, so2, no2, aqi, co, pm10, and pm25 of the air in the provided zipcode.</p>
            <p>
                <asp:Button ID="GetAirQuality" runat="server" Text="Get Air Quality" Width="200px" />
            </p>
            <p>
                <asp:Button ID="SubscribeAirQuality" runat="server" Text="Subscribe" Width="200px" />
            </p>
        </div>
        <div class="col-md-4">
            <h3>Air Quality Rating Service</h3>
            <p>This service returns a string to rate the air quality given an air quality index (aqi) between 0 and 500.</p>
            <p>
                <asp:Button ID="RateAirQuality" runat="server" Text="Rate Air Quality" Width="200px" />
            </p>
            <p>
                <asp:Button ID="SubscribeRateAirQuality" runat="server" Text="Subscribe" Width="200px" />
            </p>
        </div>
    </div>

    <div class="row">
        <h2>Find Nearest</h2>
        <h3>Find Nearest Store</h3>
        <p>A service that returns the address of the nearest store with the given name</p>
        <p>
            <asp:Button ID="FindNearestStore" runat="server" Text="Find Nearest Store" Width="200px" />
        </p>
        <p>
            <asp:Button ID="SubscribeNearestStore" runat="server" Text="Subscribe" Width="200px" />
        </p>
    </div>

</asp:Content>
