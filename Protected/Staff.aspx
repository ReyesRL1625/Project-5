<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Project_5_Web_App.Protected.Staff" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Staff Page</h1> <br />    
    
    <li>
        <p >Enter a username or password to add or remove a member</p>
         <div>
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  
            <asp:Button ID="Button1" runat="server" OnClick="btn_addMember" Text="Add" />
            <asp:Button ID="Button2" runat="server" OnClick="btn_rmMember" Text="Remove" />
         </div>
        <div>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
            <asp:Button ID="Button3" runat="server" OnClick="btn_addStaff" Text="Add" />
            <asp:Button ID="Button4" runat="server" OnClick="btn_rmStaff" Text="Remove" />
        </div>
        </li>
    
</asp:Content>

