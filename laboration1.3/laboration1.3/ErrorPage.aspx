﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="laboration1._2.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="Content/site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Temperaturkonvertering</h1>
        <p>Någonting gick fel med att hantera din förfrågan.</p>

        <br />
        <asp:HyperLink ID="GetBack" runat="server" Text="<--- Tillbaka till startsidan" NavigateUrl="~/Default.aspx" />
    </div>
    </form>
</body>
</html>
