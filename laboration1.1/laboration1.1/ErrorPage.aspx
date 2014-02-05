<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="laboration1._1.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Serverfel</h1>
        <asp:Label ID="ErrorMsg" runat="server" Text="Någonting gick fel med att hantera din förfrågan."></asp:Label>

        <br />
        <asp:HyperLink ID="GetBack" runat="server" Text="Tillbaka till startsidan" NavigateUrl="~/Default.aspx" />
    </div>
    </form>
</body>
</html>
