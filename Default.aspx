<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_5_Web_App.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="jumbotron">
        <h1>Welcome</h1>
        <p class="lead">The following application provides you with a travel destination reviewer. You can review things such as the weather, crime, natural hazards, favorite store locations, and air quality. You can
            sign up
        </p>
    </div>
    <p>
        <asp:Button ID="MemberButton" runat="server" OnClick="MemberButton_Click" Text="Member Page" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="StaffButton" runat="server" OnClick="StaffButton_Click" Text="Staff Page" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>

   
</asp:Content>
