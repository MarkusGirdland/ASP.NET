<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="laboration1._1.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hur många versaler?</h1>
        
        <asp:TextBox ID="TextBox" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>

        <br />
        <br />
        <asp:Label ID="CapitalLabel" runat="server" Text=""></asp:Label>

        <asp:Button ID="SendButton" runat="server" Text="Bestäm antalet versaler" OnClick="SendButton_Click" />

        <br />
        <asp:Button ID="ReturnButton" runat="server" Text="Rensa" OnClick="ReturnButton_Click" Visible="false"/>
    </div>
    </form>
</body>
</html>
