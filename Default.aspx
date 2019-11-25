<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_5_Web_App.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="jumbotron">
        <h1>Welcome</h1>
        <p class="lead">The following application provides you with a travel destination reviewer. You can review things such as the weather and natural hazards. You can
            sign up by clicking the &quot;Member Registration&quot; button, using your name and a password to create an account. Once you create and account, go back to login as a member and use the services!
        </p>
        <p class="lead">Testing Zip Codes: 85349, 85281</p>
    </div>
    <p>
        <asp:Button ID="RegisterButton" runat="server" Text="Member Registration" OnClick="RegisterButton_Click" />
    </p>
<p>
        <asp:Button ID="MemberButton" runat="server" OnClick="MemberButton_Click" Text="Member Page" />
    &nbsp;<asp:Button ID="MemLoginButton" runat="server" Text="Member Login" OnClick="MemLoginButton_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="StaffButton" runat="server" OnClick="StaffButton_Click" Text="Staff Page" />
        <asp:Button ID="StaffLoginButton" runat="server" Text="Staff Login" OnClick="StaffButton_Login_Click"/>
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
