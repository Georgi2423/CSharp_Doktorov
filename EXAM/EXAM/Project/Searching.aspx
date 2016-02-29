<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Searching.aspx.cs" Inherits="Project.Searching" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Searching</title>
</head>
<body>
     <div class="navigation">
        <asp:HyperLink NavigateUrl="~/AddInfoForTheProgram.aspx" runat="server" Text="Add new country" ToolTip="Adds new coyntry" />
        <asp:HyperLink NavigateUrl="~/Searching.aspx" runat="server" Text="Search" ToolTip="Searchs" />
    </div>
    <form id="form1" runat="server">
    <div>
    <asp:Label Text="Enter a country" runat="server" />
        <asp:TextBox runat="server" ID="txtBoxID"/>  
        <br />
        <br />
        <asp:Label Text="" runat="server" ID="labelMessage"/>
        <br />
        <asp:Button Text="Search" runat="server" ID="searchingButton" OnClick="searchingButton_Click"/>
         <asp:Repeater runat="server" ID="repeater">
                <ItemTemplate>
                    <div class="book-container">
                        Country:
                    <asp:Label Text='<%# Eval("Country") %>' runat="server" />
                        <br />
                        Capital:
                    <asp:Label Text='<%# Eval("Capital") %>' runat="server" />
                        <br />
                        People:
                    <asp:Label Text='<%# Eval("People") %>' runat="server" />
                         <br />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
    </div>
    </form>
</body>
</html>
