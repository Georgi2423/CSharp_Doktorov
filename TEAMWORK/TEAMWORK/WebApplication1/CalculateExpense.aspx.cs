using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CalculateExpense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void dropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var dateCalculate = Operation.TakeInfoFromTheBase();
            var calculatedExpense = new List<Info>();
            double sumOfProducts = 0;
            foreach (var item in dateCalculate)
            {
                
                if (DateTime.Now.AddDays(-int.Parse(this.dropdownList.SelectedValue)) < item.Date && item.Date < DateTime.Now)
                {
                    sumOfProducts += item.Price;
                    
                }
                

            }
            this.messageLabel.Text = sumOfProducts.ToString();


        }
    }
}