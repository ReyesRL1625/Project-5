<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Project_5_Web_App.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <li>
        <p >Enter a username and password to register</p>
        <div>
            <asp:Label ID="Label1" runat="server">Username:</asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />  
            <asp:Label ID="Label2" runat="server">Password:</asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  <br />
            <asp:Label ID="Label3" runat="server">Confirm password:</asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" />
            <asp:Button ID="NewImageButton" runat="server" OnClick="NewImageButton_Click" Text="Get New Image" />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Please enter the text above into the following textbox "></asp:Label>
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="btn_addUser" Text="Submit" />
            <asp:Label ID="errorUser" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br /><br />
            <asp:Button ID="BackButton" runat="server" OnClick="BackButton_Click" Text="Back Home" />
        </div>
        </li>
    </form>
</body>
</html>
