<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateExpense.aspx.cs" Inherits="WebApplication1.CalculateExpense" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculate Expense</title>
</head>
<body>
  <div class="navigation">
        <asp:HyperLink NavigateUrl="~/AddProduct.aspx" runat="server" Text="Add product" ToolTip="Adds new product" />
        <asp:HyperLink NavigateUrl="~/CalculateExpense.aspx" runat="server" Text="Calculate Expense" ToolTip="Calculated" />
        <asp:HyperLink NavigateUrl="~/ShowAllProduct.aspx" runat="server" Text="Show all products" ToolTip="Show products" />
    
    </div>
    <form id="form1" runat="server">
    <div>
        <h3>Calculate Expense</h3>
        <asp:Label Text="Choose a period" runat="server" /> 
        <br />
        <br />
        <asp:DropDownList runat="server" ID="dropdownList" AutoPostBack="true" OnSelectedIndexChanged="dropdownList_SelectedIndexChanged">
            <asp:ListItem Text="" />
            <asp:ListItem Value="7">For a week</asp:ListItem> 
            <asp:ListItem Value="30">For a month</asp:ListItem> 
            <asp:ListItem Value="365">For a year</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label Text="" runat="server" ID="messageLabel" />
               <asp:Repeater runat="server" ID="repeater">
                <ItemTemplate>
                    <div class="book-container">
                        Date:
                    <asp:Label Text='<%# Eval("Date") %>' runat="server" />
                        <br />
                        Expense:
                    <asp:Label Text='<%# Eval("Expense") %>' runat="server" />
                        <br />
                        Price:
                    <asp:Label Text='<%# Eval("Price") %>' runat="server" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
