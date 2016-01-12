<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Lab1Client.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="ButtonWeather" runat="server" Text="Se morgondagens väder" OnClick="ButtonWeather_Click" />
            <asp:Label ID="LabelWeather" runat="server" Text=""></asp:Label>

            <hr />

            <asp:TextBox ID="TextBoxNumberOne" runat="server"></asp:TextBox>
            +
            <asp:TextBox ID="TextBoxNumberTwo" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonAddTwoNumbers" runat="server" Text=" = " OnClick="ButtonAddTwoNumbers_Click" />
            <asp:Label ID="LabelAddTwoNumbers" runat="server" Text=""></asp:Label>

            <hr />

            <asp:TextBox ID="TextBoxAddNumberOne" runat="server"></asp:TextBox>
            +
            <asp:TextBox ID="TextBoxAddNumberTwo" runat="server"></asp:TextBox>
            +
            <asp:TextBox ID="TextBoxAddNumberThree" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonAddThreeNumbers" runat="server" Text=" = " OnClick="ButtonAddThreeNumbers_Click" />
            <asp:Label ID="LabelAddThreeNumbers" runat="server" Text=""></asp:Label>

            <hr />

            <asp:TextBox ID="TextBoxSubtracNumberOne" runat="server"></asp:TextBox>
            -
            <asp:TextBox ID="TextBoxSubtracNumberTwo" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonSubtracNumbers" runat="server" Text=" = " OnClick="ButtonSubtracTwoNumbers_Click" />
            <asp:Label ID="LabelSubtracNumbers" runat="server" Text=""></asp:Label>

            <hr />

            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <asp:Button ID="Button1Name" runat="server" Text=" Namnsdag " OnClick="ButtonNameDay_Click" />
            <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>

            <hr />
            <asp:textbox  ID="TextBoxWars" runat="server" Rows="8" TextMode="MultiLine"></asp:textbox>
            <asp:Button ID="ButtonWars" runat="server" Text="Se hur länge krigen vara" OnClick="ButtonWars_Click" />
        </div>
    </form>
</body>
</html>

