using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Searching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchingButton_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "";
            var peopleSum = Operation.TakeInfoFromTheList();
            var result = peopleSum.Where(x => x.Country == this.txtBoxID.Text);
            repeater.DataSource = result;
            repeater.DataBind();
           


            {

            }
        }
    }
}