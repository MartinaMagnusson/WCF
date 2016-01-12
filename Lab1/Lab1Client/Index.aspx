<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Lab1Client.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="ButtonWeather" runat="server" Text="Se morgondagens väder" OnClick="ButtonWeather_Click" />
        <asp:Label ID="LabelWeather" runat="server" Text=""></asp:Label>
    <div>
    
    </div>
    </form>
</body>
</html>
