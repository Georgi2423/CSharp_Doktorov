<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllProduct.aspx.cs" Inherits="WebApplication1.ShowAllProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show all products</title>
</head>
<body>
    <div class="navigation">
        <asp:HyperLink NavigateUrl="~/AddProduct.aspx" runat="server" Text="Add product" ToolTip="Adds new product" />
        <asp:HyperLink NavigateUrl="~/CalculateExpense.aspx" runat="server" Text="Calculate Expense" ToolTip="Calculated" />
        <asp:HyperLink NavigateUrl="~/ShowAllProduct.aspx" runat="server" Text="Show all products" ToolTip="Show products" />
    
    </div>
    <form id="form1" runat="server">
    <div>
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
                        <br />
                        <br />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
