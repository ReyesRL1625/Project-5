<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Project_5_Web_App.Protected.Staff" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Staff Page</h1> <br />    

        <h1>Staff Page of Travel Destination Reviewer</h1>
        <div>  
            <% Response.Write("Hello TA, "); %> <br />
        This page contains the information about staff members. Only authenticated users can access this page .<br /> 
        </div>    
        <asp:Button ID="BackButton" runat="server" OnClick="BackButton_Click" Text="Back Home" />
    
    <li>
        <p >Enter a username or password to add or remove a staff member</p>
        <div>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
            <asp:Button ID="Button3" runat="server" OnClick="btn_addStaff" Text="Add" />
            <asp:Button ID="Button4" runat="server" OnClick="btn_rmStaff" Text="Remove" />
            <asp:Label ID="errorUser" runat="server"></asp:Label>
        </div>
        </li>
    
</asp:Content>
