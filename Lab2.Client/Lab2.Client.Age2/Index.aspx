<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Lab2.Client.Age2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelBirthday" runat="server" Text="Skriv in ditt födelsedatum"></asp:Label>
        <asp:TextBox ID="TextBoxBirthday" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonBirthday" runat="server" OnClick="ButtonBirthday_Click" Text="Beräkna" />
        <br />
        <asp:Label ID="LabelDays" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
