<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="WebApplication1.AddProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Product</title>
</head>
<body>
   <div class="navigation">
        <asp:HyperLink NavigateUrl="~/AddProduct.aspx" runat="server" Text="Add product" ToolTip="Adds new product" />
        <asp:HyperLink NavigateUrl="~/CalculateExpense.aspx" runat="server" Text="Calculate Expense" ToolTip="Calculated" />
        <asp:HyperLink NavigateUrl="~/ShowAllProduct.aspx" runat="server" Text="Show all products" ToolTip="Show products" />
    
    </div>
    <form id="form1" runat="server">
    <div>
        <h3>Info for the product</h3>
        <asp:Label runat="server" Text="Date"></asp:Label>
        <asp:TextBox ID="dateTextBox" runat="server" TextMode="DateTime"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Expense"></asp:Label>
        <asp:TextBox ID="expenseTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="priceTextBox" runat="server" TextMode="Number" step="0.01" ></asp:TextBox>
        <br />
        <br />
        <asp:Label Text="" runat="server" ID="labelMessage"/>
        <br />
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />

    </div>

            

    </form>
</body>
</html>
