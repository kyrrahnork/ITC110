<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>menu</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Ordering Menu</h1>
        <h2>Entrees:</h2>
        <asp:CheckBoxList ID="CBLEntree" runat="server">
        </asp:CheckBoxList><br />
        <h2>Drinks:</h2>
        <asp:CheckBoxList ID="CBLDrinks" runat="server">
        </asp:CheckBoxList>
        <h3>Click The Button Below to Submit Your Order</h3>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
