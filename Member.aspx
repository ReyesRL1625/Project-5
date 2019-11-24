<%@ Page Title ="Member Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Project_5_Web_App.Member" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="jumbotron">
        <h1>Member</h1>
        <p class="lead">Choose what you would like to do:
        </p>

         <li>
            <h4><a runat="server" href="~/Weather">Weather Services</a></h4> 
            <h4><a runat="server" href="~/Manage">Manage</a></h4>
        </li>
    </div>
    

</asp:Content>
