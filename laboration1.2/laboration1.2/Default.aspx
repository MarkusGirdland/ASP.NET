<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="laboration1._2.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboration 1.2</title>
    <link href="Content/site.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="CalculateButton">
    <div>
        <h1 id="myh1">Kassakvitto</h1>
        <p>Total köpesumma:</p>
        <asp:TextBox ID="Amount" runat="server" CausesValidation="True"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fältet kan inte vara tomt" ControlToValidate="Amount" Display="Dynamic"></asp:RequiredFieldValidator>

        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Måste vara ett heltal större än 0."
            ControlToValidate="Amount" Operator="GreaterThan" ValueToCompare="0" Type="Double" Display="Dynamic"></asp:CompareValidator>

        <br />
        <asp:Button ID="CalculateButton" runat="server" Text="Beräkna rabatt" OnClick="CalculateButton_Click" />
        <br />
        <br />
        <div id="ReceiptDiv">
            <asp:Label ID="ReceiptHead" runat="server" Text=""></asp:Label>
            <asp:Label ID="ReceiptText" runat="server" Text=""></asp:Label>
        </div>
    </div>
    </form>
    <script src="Content/MyScript.js"></script>
</body>
</html>
