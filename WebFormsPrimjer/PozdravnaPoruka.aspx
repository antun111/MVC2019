﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PozdravnaPoruka.aspx.cs" Inherits="WebFormsPrimjer.PozdravnaPoruka" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ovo je pozdravna poruka <br />
            <asp:Label ID="Label1" runat="server" Text="Ime"></asp:Label><br />
            <asp:TextBox ID="txtIme" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnObradi" runat="server" Text="Button" OnClick="Obradi_Click" BackColor="#66CCFF" /><br />
            <br />
            <asp:Label ID="lblrezultat" runat="server" Text="Label"></asp:Label><br />
        </div>
    </form>
</body>
</html>
