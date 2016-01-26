<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShipperClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>Enter shipper ID</p>
    <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonGet" runat="server" Text="Get Shipper" OnClick="ButtonGet_Click" />
    <p>Edit shipper data</p>
    <p>Shipper ID</p>
    <asp:TextBox ID="TextBoxShipperID" runat="server"></asp:TextBox>
    <p>Shipper Name</p>
    <asp:TextBox ID="TextBoxShipperName" runat="server"></asp:TextBox>
    <p>Shipper Phone</p>
    <asp:TextBox ID="TextBoxShipperPhone" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonSave" runat="server" Text="Save" />
</asp:Content>
