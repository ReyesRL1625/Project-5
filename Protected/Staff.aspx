<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Project_5_Web_App.Protected.Staff" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> <title>staff page</title> </head>
<body>
    <form id="form2" runat="server">
        <h1>Staff Page of Travel Destination Reviewer</h1>
        <div>  
            <% Response.Write("Hello " + Context.User.Identity.Name + ", "); %> <br />
        This page contains the information about staff members who will teach 
        and manage the camp. Only authenticated users can access this page .<br /> 
        </div>    
        <asp:Button ID="BackButton" runat="server" OnClick="BackButton_Click" Text="Back Home" />
    </form>
</body>
</html>