<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EmployeesClient.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelGet" runat="server" Text="Get Employee by ID"></asp:Label><br />
            <asp:TextBox ID="TextBoxID" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Button ID="ButtonGet" runat="server" Text="Get Employee" OnClick="ButtonGet_Click" /><br />

            <asp:Label ID="LabelEdit" runat="server" Text="Edit Employee"></asp:Label><br />
            <asp:TextBox ID="TextBoxEmployeeID" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBoxTitleOfCourtesy" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBoxBirthDate" runat="server" TextMode="DateTime"></asp:TextBox><br />
            <asp:TextBox ID="TextBoxHireDate" runat="server" TextMode="DateTime"></asp:TextBox><br />
            <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox><br />
            <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
        </div>
    </form>
</body>
</html>
