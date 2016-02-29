using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class AddInfoForTheProgram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
           
            var infoToAdd = new Info(
                this.capitalTextBox.Text,
                this.countryTextBox.Text,
                int.Parse(this.peopleTextBox.Text));
            
           
            if (Operation.AddInfo(infoToAdd))
            {
                this.labelMessage.Text = "Successfully added";
                this.capitalTextBox.Text = string.Empty;
                this.countryTextBox.Text = string.Empty;
                this.peopleTextBox.Text = string.Empty;
                

            }
            else
            {
                this.labelMessage.ForeColor = System.Drawing.Color.Red;
                this.labelMessage.Text = "An error occured while adding the country";

            }

           
        }
    }
}