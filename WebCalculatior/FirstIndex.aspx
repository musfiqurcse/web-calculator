<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstIndex.aspx.cs" Inherits="WebCalculatior.FirstIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Number"></asp:Label>
        <asp:TextBox ID="firstNumberTextBox" runat="server"></asp:TextBox>
        <br />
    
    </div>
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Second Number"></asp:Label>
        <asp:TextBox ID="secondNumberTextBox" runat="server"></asp:TextBox>
        <br />
    
    </div>
    <div>
    
        <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
        <asp:TextBox ID="resultTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
        <asp:Button ID="substractButton" runat="server" Text="Substract" OnClick="substractButton_Click" />
        <asp:Button ID="divideButton" runat="server" Text="Divide" OnClick="divideButton_Click" />
        <asp:Button ID="multiplyButton" runat="server" Text="Multiply" OnClick="multiplyButton_Click" />
        <asp:Button ID="clearbutton" runat="server" Text="Clear" OnClick="clearbutton_Click" />
    
    </div>
    </form>
</body>
</html>
