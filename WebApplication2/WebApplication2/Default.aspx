<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Spelare</h1>

        <p>Förnamn:</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <p>Efternamn:</p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        <p>Lön:</p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        <p>Hjälte:</p>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>

        <p>Skicklighet:</p>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

        <h1>Lag</h1>
        <p>Tillhör lag:</p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
