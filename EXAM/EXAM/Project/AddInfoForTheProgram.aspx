<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddInfoForTheProgram.aspx.cs" Inherits="Project.AddInfoForTheProgram" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add info for the Capital</title>
</head>
<body>
     <div class="navigation">
        <asp:HyperLink NavigateUrl="~/AddInfoForTheProgram.aspx" runat="server" Text="Add new country" ToolTip="Adds new coyntry" />
        <asp:HyperLink NavigateUrl="~/Searching.aspx" runat="server" Text="Search" ToolTip="Searchs" />
    </div>
    <form id="form1" runat="server">
    <div>
     <h3>Info for the capital</h3>
        <asp:Label runat="server" Text="Capital"></asp:Label>
        <asp:TextBox ID="capitalTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Country"></asp:Label>
        <asp:TextBox ID="countryTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="People"></asp:Label>
        <asp:TextBox ID="peopleTextBox" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Label Text="" runat="server" ID="labelMessage"/>
        <br />
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click"/>
    </div>
    </form>
</body>
</html>
