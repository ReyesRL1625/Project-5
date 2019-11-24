<%@ Page Title ="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project_5_Web_App.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>
    <div class ="row">
        <p>
            <asp:Label ID="Username" runat="server" Text="Username"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="usernameText" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="passwordText" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="LoginButton" runat="server" Text="Login" Width="200px" OnClick="LoginButton_Click" />
        </p>
    </div>
</asp:Content>
