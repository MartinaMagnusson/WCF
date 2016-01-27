<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EmployeesClient.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Get Employee</h2>
            <asp:Label ID="Label10" runat="server" Text="Employee ID"></asp:Label><br />
            <asp:TextBox ID="TextBoxID" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Button ID="ButtonGet" runat="server" Text="Get Employee" OnClick="ButtonGet_Click" /><br />

            <h2>Edit Employee</h2>
            <asp:Label ID="Label1" runat="server" Text="Employee ID"></asp:Label><br />
            <asp:TextBox ID="TextBoxEmployeeID" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Employee Firstname"></asp:Label><br />
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Employee Lastname"></asp:Label><br />
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Employee Title"></asp:Label><br />
            <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label5" runat="server" Text="Employee Title of courtesy"></asp:Label><br />
            <asp:TextBox ID="TextBoxTitleOfCourtesy" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label6" runat="server" Text="Employee BirthDate"></asp:Label><br />
            <asp:TextBox ID="TextBoxBirthDate" runat="server" TextMode="DateTime"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="Employee HireDate"></asp:Label><br />
            <asp:TextBox ID="TextBoxHireDate" runat="server" TextMode="DateTime"></asp:TextBox><br />
            <asp:Label ID="Label8" runat="server" Text="Employee Address"></asp:Label><br />
            <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label9" runat="server" Text="Employee City"></asp:Label><br />
            <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox><br />
            <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
        </div>
    </form>
</body>
</html>
