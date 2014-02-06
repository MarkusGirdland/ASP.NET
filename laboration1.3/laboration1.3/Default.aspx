<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="laboration1._3.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboration 1.3</title>
    <link href="Content/site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Temperaturkonvertering</h1>
        
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Följande fel upptäcktes:" />

        <asp:RequiredFieldValidator ControlToValidate="StartTemp" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fyll i en starttemperatur." Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="EndTemp" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Fyll i en sluttemperatur." Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ControlToValidate="StepTemp" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Fyll i temperatursteg." Display="None"></asp:RequiredFieldValidator>

        
        <asp:CompareValidator ControlToCompare="StartTemp" ControlToValidate="EndTemp" ID="CompareValidator2" runat="server" ErrorMessage="Starttemperatur måste vara ett heltal & vara mindre än sluttemperatur." Display="None" Type="Integer" Operator="GreaterThan"></asp:CompareValidator>
        <asp:RangeValidator ControlToValidate="StepTemp" ID="RangeValidator1" runat="server" ErrorMessage="Temperatursteg måste vara ett heltal mellan 1-100." Display="None" Type="Integer" MaximumValue="100" MinimumValue="1"></asp:RangeValidator>

        <p>Starttemperatur:</p>
        <asp:TextBox ID="StartTemp" runat="server"></asp:TextBox>
        <asp:CompareValidator ControlToValidate="StartTemp" ID="CompareValidator1" runat="server" ErrorMessage="Sluttemperatur måste vara ett heltal." Display="None" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
        
        <p>Sluttemperatur:</p>
        <asp:TextBox ID="EndTemp" runat="server"></asp:TextBox>

        <p>Temperatursteg:</p>
        <asp:TextBox ID="StepTemp" runat="server"></asp:TextBox>

        <br />
        <p>Typ av konvertering:</p>
            <asp:RadioButton ID="CtoF" runat="server" GroupName="convertType" CssClass="radioButton" Checked="True" /><p>Celsius till Fahrenheit</p>
            <asp:RadioButton ID="FtoC" runat="server" GroupName="convertType" CssClass="radioButton"/><p>Fahrentheit till Celsius</p>

        <asp:Button ID="Convert" runat="server" Text="Konvertera" OnClick="Convert_Click" />

        <asp:Table ID="Table1" runat="server"></asp:Table>
    </div>
    </form>
</body>
</html>
