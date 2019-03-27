<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pozdravna_poruka.aspx.cs" Inherits="WebFormsPrimjer.Pozdravna_poruka" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ovo je pozdravna poruka <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <asp:TextBox ID="Txtime" runat="server" OnTextChanged="Txtime_TextChanged" style="color: #FFFFFF; background-color: #CC0000"></asp:TextBox><br />
            <asp:Button ID="btnobradi" runat="server" Text="Button" /><br />
            <asp:Label ID="Lblrezulatat" runat="server" Text="Label"></asp:Label><br />

        </div>
    </form>
</body>
</html>
