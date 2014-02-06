<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="laboration1._4.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboration 1.4</title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="SendButton">
    <div>
        <h1>Gissa det hemliga talet</h1>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Följande fel upptäcktes:" />

        <p>Ange ett tal mellan 1 och 100:</p>
        <asp:TextBox ID="Guess" runat="server"></asp:TextBox>
        <asp:RangeValidator ControlToValidate="Guess" ID="RangeValidator1" runat="server" ErrorMessage="Måste vara ett heltal mellan 1-100." Display="None" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <asp:RequiredFieldValidator ControlToValidate="Guess" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fältet får inte lämnas tomt" Visible="True" Display="None"></asp:RequiredFieldValidator>

        <asp:Button ID="SendButton" runat="server" Text="Skicka gissning" OnClick="Button1_Click" />

        <asp:Label ID="Guesses" runat="server" Text=""></asp:Label>
    </div>
    </form>
    <script src="Content/MyScript.js"></script>
</body>
</html>
