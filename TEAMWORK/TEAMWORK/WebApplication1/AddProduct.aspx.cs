using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            var infoToAdd = new Info(
                DateTime.Parse(this.dateTextBox.Text),
                this.expenseTextBox.Text,
                double.Parse(this.priceTextBox.Text));

            if (Operation.AddInfo(infoToAdd))
            {
                this.labelMessage.Text = "Successfully added";
                this.dateTextBox.Text = string.Empty;
                this.expenseTextBox.Text = string.Empty;
                this.priceTextBox.Text = string.Empty;
            }
            else
            {
                this.labelMessage.Text = "Error occured";
            }
        }
    }
}